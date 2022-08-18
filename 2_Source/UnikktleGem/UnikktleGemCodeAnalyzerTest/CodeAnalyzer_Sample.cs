using UnikktleGemCodeAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnikktleGemConst;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace UnikktleGemCodeAnalyzer.Tests
{
    public static class CodeAnalyzer_Sample
    {
        public static string SemanticAnalyze(string assemblyName, string sourceCode)
        {
            var log = "";

            // sourceCodeのコード テキストの構文ツリーをビルドする。
            var tree = CSharpSyntaxTree.ParseText(sourceCode);
            var root = tree.GetCompilationUnitRoot();

            // 作成済みのツリーから CSharpCompilation をビルドします。 
            // "Hello World" サンプルは、String 型と Console 型に基づきます。 
            // コンパイルでこの 2 つの型を宣言するアセンブリを参照する必要があります。 
            // Main メソッドに次の行を追加し、適切なアセンブリの参照を含む、構文ツリーのコンパイルを作成します。
            // CSharpCompilation.AddReferences メソッドはコンパイルに参照を追加します。
            // MetadataReference.CreateFromFile メソッドは参照としてアセンブリを読み込みます。
            var compilation = CSharpCompilation.Create(assemblyName)
                .AddReferences(MetadataReference.CreateFromFile(typeof(string).Assembly.Location))
                .AddSyntaxTrees(tree);

            var semanticModel = compilation.GetSemanticModel(tree);

            // Use the syntax tree to find "using System;"
            foreach (var usingSystem in root.Usings)
            {
                var systemName = usingSystem.Name;

                // Use the semantic model for symbol information:
                var nameInfo = semanticModel.GetSymbolInfo(systemName);

                var systemSymbol = (INamespaceSymbol)nameInfo.Symbol;
                if (systemSymbol == null)
                {
                    continue;
                }

                foreach (var ns in systemSymbol.GetNamespaceMembers())
                {
                    System.Diagnostics.Debug.WriteLine(ns.ToString());
                }
            }


            // Use the syntax model to find the literal string:
            var descendantNodes = root.DescendantNodes();
            var literalExpressionSyntax = descendantNodes.OfType<LiteralExpressionSyntax>();

            foreach (var helloWorldString in literalExpressionSyntax)
            {
                // Use the semantic model for type information:
                var literalInfo = semanticModel.GetTypeInfo(helloWorldString);

                // Microsoft.CodeAnalysis.TypeInfo 構造体には TypeInfo.Type プロパティが含まれます。このプロパティによって、
                // リテラルの型に関するセマンティック情報にアクセスできます。 この例では、string 型です。 
                // このプロパティをローカル変数に割り当てる宣言を追加します。
                var stringTypeSymbol = (INamedTypeSymbol)literalInfo.Type;

                // このチュートリアルの終わりとして、string を返す string 型で宣言されているすべてのパブリック メソッドの
                // シーケンスを作成する LINQ クエリをビルドしましょう。 このクエリは複雑になります。そのため、
                // 1 行ずつビルドしてから 1 つのクエリとして再構築します。 このクエリのソースは、
                // string 型で宣言されているすべてのメンバーのシーケンスです。
                var allMembers = stringTypeSymbol.GetMembers();

                // そのソース シーケンスには、プロパティやフィールドなど、すべてのメンバーが含まれています。
                // そのため、ImmutableArray<T>.OfType メソッドでフィルター処理し、
                // Microsoft.CodeAnalysis.IMethodSymbol オブジェクトである要素を見つけます。
                var methods = allMembers.OfType<IMethodSymbol>();

                // 次に、パブリック メソッドのみを返す別のフィルターを追加し、string を返します。
                var publicStringReturningMethods = methods
                    .Where(m => m.ReturnType.Equals(stringTypeSymbol) &&
                    m.DeclaredAccessibility == Accessibility.Public);

                // 名前プロパティのみを選択します。オーバーロードを削除し、別個の名前のみを選択します。
                var distinctMethods = publicStringReturningMethods.Select(m => m.Name).Distinct();

                // LINQ クエリ構文で完全クエリをビルドし、コンソールにすべてのメソッド名を表示することもできます。
                foreach (string name in (from method in stringTypeSymbol
                             .GetMembers().OfType<IMethodSymbol>()
                                         where method.ReturnType.Equals(stringTypeSymbol) &&
                                         method.DeclaredAccessibility == Accessibility.Public
                                         select method.Name).Distinct())
                {
                    System.Diagnostics.Debug.WriteLine(name);
                }
            }

            return log;
        }

    }

    public class UsingCollector : CSharpSyntaxWalker
    {
        public ICollection<UsingDirectiveSyntax> Usings { get; } = new List<UsingDirectiveSyntax>();

        public override void VisitUsingDirective(UsingDirectiveSyntax node)
        {
            System.Diagnostics.Debug.WriteLine($"\tVisitUsingDirective called with [{node.Name}].");

            if (node.Name.ToString() != "System" && !node.Name.ToString().StartsWith("System."))
            {
                System.Diagnostics.Debug.WriteLine($"\t\tSuccess. Adding [{node.Name}].");

                this.Usings.Add(node);
            }

        }
    }


}
