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
    public static class CodeAnalyze1_Solution
    {
        /// <summary>
        /// 
        /// </summary>
        public static async Task<TC_Solution> RunAsync(string solutionFile)
        {
            //MSBuildWorkspace.Create().OpenSolutionAsync(solutionFile).ContinueWith(
            //    async (task) =>
            //    {
            //        var a = task.Result;
            //        System.Console.WriteLine("Enter callback");
            //        await Task.Delay(1000);
            //        System.Console.WriteLine("Leave callback");
            //    },
            //    TaskContinuationOptions.AttachedToParent).Wait();

            var codeAnalysisSolution = await MSBuildWorkspace.Create().OpenSolutionAsync(solutionFile);

            var solutionName = codeAnalysisSolution.FilePath.Substring(codeAnalysisSolution.FilePath.LastIndexOf("\\") + 1);
            solutionName = solutionName.Substring(0, solutionName.IndexOf("."));

            var tcSolution = new TC_Solution
            {
                Name = solutionName,
                IdCounter = new IdCounter()
                //var solution = await MSBuildWorkspace.Create().OpenSolutionAsync(@"D:\work\5_UnikktleDefense\trunk\3_TestData\1_コンソール\ConsoleApp1\ConsoleApp1.sln");
            };

            // 先に全プロジェクトのリソースファイルを抽出しておく
            foreach (var codeAnalysisProject in codeAnalysisSolution.Projects)
            {
                CodeAnalyze2_Project.Project単位_Resx(codeAnalysisProject, tcSolution);
            }

            foreach (var codeAnalysisProject in codeAnalysisSolution.Projects)
            {
                await CodeAnalyze2_Project.Project単位(codeAnalysisSolution, codeAnalysisProject, tcSolution);
            }


            return tcSolution;
        }


        private static void 重複メソッド抽出(TC_Solution tcSolution)
        {
            foreach (var tcProject in tcSolution.ProjectList)
            {
                foreach (var tcSrcFile in tcProject.SrcFileList)
                {
                    foreach (var tcNamespace in tcSrcFile.NamespaceList)
                    {
                        foreach (var tcClass in tcNamespace.ClassList)
                        {
                            foreach (var tcMethod in tcClass.MethodList)
                            {
                                重複メソッド抽出_探索(tcMethod, tcSolution);
                            }
                        }
                    }
                }
            }
        }

        //private static void 重複メソッド抽出_探索(TC_Project tcProject元, TC_SrcFile tcSrcFile元, TC_Method tcMethod元, TC_Class tcClassList元, 
        //    TC_Solution tcSolution)
        private static void 重複メソッド抽出_探索(TC_Method tcMethod元, TC_Solution tcSolution)
        {
            foreach (var tcProject in tcSolution.ProjectList)
            {
                foreach (var tcSrcFile in tcProject.SrcFileList)
                {
                    foreach (var tcNamespace in tcSrcFile.NamespaceList)
                    {
                        foreach (var tcClass in tcNamespace.ClassList)
                        {
                            foreach (var tcMethod in tcClass.MethodList)
                            {
                                if (tcMethod元.ソースコード != tcMethod.ソースコード)
                                {
                                    continue;
                                }

                                tcMethod元.重複メソッドList.Add(new TC_重複メソッド()
                                {
                                    ProjectName = tcProject.Name,
                                    ProjectFilePath = tcProject.FilePath,
                                    SrcFileName = tcSrcFile.Name,
                                    SrcFileFilePath = tcSrcFile.FilePath,
                                    NamespaceName = tcNamespace.Name,
                                    ClassName = tcClass.Name,
                                    メソッドName = tcMethod.Name,
                                });

                            }
                        }
                    }
                }
            }
        }



    }
}
