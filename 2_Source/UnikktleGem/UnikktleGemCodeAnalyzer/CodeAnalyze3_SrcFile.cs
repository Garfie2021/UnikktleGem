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
    class CodeAnalyze3_SrcFile
    {
        public static async Task SrcFile単位(Solution codeAnalysisSolution, Document codeAnalysisDocument, 
            TC_Solution tcSolution, TC_Project tcProject)
        {
            try
            {
                LoggerSt.Debug("Document Name : " + codeAnalysisDocument.Name);

                if (codeAnalysisDocument.Name == "AssemblyInfo.cs" ||
                    codeAnalysisDocument.Name.StartsWith(".NETFramework,Version") ||
                    (codeAnalysisDocument.Name.IndexOf(".Designer.cs") > -1))
                {
                    // 今は不要。
                    // ToDo: 後でオプション設定できるようにしとく。
                    return;
                }

                var tcSrcFile = new TC_SrcFile()
                {
                    ID = tcSolution.IdCounter.SrcFile++,
                    Name = codeAnalysisDocument.Name,
                    FilePath = codeAnalysisDocument.FilePath
                };

                // SemanticModel、SyntaxTreeはドキュメント単位に作るもの。
                var semanticModel = await codeAnalysisDocument.GetSemanticModelAsync();
                var syntaxTree = await codeAnalysisDocument.GetSyntaxTreeAsync();

                var compilationUnitRoot = syntaxTree.GetCompilationUnitRoot();
                //var root = syntaxTree.GetRoot();

                //var visitor = new TypeParameterVisitor();
                //var node = visitor.Visit(compilationUnitRoot);
                //var sourceCode = node.GetText().ToString();
                //var tree = CSharpSyntaxTree.ParseText(sourceCode);

                LoggerSt.Debug("【SyntaxAnalyze】");
                LoggerSt.Debug($"The tree is a [{compilationUnitRoot.Kind()}] node.");
                LoggerSt.Debug($"The tree has [{compilationUnitRoot.Members.Count}] elements in it.");
                LoggerSt.Debug($"The tree has [{compilationUnitRoot.Usings.Count}] using statements. They are:");

                foreach (var element in compilationUnitRoot.Usings)
                {
                    tcSrcFile.UsingNamespaceList.Add(element.Name.ToString());
                }

                foreach (var namespaceMember in compilationUnitRoot.Members)
                {
                    tcSrcFile.NamespaceList.Add(await CodeAnalyze4_Namespace.Namespace単位Async(codeAnalysisSolution, semanticModel,
                        (NamespaceDeclarationSyntax)namespaceMember, tcSolution, tcSrcFile));
                }

                tcProject.SrcFileList.Add(tcSrcFile);
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, codeAnalysisDocument.ToString());
            }
        }

    }
}
