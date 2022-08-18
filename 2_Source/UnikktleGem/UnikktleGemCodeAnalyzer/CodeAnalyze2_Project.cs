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
    public static class CodeAnalyze2_Project
    {
        public static void Project単位_Resx(Project codeAnalysisProject, 
            TC_Solution tcSolution)
        {
            var tcProject = new TC_Project()
            {
                ID = tcSolution.IdCounter.Project++,
                Name = codeAnalysisProject.Name,
                FilePath = codeAnalysisProject.FilePath,
                ResxFileList = FileListUp_Resx(tcSolution, codeAnalysisProject.FilePath)
            };

            tcSolution.ProjectList.Add(tcProject);
        }

        public static async Task Project単位(Solution codeAnalysisSolution, Project codeAnalysisProject,
            TC_Solution tcSolution)
        {
            LoggerSt.Debug("Project Name : " + codeAnalysisProject.Name);

            // コンパイラ。プロジェクト単位。ソリューションからはコンパイラを作れない。
            var compilation = await codeAnalysisProject.GetCompilationAsync();

            foreach (var codeAnalysisDocument in codeAnalysisProject.Documents)
            {
                var tcProject = tcSolution.ProjectList.First(x => x.FilePath == codeAnalysisProject.FilePath);

                //var compilation = await codeAnalysisProject.GetCompilationAsync();

                await CodeAnalyze3_SrcFile.SrcFile単位(codeAnalysisSolution, codeAnalysisDocument, tcSolution, tcProject);
            }
        }

        /// <summary>
        /// 指定プロジェクト配下にある .resx ファイルをリストアップする
        /// </summary>
        public static List<TC_ResxFile> FileListUp_Resx(TC_Solution tcSolution, string projectFilePath)
        {
            // Todo:未実装

            var projectFolderPath = projectFilePath.Substring(0, projectFilePath.LastIndexOf("\\"));

            var tcResxFileList = new List<TC_ResxFile>();
            foreach (var filePath in Directory.GetFiles(projectFolderPath, "*", SearchOption.AllDirectories))
            {
                if (!filePath.EndsWith(".resx"))
                {
                    continue;
                }

                var name = filePath.Substring(filePath.LastIndexOf("\\") + "\\".Length);
                name = name.Substring(0, name.LastIndexOf("."));

                var tcResxFile = new TC_ResxFile()
                {
                    ID = tcSolution.IdCounter.ResxFile++,
                    Name = name,
                    FilePath = filePath,
                    ResourceDictionary = リソースを列挙(filePath)
                };

                tcResxFileList.Add(tcResxFile);
            }

            return tcResxFileList;
        }

        public static Dictionary<string, string> リソースを列挙(string resxFilePath)
        {
            var resourceDictionary = new Dictionary<string, string>();

            LoggerSt.Debug($"Analyze start. [{resxFilePath}]");

            using (var resxReader = new ResXResourceReader(resxFilePath))
            {
                try
                {
                    foreach (DictionaryEntry entry in resxReader)
                    {
                        if (entry.Value is string)
                        {
                            resourceDictionary.Add((string)entry.Key, (string)entry.Value);
                        }
                        else
                        {
                            // 適当に例外を発生させてログに残す
                            var syntax = (string)entry.Value;
                        }
                    }
                }
                catch (Exception ex)
                {
                    LoggerSt.Debug("Not Implimented. [foreach (DictionaryEntry entry in resxReader)]");
                    LoggerSt.Trace(ex);
                }
            }

            return resourceDictionary;
        }
    }
}
