using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.CodeAnalysis.MSBuild;
using System.Windows.Forms;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;

namespace UnikktleGemCodeAnalyzer
{
    public static class CodeAnalyze5_Class
    {
 
        public static async Task<TC_Class> Class単位Async(Solution codeAnalysisSolution, SemanticModel semanticModel, ClassDeclarationSyntax classSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile)
        {
            try
            {
                LoggerSt.Debug($"There are [{classSyntax.Members.Count}] members declared in the [{classSyntax.Identifier}] class.");

                var symbol = semanticModel.GetDeclaredSymbol(classSyntax);

                var tcClass = new TC_Class()
                {
                    DeclaredSymbol = DeclaredSymbolConvert.NamedTypeSymbol(symbol),
                    Name = classSyntax.Identifier.ToString()
                };

                // 継承を解析
                var classBase = ClassBaseList(classSyntax);
                if (classBase != null)
                {
                    tcClass.BaseNameList = classBase;
                }

                foreach (var member in classSyntax.Members)
                {
                    try
                    {
                        LoggerSt.Debug($"The member is a [{member.Kind()}].");

                        if (member is ClassDeclarationSyntax)
                        {
                            var classMember = await Class単位Async(codeAnalysisSolution, semanticModel, (ClassDeclarationSyntax)member, tcSolution, tcNamespace, tcSrcFile);

                            if (classMember != null)
                            {
                                tcClass.ClassList.Add(classMember);
                            }
                        }
                        else if (member is InterfaceDeclarationSyntax)
                        {
                            var interfaceMember = CodeAnalyzer.Interface単位(tcSolution, semanticModel, (InterfaceDeclarationSyntax)member);

                            if (interfaceMember != null)
                            {
                                tcClass.InterfaceList.Add(interfaceMember);
                            }
                        }
                        else if (member is MethodDeclarationSyntax)
                        {
                            var methodMember = await CodeAnalyze6_Method.SyntaxAnalyze_MethodMember(codeAnalysisSolution, semanticModel, (MethodDeclarationSyntax)member,
                                tcSolution, tcNamespace, tcSrcFile);

                            if (methodMember != null)
                            {
                                tcClass.MethodList.Add(methodMember);
                            }
                        }
                        else if (member is EventFieldDeclarationSyntax)
                        {
                            // 今は不要
                        }
                        else if (member is PropertyDeclarationSyntax)
                        {
                            var propertyMember = CodeAnalyzer.SyntaxAnalyze_PropertyMember(tcSolution, semanticModel, (PropertyDeclarationSyntax)member);

                            if (propertyMember != null)
                            {
                                tcClass.PropertyList.Add(propertyMember);
                            }
                        }
                        else if (member is ConstructorDeclarationSyntax)
                        {
                            var constructorMember = CodeAnalyzer.SyntaxAnalyze_ConstructorMember(tcSolution, semanticModel, (ConstructorDeclarationSyntax)member);

                            if (constructorMember != null)
                            {
                                tcClass.ConstructorList.Add(constructorMember);
                            }
                        }
                        else if (member is DestructorDeclarationSyntax)
                        {
                            var destructor = CodeAnalyzer.SyntaxAnalyze_ConstructorMember(tcSolution, semanticModel, (DestructorDeclarationSyntax)member);

                            if (destructor != null)
                            {
                                tcClass.ConstructorList.Add(destructor);
                            }
                        }
                        else if (member is FieldDeclarationSyntax)
                        {
                            var fieldMember = CodeAnalyzer.SyntaxAnalyze_FieldMember(tcSolution, semanticModel, (FieldDeclarationSyntax)member);

                            if (fieldMember != null)
                            {
                                tcClass.FieldList.Add(fieldMember);
                            }
                        }
                        else if (member is IndexerDeclarationSyntax)
                        {
                            var indexerMember = CodeAnalyzer.SyntaxAnalyze_IndexerMember(tcSolution, semanticModel, (IndexerDeclarationSyntax)member);

                            if (indexerMember != null)
                            {
                                tcClass.IndexerList.Add(indexerMember);
                            }
                        }
                        else if (member is EventDeclarationSyntax)
                        {
                            var eventMember = CodeAnalyzer.SyntaxAnalyze_EventMember(tcSolution, semanticModel, (EventDeclarationSyntax)member);

                            if (eventMember != null)
                            {
                                tcClass.EventList.Add(eventMember);
                            }
                        }
                        else if (member is DelegateDeclarationSyntax)
                        {
                            var delegateMember = CodeAnalyzer.SyntaxAnalyze_DelegateMember(tcSolution, semanticModel, (DelegateDeclarationSyntax)member);

                            if (delegateMember != null)
                            {
                                tcClass.DelegateList.Add(delegateMember);
                            }
                        }
                        else if (member is StructDeclarationSyntax)
                        {
                            var structMember = CodeAnalyzer.SyntaxAnalyze_StructMember(tcSolution, semanticModel, (StructDeclarationSyntax)member);

                            if (structMember != null)
                            {
                                tcClass.StructList.Add(structMember);
                            }
                        }
                        else if (member is EnumDeclarationSyntax)
                        {
                            var enumMember = CodeAnalyzer.SyntaxAnalyze_EnumMember(tcSolution, semanticModel, (EnumDeclarationSyntax)member);

                            if (enumMember != null)
                            {
                                tcClass.EnumList.Add(enumMember);
                            }
                        }
                        else
                        {
                            // 適当に例外を発生させてログに残す
                            var syntax = (ClassDeclarationSyntax)member;
                        }
                    }
                    catch (Exception ex)
                    {
                        LoggerSt.Info("Not impremented.", ex, member.ToFullString());
                    }
                }

                return tcClass;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, classSyntax.ToFullString());
            }

            return null;
        }

        public static List<string> ClassBaseList(ClassDeclarationSyntax classSyntax)
        {
            try
            {
                if (classSyntax.BaseList == null)
                {
                    return null;
                }

                var baseList = new List<string>();
                foreach (var type in classSyntax.BaseList.Types)
                {
                    if (type.Type is IdentifierNameSyntax)
                    {
                        baseList.Add(((IdentifierNameSyntax)type.Type).Identifier.ValueText);
                    }
                    else if (type.Type is QualifiedNameSyntax)
                    {
                        // 今は不要
                    }
                    else if (type.Type is GenericNameSyntax)
                    {
                        // 今は不要
                    }
                    else
                    {
                        // 適当に例外を発生させてログに残す
                        var syntax = (IdentifierNameSyntax)type.Type;
                    }
                }

                return baseList;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, classSyntax.ToFullString());
            }

            return null;
        }

    }
}
