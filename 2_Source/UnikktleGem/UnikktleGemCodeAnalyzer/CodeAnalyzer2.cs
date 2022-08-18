using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnikktleGemConst;
using UnikktleGemLog;

namespace UnikktleGemCodeAnalyzer
{
    public static class CodeAnalyzer2
    {

        public static void StatementSyntax共通(SemanticModel semanticModel, StatementSyntax statement,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                if (statement is ExpressionStatementSyntax)
                {
                    var symbolInfo = semanticModel.GetSymbolInfo(statement);
                    var typeInfo = semanticModel.GetTypeInfo(statement);
                    var declaredSymbol = semanticModel.GetDeclaredSymbol(statement);
                    // メソッド実行
                    ExpressionStatementSyntax共通((ExpressionStatementSyntax)statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is LocalDeclarationStatementSyntax)
                {
                    // 変数定義処理を解析
                    LocalDeclarationStatementSyntax共通((LocalDeclarationStatementSyntax)statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is ThrowStatementSyntax)
                {
                    // 例外処理
                    ThrowStatementSyntax共通((ThrowStatementSyntax)statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is IfStatementSyntax)
                {
                    // if文
                    IfStatementSyntax共通(semanticModel, (IfStatementSyntax)statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is SwitchStatementSyntax)
                {
                    // switch文
                    SwitchStatementSyntax共通(semanticModel, (SwitchStatementSyntax)statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is WhileStatementSyntax)
                {
                    // While文
                    WhileStatementSyntax共通(semanticModel, (WhileStatementSyntax)statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is ForEachStatementSyntax)
                {
                    // While文
                    ForEachStatementSyntax共通(semanticModel, (ForEachStatementSyntax)statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is ForStatementSyntax)
                {
                    ForStatementSyntax共通(semanticModel, (ForStatementSyntax)statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is DoStatementSyntax)
                {
                    DoStatementSyntax共通(semanticModel, (DoStatementSyntax)statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is GotoStatementSyntax)
                {
                    GotoStatementSyntax共通((GotoStatementSyntax)statement, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is ReturnStatementSyntax)
                {
                    // Return文
                    ReturnStatementSyntax共通((ReturnStatementSyntax)statement, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is LabeledStatementSyntax)
                {
                    // Return文
                    LabeledStatementSyntax共通((LabeledStatementSyntax)statement, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is TryStatementSyntax)
                {
                    // Try文
                    TryStatementSyntax共通(semanticModel, (TryStatementSyntax)statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is ContinueStatementSyntax)
                {
                    // Continue文
                    ContinueStatementSyntax共通((ContinueStatementSyntax)statement, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is BreakStatementSyntax)
                {
                    // Break文
                    BreakStatementSyntax共通((BreakStatementSyntax)statement, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is LockStatementSyntax)
                {
                    // Lock文
                    LockStatementSyntax共通((LockStatementSyntax)statement, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is UsingStatementSyntax)
                {
                    // Using文
                    UsingStatementSyntax共通((UsingStatementSyntax)statement, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is EmptyStatementSyntax)
                {
                    // Empty文
                    EmptyStatementSyntax共通((EmptyStatementSyntax)statement, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (statement is BlockSyntax)
                {
                    // Block
                    BlockSyntax共通(semanticModel, (BlockSyntax)statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else
                {
                    // 適当に例外を発生させてログに残す
                    var syntax = (ExpressionStatementSyntax)statement;
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, statement.ToFullString());
            }
        }

        public static void ExpressionStatementSyntax共通(ExpressionStatementSyntax expressionStatementSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                ExpressionSyntax共通(expressionStatementSyntax.Expression, tcSolution, tcNamespace, tcSrcFile, tcMethod);
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, expressionStatementSyntax.ToFullString());
            }
        }

        public static void LocalDeclarationStatementSyntax共通(LocalDeclarationStatementSyntax localDeclarationStatementSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                foreach (var variableDeclaratorSyntax in localDeclarationStatementSyntax.Declaration.Variables)
                {
                    if (variableDeclaratorSyntax.Initializer != null)
                    {
                        ExpressionSyntax共通(variableDeclaratorSyntax.Initializer.Value, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, localDeclarationStatementSyntax.ToFullString());
            }
        }

        public static void ThrowStatementSyntax共通(ThrowStatementSyntax throwStatementSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            ExpressionSyntax共通(throwStatementSyntax.Expression, tcSolution, tcNamespace, tcSrcFile, tcMethod);
        }

        public static void SwitchStatementSyntax共通(SemanticModel semanticModel, SwitchStatementSyntax switchStatementSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                foreach (var switchSectionSyntax in switchStatementSyntax.Sections)
                {
                    foreach (var statement in switchSectionSyntax.Statements)
                    {
                        StatementSyntax共通(semanticModel, statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, switchStatementSyntax.ToFullString());
            }
        }


        public static void ForEachStatementSyntax共通(SemanticModel semanticModel, ForEachStatementSyntax forEachStatementSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                StatementSyntax共通(semanticModel, forEachStatementSyntax.Statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, forEachStatementSyntax.ToFullString());
            }
        }

        public static void ForStatementSyntax共通(SemanticModel semanticModel, ForStatementSyntax forStatementSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                StatementSyntax共通(semanticModel, forStatementSyntax.Statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, forStatementSyntax.ToFullString());
            }
        }

        public static void DoStatementSyntax共通(SemanticModel semanticModel, DoStatementSyntax doStatementSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                StatementSyntax共通(semanticModel, doStatementSyntax.Statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, doStatementSyntax.ToFullString());
            }
        }

        public static void GotoStatementSyntax共通(GotoStatementSyntax gotoStatementSyntax,
            TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {

            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, gotoStatementSyntax.ToFullString());
            }
        }

        public static void WhileStatementSyntax共通(SemanticModel semanticModel, WhileStatementSyntax whileStatementSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                var blockSyntax = (BlockSyntax)whileStatementSyntax.Statement;
                foreach (var statement in blockSyntax.Statements)
                {
                    StatementSyntax共通(semanticModel, statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, whileStatementSyntax.ToFullString());
            }
        }


        public static void IfStatementSyntax共通(SemanticModel semanticModel, IfStatementSyntax ifStatementSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                StatementSyntax共通(semanticModel, ifStatementSyntax.Statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, ifStatementSyntax.ToFullString());
            }
        }

        public static void ReturnStatementSyntax共通(ReturnStatementSyntax statementSyntax,
            TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, statementSyntax.ToFullString());
            }
        }

        public static void LabeledStatementSyntax共通(LabeledStatementSyntax statementSyntax,
            TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, statementSyntax.ToFullString());
            }
        }

        public static void TryStatementSyntax共通(SemanticModel semanticModel, TryStatementSyntax statementSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                foreach (var statement in statementSyntax.Block.Statements)
                {
                    StatementSyntax共通(semanticModel, statement, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }

                foreach (var catche in statementSyntax.Catches)
                {
                    BlockSyntax共通(semanticModel, catche.Block, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }

                if (statementSyntax.Finally != null)
                {
                    BlockSyntax共通(semanticModel, statementSyntax.Finally.Block, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, statementSyntax.ToFullString());
            }
        }

        public static void ContinueStatementSyntax共通(ContinueStatementSyntax statementSyntax,
            TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, statementSyntax.ToFullString());
            }
        }

        public static void BreakStatementSyntax共通(BreakStatementSyntax statementSyntax,
            TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, statementSyntax.ToFullString());
            }
        }

        public static void LockStatementSyntax共通(LockStatementSyntax statementSyntax,
            TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, statementSyntax.ToFullString());
            }
        }

        public static void UsingStatementSyntax共通(UsingStatementSyntax statementSyntax,
            TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, statementSyntax.ToFullString());
            }
        }

        public static void EmptyStatementSyntax共通(EmptyStatementSyntax statementSyntax,
            TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, statementSyntax.ToFullString());
            }
        }

        public static void BlockSyntax共通(SemanticModel semanticModel, BlockSyntax blockSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                foreach (var statement2 in blockSyntax.Statements)
                {
                    StatementSyntax共通(semanticModel, statement2, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, blockSyntax.ToFullString());
            }
        }


        public static void InvocationExpressionSyntax共通(InvocationExpressionSyntax invocationExpressionSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                //var symbolInfo = semanticModel.GetSymbolInfo(member);
                //var typeInfo = semanticModel.GetTypeInfo(member);
                //var declaredSymbol = semanticModel.GetDeclaredSymbol(member);


                ExpressionSyntax共通(invocationExpressionSyntax.Expression, tcSolution, tcNamespace, tcSrcFile, tcMethod);

                if (invocationExpressionSyntax.ArgumentList != null)
                {
                    // 実行されるメソッドに渡されるパラメータを解析

                    foreach (var argumentSyntax in invocationExpressionSyntax.ArgumentList.Arguments)
                    {
                        ExpressionSyntax共通(argumentSyntax.Expression, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, invocationExpressionSyntax.ToFullString());
            }
        }

        public static void ExpressionSyntax共通(ExpressionSyntax expressionSyntax, TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                if (expressionSyntax is MemberAccessExpressionSyntax)
                {
                    var memberAccessExpressionSyntax = (MemberAccessExpressionSyntax)expressionSyntax;
                    実行メソッドandプロパティ抽出(memberAccessExpressionSyntax, tcSolution, tcNamespace, tcSrcFile, tcMethod);

                    //ExpressionSyntax共通(memberAccessExpressionSyntax.Expression, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (expressionSyntax is InvocationExpressionSyntax)
                {
                    var invocationExpressionSyntax = (InvocationExpressionSyntax)expressionSyntax;

                    InvocationExpressionSyntax共通(invocationExpressionSyntax, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (expressionSyntax is PostfixUnaryExpressionSyntax)
                {
                    // 今は不要
                    // var postfixUnaryExpressionSyntax = (PostfixUnaryExpressionSyntax)expressionStatementSyntax.Expression;
                }
                else if (expressionSyntax is PrefixUnaryExpressionSyntax)
                {
                    // 今は不要
                    // var postfixUnaryExpressionSyntax = (PostfixUnaryExpressionSyntax)expressionStatementSyntax.Expression;
                }
                else if (expressionSyntax is PredefinedTypeSyntax)
                {
                    // 今は不要
                    // var postfixUnaryExpressionSyntax = (PostfixUnaryExpressionSyntax)expressionStatementSyntax.Expression;
                }
                else if (expressionSyntax is ElementAccessExpressionSyntax)
                {
                    // 今は不要
                    // var postfixUnaryExpressionSyntax = (PostfixUnaryExpressionSyntax)expressionStatementSyntax.Expression;
                }
                else if (expressionSyntax is AssignmentExpressionSyntax)
                {
                    // 今は不要
                    // var postfixUnaryExpressionSyntax = (PostfixUnaryExpressionSyntax)expressionStatementSyntax.Expression;
                }
                else if (expressionSyntax is TypeOfExpressionSyntax)
                {
                    // 今は不要
                    // var postfixUnaryExpressionSyntax = (PostfixUnaryExpressionSyntax)expressionStatementSyntax.Expression;
                }
                else if (expressionSyntax is ThisExpressionSyntax)
                {
                    // 今は不要
                    // var postfixUnaryExpressionSyntax = (PostfixUnaryExpressionSyntax)expressionStatementSyntax.Expression;
                }
                else if (expressionSyntax is BinaryExpressionSyntax)
                {
                    var binaryExpressionSyntax = (BinaryExpressionSyntax)expressionSyntax;

                    実行メソッドandプロパティ抽出(binaryExpressionSyntax, tcSolution, tcNamespace, tcSrcFile, tcMethod);

                    //ExpressionSyntax共通(binaryExpressionSyntax.Left, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                    //ExpressionSyntax共通(binaryExpressionSyntax.Right, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
                else if (expressionSyntax is ArrayCreationExpressionSyntax)
                {
                    // 今は不要
                    // var postfixUnaryExpressionSyntax = (PostfixUnaryExpressionSyntax)expressionStatementSyntax.Expression;
                }
                else if (expressionSyntax is DefaultExpressionSyntax)
                {
                    // 今は不要
                    // var postfixUnaryExpressionSyntax = (PostfixUnaryExpressionSyntax)expressionStatementSyntax.Expression;
                }
                else if (expressionSyntax is DeclarationExpressionSyntax)
                {
                    // 今は不要
                    // var postfixUnaryExpressionSyntax = (PostfixUnaryExpressionSyntax)expressionStatementSyntax.Expression;
                }
                else if (expressionSyntax is BaseExpressionSyntax)
                {
                    // 今は不要
                    // var postfixUnaryExpressionSyntax = (PostfixUnaryExpressionSyntax)expressionStatementSyntax.Expression;
                }
                else if (expressionSyntax is ConditionalExpressionSyntax)
                {
                    // 今は不要
                    // var postfixUnaryExpressionSyntax = (PostfixUnaryExpressionSyntax)expressionStatementSyntax.Expression;
                }
                else if (expressionSyntax is CastExpressionSyntax)
                {
                    // 今は不要
                }
                else if (expressionSyntax is ParenthesizedExpressionSyntax)
                {
                    // 今は不要
                }
                else if (expressionSyntax is InitializerExpressionSyntax)
                {
                    // 今は不要
                }
                else if (expressionSyntax is QueryExpressionSyntax)
                {
                    // 今は不要
                }
                else if (expressionSyntax is AliasQualifiedNameSyntax)
                {
                    // 今は不要
                }
                else if (expressionSyntax is SimpleLambdaExpressionSyntax)
                {
                    // 今は不要
                }
                else if (expressionSyntax is ConditionalAccessExpressionSyntax)
                {
                    // 今は不要
                }
                else if (expressionSyntax is CheckedExpressionSyntax)
                {
                    // 今は不要
                }
                else if (expressionSyntax is ParenthesizedLambdaExpressionSyntax)
                {
                    // 今は不要
                }
                else if (expressionSyntax is AnonymousMethodExpressionSyntax)
                {
                    // 今は不要
                }
                else if (expressionSyntax is InterpolatedStringExpressionSyntax)
                {
                    // 今は不要
                }
                else if (expressionSyntax is ObjectCreationExpressionSyntax)
                {
                    var objectCreationExpressionSyntax = (ObjectCreationExpressionSyntax)expressionSyntax;

                    if (objectCreationExpressionSyntax.ArgumentList != null)
                    {
                        foreach (var argument in objectCreationExpressionSyntax.ArgumentList.Arguments)
                        {
                            ExpressionSyntax共通(argument.Expression, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                        }
                    }
                }
                else if (expressionSyntax is IdentifierNameSyntax)
                {
                    // 同じクラスに所属しているメソッドを追加
                    IdentifierNameSyntax共通(tcNamespace, tcSrcFile, null, (IdentifierNameSyntax)expressionSyntax, tcMethod);
                }
                else if (expressionSyntax is LiteralExpressionSyntax)
                {
                    var literalExpressionSyntax = (LiteralExpressionSyntax)expressionSyntax;
                    var tcLiteral = new TC_Literal()
                    {
                        SyntaxKind = expressionSyntax.Kind(),
                        Value = literalExpressionSyntax.Token.ValueText
                    };

                    tcMethod.LiteralList.Add(tcLiteral);
                }
                else
                {
                    // 適当に例外を発生させてログに残す
                    var syntax = (MemberAccessExpressionSyntax)expressionSyntax;
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, expressionSyntax.ToFullString());
            }
        }

        public static void 実行メソッドandプロパティ抽出(BinaryExpressionSyntax binaryExpressionSyntax,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                if ((binaryExpressionSyntax.Left is MemberAccessExpressionSyntax))
                {
                    実行メソッドandプロパティ抽出((MemberAccessExpressionSyntax)binaryExpressionSyntax.Left, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }

                if ((binaryExpressionSyntax.Right is MemberAccessExpressionSyntax))
                {
                    実行メソッドandプロパティ抽出((MemberAccessExpressionSyntax)binaryExpressionSyntax.Right, tcSolution, tcNamespace, tcSrcFile, tcMethod);
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, binaryExpressionSyntax.ToFullString());
            }
        }

        public static void 実行メソッドandプロパティ抽出(MemberAccessExpressionSyntax memberAccessExpression,
            TC_Solution tcSolution, TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        {
            try
            {
                if (memberAccessExpression.Expression is MemberAccessExpressionSyntax)
                {
                    //var className = ((IdentifierNameSyntax)((MemberAccessExpressionSyntax)memberAccessExpression.Expression).Expression).Identifier.ValueText;
                    var className = ((IdentifierNameSyntax)((MemberAccessExpressionSyntax)memberAccessExpression.Expression).Name).Identifier.ValueText;
                    var memberName = ((IdentifierNameSyntax)memberAccessExpression.Name).Identifier.ValueText;

                    実行メソッドandプロパティ登録(className, memberName, tcSolution, tcMethod);
                }
                else if (memberAccessExpression.Expression is IdentifierNameSyntax)
                {
                    if (memberAccessExpression.Name is IdentifierNameSyntax)
                    {
                        var className = ((IdentifierNameSyntax)memberAccessExpression.Expression).Identifier.ValueText;
                        var memberName = ((IdentifierNameSyntax)memberAccessExpression.Name).Identifier.ValueText;

                        /*ModelExtensions.GetSymbolInfo()*/
                        ;

                        実行メソッドandプロパティ登録(className, memberName, tcSolution, tcMethod);
                    }
                    else
                    {
                        // このパターンがResourcesに当たることは無いはず。
                        return;
                    }
                }
                else
                {
                    // このパターンがResourcesに当たることは無いはず。
                    return;
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, memberAccessExpression.ToFullString());
            }
        }

        public static void 実行メソッドandプロパティ登録(string className, string memberName,
            TC_Solution tcSolution, TC_Method tcMethod)
        {
            if (!Resources登録(className, memberName, tcSolution, tcMethod))
            {
                // Resourcesではなかったので、メソッドかプロパティと見なす。
                var tcCallMethod = new TC_CallMethod()
                {
                    ID = tcSolution.IdCounter.CallMethod++,
                    Methodが所属してるClassのName = className,
                    MethodName = memberName
                };

                if (!tcMethod.CallMethodList.Any(x => x.Methodが所属してるClassのName == tcCallMethod.Methodが所属してるClassのName &&
                    x.MethodName == tcCallMethod.MethodName))
                {
                    //未登録なら登録する
                    tcMethod.CallMethodList.Add(tcCallMethod);
                }

            }
        }

        public static bool Resources登録(string className, string memberName,
            TC_Solution tcSolution, TC_Method tcMethod)
        {
            foreach (var tcProject in tcSolution.ProjectList)
            {
                foreach (var tcResxFile in tcProject.ResxFileList.Where(x => x.Name == className))
                {
                    // リソースファイルに登録されている変数なら、リソースと見なす。
                    // ToDo:もっと良い方法ないの？
                    if (tcResxFile.ResourceDictionary.Any(x => x.Key == memberName))
                    {
                        if (tcMethod.ResourcesList.Any(x => x.KeyName == memberName))
                        {
                            //登録済み
                            return true;
                        }

                        var tcResources = new TC_Resources()
                        {
                            ClassName = className,
                            KeyName = memberName,
                        };

                        var value = tcResxFile.ResourceDictionary.First(x => x.Key == memberName);

                        tcResources.ResourcesLocationValue.Add(new TC_ResourcesLocationValue()
                        {
                            LocationName = tcResxFile.Name,
                            ResxFilePath = tcResxFile.FilePath,
                            Value = value.Value 
                        });

                        //未登録なら登録する
                        tcMethod.ResourcesList.Add(tcResources);

                        return true;
                    }
                }
            }

            return false;
        }


        //public static bool Resources抽出_本処理(MemberAccessExpressionSyntax memberAccessExpressionSyntax,
        //    TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, TC_Method tcMethod)
        //{
        //    var keyName1 = ((IdentifierNameSyntax)memberAccessExpressionSyntax.Expression).Identifier.ValueText;

        //    if (keyName1 == "Resources")
        //    {
        //        var keyName2 = ((IdentifierNameSyntax)memberAccessExpressionSyntax.Name).Identifier.ValueText;
        //        tcMethod.ResourcesList.Add(keyName2);

        //        // 解析終わり。
        //        return true;
        //    }

        //    return false;
        //}


        public static void IdentifierNameSyntax共通(TC_Namespace tcNamespace, TC_SrcFile tcSrcFile, IdentifierNameSyntax identifierExpression, IdentifierNameSyntax identifierName, TC_Method tcMethod)
        {
            try
            {
                //var tcCallMethod = new TC_CallMethod()
                //{
                //    Methodが所属してるClassのName = (identifierExpression == null ? "" : identifierExpression.Identifier.Value.ToString()),
                //    MethodName = identifierName.Identifier.Value.ToString()
                //};

                //tcCallMethod.NamespaceList.AddRange(tcSrcFile.UsingNamespaceList);
                //tcCallMethod.NamespaceList.Add(tcNamespace.Name);

                //tcMethod.CallMethodList.Add(tcCallMethod);
            }
            catch (Exception ex)
            {
                LoggerSt.Info("Not impremented.", ex, identifierName.ToFullString());
            }
        }

    }
}
