using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnikktleGemCodeAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using UnikktleGemConst;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace UnikktleGemCodeAnalyzer.Tests
{
    [TestClass()]
    public class CodeAnalyzer2Tests
    {
        [TestMethod()]
        public void Sample実行Test()
        {
            var aa = Directory.GetCurrentDirectory();

            var sourceCode = File.ReadAllText(@"..\..\TestData\sample1.cs");

            CodeAnalyzer_Sample.SemanticAnalyze("HelloWorld", sourceCode);

            //TryStatementSyntax statementSyntax = new TryStatementSyntax();
            //TC_Namespace tcNamespace = new TC_Namespace();
            //TC_SrcFile tcSrcFile = new TC_SrcFile();
            //TC_Method tcMethod = new TC_Method();
            //CodeAnalyzer2.TryStatementSyntax共通(statementSyntax, tcNamespace, tcSrcFile, tcMethod);

        }

        [TestMethod()]
        public void TryStatementSyntax共通Test()
        {
            //TryStatementSyntax statementSyntax = new TryStatementSyntax();
            //TC_Namespace tcNamespace = new TC_Namespace();
            //TC_SrcFile tcSrcFile = new TC_SrcFile();
            //TC_Method tcMethod = new TC_Method();
            //CodeAnalyzer2.TryStatementSyntax共通(statementSyntax, tcNamespace, tcSrcFile, tcMethod);

        }
    }




}