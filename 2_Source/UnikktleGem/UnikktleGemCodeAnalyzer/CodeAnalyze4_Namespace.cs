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
    public static class CodeAnalyze4_Namespace
    {
        public static async Task<TC_Namespace> Namespace単位Async(Solution codeAnalysisSolution, SemanticModel semanticModel, 
            NamespaceDeclarationSyntax namespaceSyntax, TC_Solution tcSolution, TC_SrcFile tcSrcFile)
        {
            try
            {
                LoggerSt.Debug($"The member is a {namespaceSyntax.Name}.");

                var symbol = semanticModel.GetDeclaredSymbol(namespaceSyntax);

                var tcNamespace = new TC_Namespace()
                {
                    ID = tcSolution.IdCounter.Namespace++,
                    DeclaredSymbol = DeclaredSymbolConvert.NamespaceSymbol(symbol),
                    Name = namespaceSyntax.Name.ToString()
                };

                LoggerSt.Debug($"There are [{namespaceSyntax.Members.Count}] members declared in this namespace.");
                LoggerSt.Debug($"The member is a [{namespaceSyntax.Members[0].Kind()}].");

                foreach (var namespaceMember in namespaceSyntax.Members)
                {
                    await NamespaceMember単位Async(codeAnalysisSolution, semanticModel, namespaceMember, tcSolution, tcSrcFile, tcNamespace);
                }

                return tcNamespace;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, namespaceSyntax.ToFullString());
            }

            return null;
        }

        public static async Task NamespaceMember単位Async(Solution codeAnalysisSolution, SemanticModel semanticModel, MemberDeclarationSyntax namespaceMember, 
            TC_Solution tcSolution, TC_SrcFile tcSrcFile, TC_Namespace tcNamespace)
        {
            try
            {
                // ClassDeclarationSyntaxにキャストする意図は？
                if (namespaceMember is ClassDeclarationSyntax)
                {
                    tcNamespace.ClassList.Add(await CodeAnalyze5_Class.Class単位Async(codeAnalysisSolution, semanticModel, (ClassDeclarationSyntax)namespaceMember,
                        tcSolution, tcNamespace, tcSrcFile));
                }
                else if (namespaceMember is InterfaceDeclarationSyntax)
                {
                    tcNamespace.InterfaceList.Add(CodeAnalyzer.Interface単位(tcSolution, semanticModel, (InterfaceDeclarationSyntax)namespaceMember));
                }
                else if (namespaceMember is StructDeclarationSyntax)
                {
                    tcNamespace.StructList.Add(CodeAnalyzer.Struct単位(tcSolution, semanticModel, (StructDeclarationSyntax)namespaceMember));
                }
                else if (namespaceMember is EnumDeclarationSyntax)
                {
                    tcNamespace.EnumList.Add(CodeAnalyzer.Enum単位(tcSolution, semanticModel, (EnumDeclarationSyntax)namespaceMember));
                }
                else if (namespaceMember is DelegateDeclarationSyntax)
                {
                    tcNamespace.DelegateList.Add(CodeAnalyzer.Delegate単位(tcSolution, semanticModel, (DelegateDeclarationSyntax)namespaceMember));
                }
                else if (namespaceMember is NamespaceDeclarationSyntax)
                {
                    tcNamespace.NamespaceList.Add(await Namespace単位Async(codeAnalysisSolution, semanticModel, (NamespaceDeclarationSyntax)namespaceMember,
                        tcSolution, tcSrcFile));
                }
                else
                {
                    // 適当に例外を発生させてログに残す
                    var syntax = (ClassDeclarationSyntax)namespaceMember;
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, namespaceMember.ToFullString());
            }
        }
    }
}
