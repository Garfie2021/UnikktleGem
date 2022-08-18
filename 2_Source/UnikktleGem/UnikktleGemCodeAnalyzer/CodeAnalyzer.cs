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
    public static class CodeAnalyzer
    {


        public static TC_Interface Interface単位(TC_Solution tcSolution, SemanticModel semanticModel, InterfaceDeclarationSyntax interfaceSyntax)
        {
            try
            {
                var tcInterface = new TC_Interface()
                {
                    ID = tcSolution.IdCounter.Interface++,
                    //DeclaredSymbol = semanticModel.GetDeclaredSymbol(interfaceSyntax),
                    Name = interfaceSyntax.Identifier.ToString()
                };

                return tcInterface;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, interfaceSyntax.ToFullString());
            }

            return null;
        }

        public static TC_Struct Struct単位(TC_Solution tcSolution, SemanticModel semanticModel, StructDeclarationSyntax structSyntax)
        {
            try
            {
                var tcStruct = new TC_Struct()
                {
                    ID = tcSolution.IdCounter.Struct++,
                    //DeclaredSymbol = semanticModel.GetDeclaredSymbol(structSyntax),
                    Name = structSyntax.Identifier.ToString()
                };

                return tcStruct;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, structSyntax.ToFullString());
            }

            return null;
        }

        public static TC_Enum Enum単位(TC_Solution tcSolution, SemanticModel semanticModel, EnumDeclarationSyntax enumSyntax)
        {
            try
            {
                var tcEnum = new TC_Enum()
                {
                    ID = tcSolution.IdCounter.Enum++,
                    //DeclaredSymbol = semanticModel.GetDeclaredSymbol(enumSyntax),
                    Name = enumSyntax.Identifier.ToString()
                };

                return tcEnum;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, enumSyntax.ToFullString());
            }

            return null;
        }

        public static TC_Delegate Delegate単位(TC_Solution tcSolution, SemanticModel semanticModel, DelegateDeclarationSyntax delegateSyntax)
        {
            try
            {
                var tcDelegate = new TC_Delegate()
                {
                    ID = tcSolution.IdCounter.Delegate++,
                    //DeclaredSymbol = semanticModel.GetDeclaredSymbol(delegateSyntax),
                    Name = delegateSyntax.Identifier.ToString()
                };

                return tcDelegate;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, delegateSyntax.ToFullString());
            }

            return null;
        }

        public static TC_Property SyntaxAnalyze_PropertyMember(TC_Solution tcSolution, SemanticModel semanticModel, PropertyDeclarationSyntax propertySyntax)
        {
            try
            {
                var tcProperty = new TC_Property()
                {
                    ID = tcSolution.IdCounter.Property++,
                    //DeclaredSymbol = semanticModel.GetDeclaredSymbol(propertySyntax),
                    Name = propertySyntax.Identifier.ToString()
                };

                return tcProperty;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, propertySyntax.ToFullString());
            }

            return null;
        }

        public static TC_Constructor SyntaxAnalyze_ConstructorMember(TC_Solution tcSolution, SemanticModel semanticModel, ConstructorDeclarationSyntax constructorSyntax)
        {
            try
            {
                var tcConstructor = new TC_Constructor()
                {
                    ID = tcSolution.IdCounter.Constructor++,
                    //DeclaredSymbol = semanticModel.GetDeclaredSymbol(constructorSyntax),
                    Name = constructorSyntax.Identifier.ToString()
                };

                return tcConstructor;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, constructorSyntax.ToFullString());
            }

            return null;
        }

        public static TC_Constructor SyntaxAnalyze_ConstructorMember(TC_Solution tcSolution, SemanticModel semanticModel, DestructorDeclarationSyntax destructor)
        {
            try
            {
                var tcConstructor = new TC_Constructor()
                {
                    ID = tcSolution.IdCounter.Constructor++,
                    //DeclaredSymbol = semanticModel.GetDeclaredSymbol(destructor),
                    Name = destructor.Identifier.ToString()
                };

                return tcConstructor;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, destructor.ToFullString());
            }

            return null;
        }


        public static TC_Field SyntaxAnalyze_FieldMember(TC_Solution tcSolution, SemanticModel semanticModel, FieldDeclarationSyntax fieldSyntax)
        {
            try
            {
                if (fieldSyntax.Modifiers.Count() > 0)
                {
                    var tcField = new TC_Field()
                    {
                        ID = tcSolution.IdCounter.Field++,
                        //DeclaredSymbol = semanticModel.GetDeclaredSymbol(fieldSyntax),
                        Name = fieldSyntax.Modifiers[0].Text
                    };

                    return tcField;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, fieldSyntax.ToFullString());
            }

            return null;
        }

        public static TC_Indexer SyntaxAnalyze_IndexerMember(TC_Solution tcSolution, SemanticModel semanticModel, IndexerDeclarationSyntax indexerSyntax)
        {
            try
            {
                var tcIndexer = new TC_Indexer()
                {
                    ID = tcSolution.IdCounter.Indexer++,
                    //DeclaredSymbol = semanticModel.GetDeclaredSymbol(indexerSyntax),
                    Name = indexerSyntax.Modifiers[0].Text
                };

                return tcIndexer;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, indexerSyntax.ToFullString());
            }

            return null;
        }

        public static TC_Event SyntaxAnalyze_EventMember(TC_Solution tcSolution, SemanticModel semanticModel, EventDeclarationSyntax eventSyntax)
        {
            try
            {
                var tcEvent = new TC_Event()
                {
                    ID = tcSolution.IdCounter.Event++,
                    //DeclaredSymbol = semanticModel.GetDeclaredSymbol(eventSyntax),
                    Name = eventSyntax.Identifier.ToString()
                };

                return tcEvent;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, eventSyntax.ToFullString());
            }

            return null;
        }

        public static TC_Delegate SyntaxAnalyze_DelegateMember(TC_Solution tcSolution, SemanticModel semanticModel, DelegateDeclarationSyntax delegateSyntax)
        {
            try
            {
                var tcDelegate = new TC_Delegate()
                {
                    ID = tcSolution.IdCounter.Delegate++,
                    //DeclaredSymbol = semanticModel.GetDeclaredSymbol(delegateSyntax),
                    Name = delegateSyntax.Identifier.ToString()
                };

                return tcDelegate;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, delegateSyntax.ToFullString());
            }

            return null;
        }

        public static TC_Struct SyntaxAnalyze_StructMember(TC_Solution tcSolution, SemanticModel semanticModel, StructDeclarationSyntax structSyntax)
        {
            try
            {
                var tcStruct = new TC_Struct()
                {
                    ID = tcSolution.IdCounter.Struct++,
                    //DeclaredSymbol = semanticModel.GetDeclaredSymbol(structSyntax),
                    Name = structSyntax.Identifier.ToString()
                };

                return tcStruct;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, structSyntax.ToFullString());
            }

            return null;
        }

        public static TC_Enum SyntaxAnalyze_EnumMember(TC_Solution tcSolution, SemanticModel semanticModel, EnumDeclarationSyntax enumSyntax)
        {
            try
            {
                var tcEnum = new TC_Enum()
                {
                    ID = tcSolution.IdCounter.Enum++,
                    //DeclaredSymbol = semanticModel.GetDeclaredSymbol(enumSyntax),
                    Name = enumSyntax.Identifier.ToString()
                };

                return tcEnum;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, enumSyntax.ToFullString());
            }

            return null;
        }
    }


    public class TypeParameterVisitor : CSharpSyntaxRewriter
    {
        public override SyntaxNode VisitTypeParameterList(TypeParameterListSyntax node)
        {
            var syntaxList = new SeparatedSyntaxList<TypeParameterSyntax>();
            syntaxList = syntaxList.Add(SyntaxFactory.TypeParameter("TParameter"));

            var lessThanToken = this.VisitToken(node.LessThanToken);
            var greaterThanToken = this.VisitToken(node.GreaterThanToken);

            return node.Update(lessThanToken, syntaxList, greaterThanToken);
        }
    }

}
