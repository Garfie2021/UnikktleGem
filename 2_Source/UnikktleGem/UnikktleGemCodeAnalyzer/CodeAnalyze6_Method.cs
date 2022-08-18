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
using Microsoft.CodeAnalysis.FindSymbols;
using Microsoft.CodeAnalysis.MSBuild;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;

namespace UnikktleGemCodeAnalyzer
{
    public static class CodeAnalyze6_Method
    {
        public static async Task<TC_Method> SyntaxAnalyze_MethodMember(Solution codeAnalysisSolution, 
            SemanticModel semanticModel, MethodDeclarationSyntax methodSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile)
        {
            try
            {
                LoggerSt.Debug($"The return type of the [{methodSyntax.Identifier}] method is [{methodSyntax.ReturnType}].");
                LoggerSt.Debug($"The method has [{methodSyntax.ParameterList.Parameters.Count}] parameters.");

                var symbol = semanticModel.GetDeclaredSymbol(methodSyntax);

                var tcMethod = new TC_Method()
                {
                    DeclaredSymbol = DeclaredSymbolConvert.MethodSymbol(tcSrcFile.FilePath, symbol),
                    Name = methodSyntax.Identifier.ToString(),
                    ソースコード = methodSyntax.ToFullString()
                };

                // ソリューション全体で、このメソッドを呼び出しているメソッドをリストアップ
                foreach (var referencer in await SymbolFinder.FindCallersAsync(symbol, codeAnalysisSolution))
                {
                    foreach (var declaringSyntaxReferences in referencer.CallingSymbol.DeclaringSyntaxReferences)
                    {
                        //var filePath = ((CSharpSyntaxTree.ParsedSyntaxTree)((Microsoft.CodeAnalysis.CSharp.SimpleSyntaxReference)declaringSyntaxReferences).SyntaxTree).FilePath;

                        var syntax = declaringSyntaxReferences.GetSyntax();
                        if (syntax is MethodDeclarationSyntax)
                        {
                            var methodSyntax_CallingMethod = (MethodDeclarationSyntax)syntax;
                            var filePath = methodSyntax_CallingMethod.GetLocation().SourceTree.FilePath;

                            try
                            {
                                var declaredSymbol_CallingMethod = semanticModel.GetDeclaredSymbol(methodSyntax_CallingMethod);
                                tcMethod.DeclaredSymbolList_CallMethod.Add(DeclaredSymbolConvert.MethodSymbol(filePath, declaredSymbol_CallingMethod));
                            }
                            catch (Exception ex)
                            {
                                if (ex.HResult != -2147024809)
                                {
                                    throw;
                                }

                                // -2147024809 "構文ノードが構文ツリー内にありません" は正常な動作なので処理を続行する。
                            }
                        }
                        else if (syntax is ConstructorDeclarationSyntax)
                        {
                            var constructorSyntax_CallingMethod = (ConstructorDeclarationSyntax)syntax;
                            var filePath = constructorSyntax_CallingMethod.GetLocation().SourceTree.FilePath;
                            tcMethod.DeclaredSymbolList_CallConstructor.Add(new TC_ConstructorSymbol()
                            {
                                FilePath = filePath,
                                ClassName = constructorSyntax_CallingMethod.Identifier.ValueText
                            });
                        }
                        else if (syntax is DestructorDeclarationSyntax)
                        {
                            var DestructorSyntax_CallingMethod = (DestructorDeclarationSyntax)syntax;
                            var filePath = DestructorSyntax_CallingMethod.GetLocation().SourceTree.FilePath;
                            tcMethod.DeclaredSymbolList_CallDestructor.Add(new TC_DestructorSymbol()
                            {
                                FilePath = filePath,
                                ClassName = DestructorSyntax_CallingMethod.Identifier.ValueText
                            });
                        }
                        else if (syntax is PropertyDeclarationSyntax)
                        {
                            var callingProperty = (PropertyDeclarationSyntax)syntax;
                            
                            var filePath = callingProperty.GetLocation().SourceTree.FilePath;
                            tcMethod.DeclaredSymbolList_CallProperty.Add(new TC_PropertySymbol()
                            {
                                FilePath = filePath,
                                ClassName = ((ClassDeclarationSyntax)callingProperty.Parent).Identifier.ValueText,
                                PropertyName = callingProperty.Identifier.ValueText
                            });
                        }
                        else
                        {
                            // 適当に例外を発生させてログに残す
                            var tmp = (MethodDeclarationSyntax)syntax;
                        }

                    }
                }

                foreach (ParameterSyntax parameter in methodSyntax.ParameterList.Parameters)
                {
                    LoggerSt.Debug($"The type of the [{parameter.Identifier}] parameter is [{parameter.Type}].");

                    var tcMethodParameter = new TC_MethodParameter()
                    {
                        Name = parameter.Identifier.ToString(),
                        ParameterType = parameter.Type.ToString()
                    };

                    tcMethod.MethodParameterList.Add(tcMethodParameter);
                }

                //LoggerSt.Debug($"The body text of the [{methodSyntax.Identifier}] method follows:[" + methodSyntax.Body.ToFullString() + "]\r\n");

                if (methodSyntax.Body != null)
                {
                    MethodBody(semanticModel, methodSyntax, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }

                //var argsParameter = methodSyntax.ParameterList.Parameters[0];

                //foreach (var firstParameters in from methodDeclaration in root.DescendantNodes()
                //                .OfType<MethodDeclarationSyntax>()
                //                                where methodDeclaration.Identifier.ValueText == "Main"
                //                                select methodDeclaration.ParameterList.Parameters)
                //{
                //    var argsParameter2 = firstParameters.Single();

                //    Log.WriteLog("[" + (argsParameter == argsParameter2) + "]\r\n");
                //}

                return tcMethod;
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, methodSyntax.ToFullString());
            }

            return null;

        }


        public static void MethodBody(SemanticModel semanticModel, MethodDeclarationSyntax methodSyntax, 
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            foreach (var statement in methodSyntax.Body.Statements)
            {
                CodeAnalyzer2.StatementSyntax共通(semanticModel, statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
            }
        }

    }
}
