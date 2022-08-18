using Microsoft.Build.Evaluation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.CSharp;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;

namespace UnikktleGemConsole
{

    public static class FViewAnalyzeSt
    {
        //private const string _ClmName_Solution = "Solution";
        public const string _ClmName_Project = "Project";
        public const string _ClmName_SrcFile = "SrcFile";
        public const string _ClmName_Namespace = "Namespace";
        public const string _ClmName_Layer_Type = "Layer{0} Type";
        public const string _ClmName_Layer_Name = "Layer{0} Name";
        public const string _ClmName_Layer_ParameterType = "Layer_ParameterType";
        public const string _ClmName_Layer_ParameterName = "Layer_ParameterName";

        public const int _ClmNo_Project = 0;
        public const int _ClmNo_SrcFile = 1;
        public const int _ClmNo_Namespace = 2;
        public const int _ClmNo_ClassStart = 3;


        public static View件数 全件数更新(TC_Solution tcSolution)
        {
            LoggerSt.Info("Start 全件数更新.");

            var view件数 = new View件数();

            view件数.Project = tcSolution.ProjectList.Count();

            foreach (var project in tcSolution.ProjectList)
            {
                view件数.SrcFile += project.SrcFileList.Count();
                view件数.ResxFile += project.ResxFileList.Count();

                foreach (var resxFile in project.ResxFileList)
                {
                    view件数.Resources += resxFile.ResourceDictionary.Count();
                }

                foreach (var srcFile in project.SrcFileList)
                {
                    view件数.Namespace += srcFile.NamespaceList.Count();

                    foreach (var _namespace in srcFile.NamespaceList)
                    {
                        view件数.Class += _namespace.ClassList.Count();
                        view件数.Interface += _namespace.InterfaceList.Count();
                        view件数.Struct += _namespace.StructList.Count();
                        view件数.Enum += _namespace.EnumList.Count();
                        view件数.Delegate += _namespace.DelegateList.Count();
                        view件数.Namespace += _namespace.NamespaceList.Count();

                        foreach (var _class in _namespace.ClassList)
                        {
                            view件数.Class += _class.ClassList.Count();
                            view件数.Interface += _class.InterfaceList.Count();
                            view件数.Struct += _class.StructList.Count();
                            view件数.Enum += _class.EnumList.Count();
                            view件数.Delegate += _class.DelegateList.Count();
                            view件数.Method += _class.MethodList.Count();
                            view件数.Property += _class.PropertyList.Count();
                            view件数.Constructor += _class.ConstructorList.Count();
                            view件数.Field += _class.FieldList.Count();
                            view件数.Indexer += _class.IndexerList.Count();
                            view件数.Event += _class.EventList.Count();

                            foreach (var _method in _class.MethodList)
                            {
                                view件数.MethodParameter += _method.MethodParameterList.Count();
                                view件数.CallMethod += _method.CallMethodList.Count();
                                view件数.ThrowAugment += _method.ThrowAugmentList.Count();
                                view件数.Literal += _method.LiteralList.Count();
                                view件数.UseResources += _method.ResourcesList.Count();
                            }
                        }
                    }
                }

            }

            LoggerSt.Info("End 全件数更新.");


            //view件数.Namespace.全件数 = ;
            //view件数.Class.全件数 = ;
            //view件数.Struct.全件数 = ;
            //view件数.Enum.全件数 = ;
            //view件数.Delegate.全件数 = ;
            //view件数.Interface.全件数 = ;
            //view件数.Method.全件数 = ;
            //view件数.Constructor.全件数 = ;
            //view件数.Field.全件数 = ;
            //view件数.Indexer.全件数 = ;
            //view件数.Event.全件数 = ;

            return view件数;
        }

        public static void DataGridView初期化(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            //dgv結果.Columns.Add(new DataGridViewColumn() { Name = _ClmName_Solution, HeaderText = _ClmName_Solution, CellTemplate = new DataGridViewTextBoxCell() });
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                //Name = _ClmName_Project,
                //HeaderText = _ClmName_Project,
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                //Name = _ClmName_SrcFile,
                //HeaderText = _ClmName_SrcFile,
            });

            var clmIndex = _ClmNo_SrcFile + 1;
            for (var layerCount = 1; layerCount < 100; layerCount++)
            {
                clmIndex++;
                dgv.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    //Name = string.Format(_ClmName_Layer_Type, layerCount),
                    //HeaderText = string.Format(_ClmName_Layer_Type, layerCount),
                    SortMode = DataGridViewColumnSortMode.NotSortable
                });

                clmIndex++;
                dgv.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    //Name = string.Format(_ClmName_Layer_Name, layerCount),
                    //HeaderText = string.Format(_ClmName_Layer_Name, layerCount),
                    SortMode = DataGridViewColumnSortMode.NotSortable
                });
            }

            dgv.Rows.Add();
        }

        /// <summary>
        /// DataGridVeiwへ展開する前に
        /// 検索条件を重ね合わせで加工する
        /// </summary>
        public static void 検索条件に合わせて解析結果を加工(EC_Project ecProject, TC_Solution tcSolution)
        {
            LoggerSt.Info("Start 検索条件に合わせて解析結果を加工.");

            if (!ecProject.SrcFile)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    tcProject.SrcFileList.Clear();
                }
            }

            if (!ecProject.ResourceFile)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    tcProject.ResxFileList.Clear();
                }
            }

            // ToDo:以降の処理は、ecProject.SrcFile などのチェック状態に依存した作りにした方がパフォーマンスが良くなる。

            if (!ecProject.EC_SrcFile.Namespace)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    foreach (var tcSrcFile in tcProject.SrcFileList)
                    {
                        tcSrcFile.NamespaceList.Clear();
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.Interface)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    foreach (var tcSrcFile in tcProject.SrcFileList)
                    {
                        foreach (var tcNamespace in tcSrcFile.NamespaceList)
                        {
                            tcNamespace.InterfaceList.Clear();
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.Struct)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    foreach (var tcSrcFile in tcProject.SrcFileList)
                    {
                        foreach (var tcNamespace in tcSrcFile.NamespaceList)
                        {
                            tcNamespace.StructList.Clear();
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.Enum)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    foreach (var tcSrcFile in tcProject.SrcFileList)
                    {
                        foreach (var tcNamespace in tcSrcFile.NamespaceList)
                        {
                            tcNamespace.EnumList.Clear();
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.Delegate)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    foreach (var tcSrcFile in tcProject.SrcFileList)
                    {
                        foreach (var tcNamespace in tcSrcFile.NamespaceList)
                        {
                            tcNamespace.DelegateList.Clear();
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.Namespace)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    foreach (var tcSrcFile in tcProject.SrcFileList)
                    {
                        foreach (var tcNamespace in tcSrcFile.NamespaceList)
                        {
                            tcNamespace.NamespaceList.Clear();
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.Class)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    foreach (var tcSrcFile in tcProject.SrcFileList)
                    {
                        foreach (var tcNamespace in tcSrcFile.NamespaceList)
                        {
                            tcNamespace.ClassList.Clear();
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.EC_Class.継承無し)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    foreach (var tcSrcFile in tcProject.SrcFileList)
                    {
                        foreach (var tcNamespace in tcSrcFile.NamespaceList)
                        {
                            tcNamespace.ClassList.RemoveAll(x => x.BaseNameList.Count() < 1);
                        }
                    }
                }
            }

            if (ecProject.EC_SrcFile.EC_Namespace.EC_Class.FormOnly)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    foreach (var tcSrcFile in tcProject.SrcFileList)
                    {
                        foreach (var tcNamespace in tcSrcFile.NamespaceList)
                        {
                            tcNamespace.ClassList.RemoveAll(x => !x.BaseNameList.Any(x2 => x2 == "Form"));
                        }
                    }
                }
            }


            if (!ecProject.EC_SrcFile.EC_Namespace.EC_Class.Method)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    foreach (var tcSrcFile in tcProject.SrcFileList)
                    {
                        foreach (var tcNamespace in tcSrcFile.NamespaceList)
                        {
                            foreach (var tcClass in tcNamespace.ClassList)
                            {
                                tcClass.MethodList.Clear();
                            }
                        }
                    }
                }
            }

            if (ecProject.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.イベントハンドラのみ)
            {
                foreach (var tcProject in tcSolution.ProjectList)
                {
                    foreach (var tcSrcFile in tcProject.SrcFileList)
                    {
                        foreach (var tcNamespace in tcSrcFile.NamespaceList)
                        {
                            foreach (var tcClass in tcNamespace.ClassList)
                            {
                                //var イベントハンドラ以外 = tcClass.MethodList.Where(x => !x.MethodParameterList.Any(x2 => x2.Name.IndexOf("EventArgs") < 0));
                                tcClass.MethodList.RemoveAll(x => !x.MethodParameterList.Any(x2 => x2.Name.IndexOf("EventArgs") < 0));
                            }
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.CallMethod)
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
                                    tcMethod.CallMethodList.Clear();
                                }
                            }
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Throw)
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
                                    tcMethod.ThrowAugmentList.Clear();
                                }
                            }
                        }
                    }
                }
            }


            if (!ecProject.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Literal)
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
                                    tcMethod.LiteralList.Clear();
                                }
                            }
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.EC_Literal.String)
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
                                    tcMethod.LiteralList.RemoveAll(x =>
                                        x.SyntaxKind == SyntaxKind.CharacterLiteralExpression ||
                                        x.SyntaxKind == SyntaxKind.StringLiteralExpression);
                                }
                            }
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.EC_Literal.Numeric)
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
                                    tcMethod.LiteralList.RemoveAll(x =>
                                        x.SyntaxKind == SyntaxKind.NumericLiteralExpression);
                                }
                            }
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.EC_Literal.Boolean)
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
                                    tcMethod.LiteralList.RemoveAll(x =>
                                        x.SyntaxKind == SyntaxKind.FalseLiteralExpression ||
                                        x.SyntaxKind == SyntaxKind.TrueLiteralExpression);
                                }
                            }
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.EC_Literal.Other)
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
                                    tcMethod.LiteralList.RemoveAll(x =>
                                        x.SyntaxKind != SyntaxKind.CharacterLiteralExpression &&
                                        x.SyntaxKind != SyntaxKind.StringLiteralExpression &&
                                        x.SyntaxKind != SyntaxKind.NumericLiteralExpression &&
                                        x.SyntaxKind != SyntaxKind.FalseLiteralExpression &&
                                        x.SyntaxKind != SyntaxKind.TrueLiteralExpression);
                                }
                            }
                        }
                    }
                }
            }

            if (!ecProject.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Resources)
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
                                    tcMethod.ResourcesList.Clear();
                                }
                            }
                        }
                    }
                }
            }

            if (ecProject.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Resourcesを呼び出し元のメソッドに纏める)
            {
                Resources加工_Solution単位(tcSolution);
            }

            //全てが0件のアイテムを削除(tcSolution);

            LoggerSt.Info("End 検索条件に合わせて解析結果を加工.");
        }

        //public static void 全てが0件のアイテムを削除(TC_Solution tcSolution)
        //{
        //    int removeCnt;

        //    do
        //    {
        //        removeCnt = 0;

        //        removeCnt += tcSolution.ProjectList.RemoveAll(x => x.SrcFileList.Count() < 1 && 
        //            x.ResxFileList.Count() < 1);

        //        foreach (var tcProject in tcSolution.ProjectList)
        //        {
        //            // Using[x.UsingNamespaceList.Count() < 1]は残っていても削除してしまう
        //            removeCnt += tcProject.SrcFileList.RemoveAll(x => x.NamespaceList.Count() < 1);
                    
        //            removeCnt += tcProject.ResxFileList.RemoveAll(x => x.ResourceDictionary.Count() < 1);

        //            foreach (var tcSrcFile in tcProject.SrcFileList)
        //            {
        //                removeCnt += tcSrcFile.NamespaceList.RemoveAll(x => x.ClassList.Count() < 1 && 
        //                    x.InterfaceList.Count() < 1 &&
        //                    x.StructList.Count() < 1 &&
        //                    x.EnumList.Count() < 1 &&
        //                    x.DelegateList.Count() < 1 &&
        //                    x.NamespaceList.Count() < 1);

        //                foreach (var tcNamespace in tcSrcFile.NamespaceList)
        //                {
        //                    removeCnt += tcNamespace.ClassList.RemoveAll(x => x.BaseNameList.Count() < 1 &&
        //                        x.ClassList.Count() < 1 &&
        //                        x.InterfaceList.Count() < 1 &&
        //                        x.MethodList.Count() < 1 &&
        //                        x.PropertyList.Count() < 1 &&
        //                        x.ConstructorList.Count() < 1 &&
        //                        x.FieldList.Count() < 1 &&
        //                        x.IndexerList.Count() < 1 &&
        //                        x.EventList.Count() < 1 &&
        //                        x.DelegateList.Count() < 1 &&
        //                        x.StructList.Count() < 1 &&
        //                        x.DelegateList.Count() < 1 &&
        //                        x.DelegateList.Count() < 1 &&
        //                        x.EnumList.Count() < 1);
        //                }
        //            }
        //        }
        //    }
        //    while (removeCnt > 0);  // 完全に削除し終えるまで繰り返す。
        //}

        public static void Resources加工_Solution単位(TC_Solution tcSolution)
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
                                // tcMethod が呼び出しているメソッドを全探索し、リソースとリテラルを追加して行く
                                Resources加工_CallMethod単位(tcSolution, tcMethod);

                                //foreach (var tcCallMethod in tcMethod.CallMethodList)
                                //{
                                //    var result = Resources加工_CallMethod単位(tcSolution, tcNamespace, tcClass, tcCallMethod);

                                //    if (result.ResourcesList != null)
                                //    {
                                //        tcMethod.ResourcesList.AddRange(result.ResourcesList);
                                //    }

                                //    if (result.LiteralList != null)
                                //    {
                                //        tcMethod.LiteralList.AddRange(result.LiteralList);
                                //    }
                                //}
                            }
                        }
                    }
                }
            }
        }

        public static void Resources加工_CallMethod単位(TC_Solution tcSolution, TC_Method tcMethod元)
        {
            foreach (var tcProject in tcSolution.ProjectList)
            {
                foreach (var tcSrcFile in tcProject.SrcFileList)
                {
                    foreach (var tcNamespace in tcSrcFile.NamespaceList)
                    {
                        foreach (var tcClass in tcNamespace.ClassList)
                        {
                            foreach (var tcMethod先 in tcClass.MethodList)
                            {
                                var パラメータ一致 = true;
                                foreach (var tcMethodSymbol先 in tcMethod先.DeclaredSymbolList_CallMethod)
                                {
                                    if (tcMethodSymbol先.FilePath != tcMethod元.DeclaredSymbol.FilePath ||
                                        tcMethodSymbol先.OriginalDefinition != tcMethod元.DeclaredSymbol.OriginalDefinition ||
                                        tcMethodSymbol先._TC_Symbol.Name != tcMethod元.DeclaredSymbol._TC_Symbol.Name)
                                    {
                                        // ソースファイル、名前空間、クラス名、メソッド名が一致しない
                                        パラメータ一致 = false;
                                        break;
                                    }

                                    var max = tcMethod元.MethodParameterList.Count();
                                    if (max != tcMethodSymbol先._TC_ParameterSymbolList.Count())
                                    {
                                        // パラメータ数が一致しない
                                        パラメータ一致 = false;
                                        break;
                                    }

                                    for (int cnt = 0 ; cnt < max; cnt++)
                                    {
                                        if (tcMethod元.DeclaredSymbol._TC_ParameterSymbolList[cnt]._TC_Symbol.Name != tcMethodSymbol先._TC_ParameterSymbolList[cnt]._TC_Symbol.Name ||
                                            tcMethod元.DeclaredSymbol._TC_ParameterSymbolList[cnt].Type != tcMethodSymbol先._TC_ParameterSymbolList[cnt].Type)
                                        {
                                            // パラメータ数が一致しない
                                            パラメータ一致 = false;
                                            break;
                                        }
                                    }

                                    if (!パラメータ一致)
                                    {
                                        break;
                                    }
                                }

                                if (!パラメータ一致)
                                {
                                    continue;
                                }

                                // メソッドの情報が一致したので、呼び出し元メソッドに、呼び出し先メソッドの値を追加する
                                if (tcMethod先.ResourcesList != null)
                                {
                                    var ResourcesList先_Copy = tcMethod先.ResourcesList.DeepCopy();
                                    foreach (var resources元 in tcMethod元.ResourcesList)
                                    {
                                        ResourcesList先_Copy.RemoveAll(x => x == resources元);
                                    }

                                    tcMethod元.ResourcesList.AddRange(ResourcesList先_Copy);
                                }

                                if (tcMethod先.LiteralList != null)
                                {
                                    var LiteralList先_Copy = tcMethod先.LiteralList.DeepCopy();
                                    foreach (var Literal元 in tcMethod元.LiteralList)
                                    {
                                        LiteralList先_Copy.RemoveAll(x => x == Literal元);
                                    }

                                    tcMethod元.LiteralList.AddRange(LiteralList先_Copy);
                                }
                            }
                        }
                    }
                }
            }
        }


        //public static (List<string> ResourcesList, List<TC_Literal> LiteralList) Resources加工_CallMethod単位(
        //    TC_Solution tcSolution, TC_Namespace tcNamespace元, TC_Class tcClass元, TC_CallMethod tcCallMethod)
        //{
        //    if (string.IsNullOrEmpty(tcCallMethod.Methodが所属してるClassのName))
        //    {
        //        // 呼ばれたメソッドが、同じClass内にあるメソッドの場合。

        //        return Resources加工_CallMethod単位_同じクラス(tcSolution, tcNamespace元, tcClass元, tcCallMethod);
        //    }
        //    else
        //    {
        //        // 別のClass内にあるメソッドの場合。

        //        foreach (var tcProject in tcSolution.ProjectList)
        //        {
        //            foreach (var tcSrcFile in tcProject.SrcFileList)
        //            {
        //                foreach (var tcNamespace in tcSrcFile.NamespaceList)
        //                {
        //                    if (tcNamespace.Name != tcNamespace元.Name)
        //                    {
        //                        continue;
        //                    }
                            
        //                    foreach (var tcClass in tcNamespace.ClassList)
        //                    {
        //                        if (tcClass.Name == tcCallMethod.Methodが所属してるClassのName)
        //                        {
        //                            return Resources加工_CallMethod単位_同じクラス(tcSolution, tcNamespace元, tcClass, tcCallMethod);
        //                        }
        //                        else
        //                        {
        //                            foreach (var tcMethod in tcClass.MethodList)
        //                            {
        //                                if (tcMethod.Name != tcCallMethod.MethodName)
        //                                {
        //                                    continue;
        //                                }

        //                                // ToDo:パラメータの比較も必要。オーバーロード対応。

        //                                return (tcMethod.ResourcesList, tcMethod.LiteralList);
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        return (null, null);
        //    }
        //}

        //public static (List<string> ResourcesList, List<TC_Literal> LiteralList) Resources加工_CallMethod単位_同じクラス(TC_Solution tcSolution, TC_Namespace tcNamespace元, TC_Class tcClass元, TC_CallMethod tcCallMethod)
        //{
        //    foreach (var tcMethod in tcClass元.MethodList)
        //    {
        //        if (tcMethod.Name == tcCallMethod.MethodName)
        //        {
        //            for(var cnt = 0; cnt < tcMethod.MethodParameterList.Count; cnt++)
        //            {
        //                //if (tcMethod.MethodParameterList[cnt] == )
        //            }
                    

        //            // ToDo:パラメータの比較も必要。オーバーロード対応。
        //            return (tcMethod.ResourcesList, tcMethod.LiteralList);
        //        }
        //    }

        //    return (null, null);
        //}


        public static void リソース一覧(TC_Solution tcSolution, DataGridView dgv)
        {
            var rowIndex = 0;
            foreach (var tcProject in tcSolution.ProjectList)
            {
                dgv.Rows[rowIndex].Cells[0].Value = tcProject.Name;

                foreach (var tcResxFile in tcProject.ResxFileList)
                {
                    dgv.Rows[rowIndex].Cells[1].Value = tcResxFile.Name;
                    dgv.Rows[rowIndex].Cells[2].Value = tcResxFile.FilePath;

                    foreach (var resource in tcResxFile.ResourceDictionary)
                    {
                        dgv.Rows[rowIndex].Cells[3].Value = resource.Key;
                        dgv.Rows[rowIndex].Cells[4].Value = resource.Value;

                        rowIndex = dgv.Rows.Add();
                    }

                    //if (!Chk空行_SrcFileまで(dgv, rowIndex, 3))
                    //{
                    //    rowIndex = dgv.Rows.Add();
                    //}
                }
            }
        }

        public static void DGV表示(EC_Project ecProject, TC_Solution tcSolution, DataGridView dgv)
        {
            LoggerSt.Info("Start 更新.");

            var rowIndex = 0;
            foreach (var tcProject in tcSolution.ProjectList)
            {
                Project単位(ecProject, tcProject, dgv, ref rowIndex);
            }

            LoggerSt.Info("End 更新.");

            //dgv.Rows.RemoveAt(rowIndex);

        }

        public static void Project単位(EC_Project ecProject, TC_Project tcProject, DataGridView dgv, ref int rowIndex)
        {
            var clmIndex = DgvClm抽出結果.Project開始列;
            DataGridView_SetCellValue(SrcMemberTypeName.Project, tcProject.FilePath, tcProject.Name, dgv, ref rowIndex, ref clmIndex);

            foreach (var tcSrcFile in tcProject.SrcFileList)
            {
                SrcFile単位(ecProject, tcSrcFile, dgv, ref rowIndex);
            }

            foreach (var tcResxFile in tcProject.ResxFileList)
            {
                ResxFile単位(ecProject, tcResxFile, dgv, ref rowIndex);
            }

            //if (!Chk空行_SrcFileまで(dgv, rowIndex, _ClmNo_Project))
            //{
            //    rowIndex = dgv.Rows.Add();
            //}
        }

        public static void SrcFile単位(EC_Project ecProject, TC_SrcFile tcSrcFile, DataGridView dgv, ref int rowIndex)
        {
            var clmIndex = DgvClm抽出結果.SrcFile開始列;
            DataGridView_SetCellValue(SrcMemberTypeName.SourceFile, tcSrcFile.FilePath, tcSrcFile.Name, dgv, ref rowIndex, ref clmIndex);

            foreach (var tcNamespace in tcSrcFile.NamespaceList)
            {
                clmIndex = DgvClm抽出結果.Namespace開始列;
                Namespace単位(ecProject, tcNamespace, dgv, ref rowIndex, ref clmIndex);
            }

            //if (!Chk空行_SrcFileまで(dgv, rowIndex, _ClmNo_SrcFile))
            //{
            //    rowIndex = dgv.Rows.Add();
            //}
        }

        public static void ResxFile単位(EC_Project ecProject, TC_ResxFile tcResxFile, DataGridView dgv, ref int rowIndex)
        {
            var clmIndex = DgvClm抽出結果.リソースファイル開始列;
            DataGridView_SetCellValue(SrcMemberTypeName.ResourceFile, tcResxFile.FilePath, tcResxFile.Name, dgv, ref rowIndex, ref clmIndex);

            // ToDo:作りが悪い
            dgv.Rows[rowIndex - 1].Cells[clmIndex].Value = tcResxFile.FilePath;

            foreach (var keyValue in tcResxFile.ResourceDictionary)
            {
                ResxKeyValue単位(keyValue.Key, keyValue.Value, dgv, ref rowIndex);
            }
        }

        public static void ResxKeyValue単位(string key, string value, DataGridView dgv, ref int rowIndex)
        {
            var clmIndex = DgvClm抽出結果.ResxKeyValue開始列;
            DataGridView_SetCellValue(SrcMemberTypeName.ResourceKeyValue, "", key, dgv, ref rowIndex, ref clmIndex);

            // ToDo:作りが悪い
            dgv.Rows[rowIndex - 1].Cells[clmIndex].Value = value;
        }

        public static void Namespace単位(EC_Project ecProject, TC_Namespace tcNamespace, DataGridView dgv, ref int rowIndex, ref int clmIndex)
        {
            DataGridView_SetCellValue(SrcMemberTypeName.Namespace, "", tcNamespace.Name, dgv, ref rowIndex, ref clmIndex);

            foreach (var tc in tcNamespace.EnumList)
            {
                Enum単位(tc, dgv, ref rowIndex, clmIndex);
            }

            foreach (var tc in tcNamespace.StructList)
            {
                Struct単位(tc, dgv, ref rowIndex, clmIndex);
            }

            foreach (var tcInterface in tcNamespace.InterfaceList)
            {
                Interface単位(tcInterface, dgv, ref rowIndex, clmIndex);
            }

            foreach (var tc in tcNamespace.DelegateList)
            {
                Delegate単位(tc, dgv, ref rowIndex, clmIndex);
            }

            var startclmIndex = clmIndex;
            foreach (var tcClass in tcNamespace.ClassList)
            {
                clmIndex = startclmIndex;
                Class単位(ecProject, tcClass, dgv, ref rowIndex, ref clmIndex);
            }

            foreach (var tc in tcNamespace.NamespaceList)
            {
                clmIndex = startclmIndex;
                Namespace単位(ecProject, tc, dgv, ref rowIndex, ref clmIndex);
            }

            //DataGridView_Row追加(dgv, ref rowIndex, clmIndex);
        }

        public static void Enum単位(TC_Enum tcEnum, DataGridView dgv, ref int rowIndex, int clmIndex)
        {
            DataGridView_SetCellValue(SrcMemberTypeName.Enum, "", tcEnum.Name, dgv, ref rowIndex, clmIndex);

            //DataGridView_Row追加(dgv, ref rowIndex, clmIndex);
        }

        public static void Struct単位(TC_Struct tcStruct, DataGridView dgv, ref int rowIndex, int clmIndex)
        {
            DataGridView_SetCellValue(SrcMemberTypeName.Struct, "", tcStruct.Name, dgv, ref rowIndex, clmIndex);

            //DataGridView_Row追加(dgv, ref rowIndex, clmIndex);
        }

        public static void Interface単位(TC_Interface tcInterface, DataGridView dgv, ref int rowIndex, int clmIndex)
        {
            DataGridView_SetCellValue(SrcMemberTypeName.Interface, "", tcInterface.Name, dgv, ref rowIndex, clmIndex);

            //DataGridView_Row追加(dgv, ref rowIndex, clmIndex);
        }

        public static void Delegate単位(TC_Delegate tcDelegate, DataGridView dgv, ref int rowIndex, int clmIndex)
        {
            DataGridView_SetCellValue(SrcMemberTypeName.Delegate, "", tcDelegate.Name, dgv, ref rowIndex, clmIndex);

            //DataGridView_Row追加(dgv, ref rowIndex, clmIndex);
        }

        public static void Class単位(EC_Project ecProject, TC_Class tcClass, DataGridView dgv, ref int rowIndex, ref int clmIndex)
        {
            // これようの文字列を作る => CSharpSyntaxNode : SyntaxNode, IFormattable
            var 継承 = "";
            foreach (var baseName in tcClass.BaseNameList)
            {
                継承 += baseName + ", ";
            }

            if (!string.IsNullOrEmpty(継承))
            {
                継承 = " : " + 継承;
            }

            DataGridView_SetCellValue(SrcMemberTypeName.Class, "", tcClass.Name + 継承, dgv, ref rowIndex, ref clmIndex);

            var startclmIndex = clmIndex;
            foreach (var tcClass_Inner in tcClass.ClassList)
            {
                clmIndex = startclmIndex;
                Class単位(ecProject, tcClass_Inner, dgv, ref rowIndex, ref clmIndex);
            }

            foreach (var tcMethod in tcClass.MethodList)
            {
                clmIndex = startclmIndex;
                Method単位(tcMethod, dgv, ref rowIndex, ref clmIndex);
            }

            foreach (var tcInterface in tcClass.InterfaceList)
            {
                Interface単位(tcInterface, dgv, ref rowIndex, clmIndex);
            }

            //DataGridView_Row追加(dgv, ref rowIndex, clmIndex);
        }

        public static void Method単位(TC_Method tcMethod, DataGridView dgv, ref int rowIndex, ref int clmIndex)
        {
            DataGridView_SetCellValue(SrcMemberTypeName.Method, "", tcMethod.Name, dgv, ref rowIndex, ref clmIndex);

            foreach (var tcMethodParameter in tcMethod.MethodParameterList)
            {
                MethodParameter単位(tcMethodParameter, dgv, ref rowIndex, clmIndex);
            }

            foreach (var tcCallMethod in tcMethod.CallMethodList)
            {
                CallMethod単位(tcCallMethod, dgv, ref rowIndex, clmIndex);
            }

            foreach (var throwAugment in tcMethod.ThrowAugmentList)
            {
                ThrowAugment単位(throwAugment, dgv, ref rowIndex, clmIndex);
            }

            foreach (var literal in tcMethod.LiteralList)
            {
                Literal単位(literal, dgv, ref rowIndex, clmIndex);
            }

            foreach (var resources in tcMethod.ResourcesList)
            {
                Resources単位(resources, dgv, ref rowIndex, clmIndex);
            }


            //foreach (var tcMethodParameter in tcMethod.MethodParameterList)
            //{

            //    //Obtain a reference to the newly created DataGridViewRow 

            //    ////Now this won't fail since the row and columns exist 
            //    //row.Cells["code"].Value = product.Id;
            //    //row.Cells["description"].Value =    .Description;

            //    dgv.Rows[rowIndex].Cells[_ClmName_MethodParameter].Value = tcMethodParameter.ParameterName;

            //    //dgv結果.Rows.Add(dataGridViewRow);

            //    if (!Chk空行(dgv, rowIndex))
            //    {
            //        rowIndex = dgv.Rows.Add();
            //    }
            //}

            //DataGridView_Row追加(dgv, ref rowIndex, clmIndex);
        }

        public static void MethodParameter単位(TC_MethodParameter tcMethodParameter, DataGridView dgv, ref int rowIndex, int clmIndex)
        {
            DataGridView_SetCellValue(SrcMemberTypeName.MethodParameter, "", tcMethodParameter.ParameterType + " " + tcMethodParameter.Name, dgv, ref rowIndex, clmIndex);

            //DataGridView_Row追加(dgv, ref rowIndex, clmIndex);
        }

        public static void CallMethod単位(TC_CallMethod tcCallMethod, DataGridView dgv, ref int rowIndex, int clmIndex)
        {
            var callMethodName = "";
            if (string.IsNullOrEmpty(tcCallMethod.Methodが所属してるClassのName))
            {
                callMethodName = tcCallMethod.MethodName;
            }
            else
            {
                callMethodName = tcCallMethod.Methodが所属してるClassのName + "." + tcCallMethod.MethodName;
            }

            DataGridView_SetCellValue(SrcMemberTypeName.CallMethod, "", callMethodName, dgv, ref rowIndex, clmIndex);

            //DataGridView_Row追加(dgv, ref rowIndex, clmIndex);
        }

        public static void ThrowAugment単位(string throwAugment, DataGridView dgv, ref int rowIndex, int clmIndex)
        {
            DataGridView_SetCellValue(SrcMemberTypeName.Throw, "", throwAugment, dgv, ref rowIndex, clmIndex);

            //DataGridView_Row追加(dgv, ref rowIndex, clmIndex);
        }

        public static void Literal単位(TC_Literal tcLiteral, DataGridView dgv, ref int rowIndex, int clmIndex)
        {
            var type = SrcMemberTypeName.Literal;

            switch (tcLiteral.SyntaxKind)
            {
                case SyntaxKind.CharacterLiteralExpression:
                case SyntaxKind.StringLiteralExpression:
                    type += "(String)";
                    break;

                case SyntaxKind.NumericLiteralExpression:
                    type += "(Numeric)";
                    break;

                case SyntaxKind.FalseLiteralExpression:
                case SyntaxKind.TrueLiteralExpression:
                    type += "(Boolean)";
                    break;
            
                case SyntaxKind.NullLiteralExpression:
                case SyntaxKind.DefaultLiteralExpression:
                default:
                    type += "(Other)";
                    break;
            }

            DataGridView_SetCellValue(type, "", tcLiteral.Value, dgv, ref rowIndex, clmIndex);

            //DataGridView_Row追加(dgv, ref rowIndex, clmIndex);
        }

        public static void Resources単位(TC_Resources resources, DataGridView dgv, ref int rowIndex, int clmIndex)
        {
            DataGridView_SetCellValue(SrcMemberTypeName.Resources, "", resources.ClassName + "." + resources.KeyName, dgv, ref rowIndex, clmIndex);

            //DataGridView_Row追加(dgv, ref rowIndex, clmIndex);
        }

        //public static void DataGridView_Layer追加(DataGridView dgv, int rowIndex, ref int clmIndex)
        //{
        //    if (Chk空行_namespace以降(dgv, rowIndex, clmIndex))
        //    {
        //        // 追加不要
        //        return;
        //    }
        //    //clmIndex++;
        //    //dgv.Columns.Add(new DataGridViewColumn()
        //    //{
        //    //    Name = _ClmName_Layer_Type + (clmIndex - _ClmNo_Namespace),
        //    //    HeaderText = _ClmName_Layer_Type + (clmIndex - _ClmNo_Namespace),
        //    //    CellTemplate = new DataGridViewTextBoxCell()
        //    //});

        //    //clmIndex++;
        //    //dgv.Columns.Add(new DataGridViewColumn()
        //    //{
        //    //    Name = _ClmName_Layer_Name + (clmIndex - 1 - _ClmNo_Namespace),
        //    //    HeaderText = _ClmName_Layer_Name + (clmIndex - 1 - _ClmNo_Namespace),
        //    //    CellTemplate = new DataGridViewTextBoxCell()
        //    //});
        //}

        //public static void DataGridView_Row追加(DataGridView dgv, ref int rowIndex, int clmIndex)
        //{
        //    if (!Chk空行_namespace以降(dgv, rowIndex, clmIndex))
        //    {
        //        rowIndex = dgv.Rows.Add();
        //    }
        //}


        //public static bool Chk空行_SrcFileまで(DataGridView dgv, int rowIndex, int clmIndex)
        //{
        //    if (string.IsNullOrEmpty((string)dgv.Rows[rowIndex].Cells[_ClmNo_Project].Value) &&
        //        string.IsNullOrEmpty((string)dgv.Rows[rowIndex].Cells[_ClmNo_SrcFile].Value))
        //    {
        //        // 空行
        //        return true;
        //    }
        //    else
        //    {
        //        // 空行じゃない
        //        return false;
        //    }
        //}

        //public static bool Chk空行_namespace以降(DataGridView dgv, int rowIndex, int clmIndex)
        //{
        //    for (var cnt = clmIndex; cnt > -1 ; cnt--)
        //    {
        //        if (!string.IsNullOrEmpty((string)dgv.Rows[rowIndex].Cells[cnt].Value))
        //        {
        //            // 空行じゃない
        //            return false;
        //        }
        //    }

        //    // 空行
        //    return true;
        //}

        /// <summary>
        /// 列のインクリメント有り
        /// </summary>
        public static void DataGridView_SetCellValue(string typeName, string filePath, string value, DataGridView dgv, ref int rowIndex, ref int clmIndex)
        {
            dgv.Rows[rowIndex].Cells[DgvClm抽出結果.オブジェクトタイプ名列].Value = typeName;
            dgv.Rows[rowIndex].Cells[DgvClm抽出結果.ファイルパス列].Value = filePath;
            dgv.Rows[rowIndex].Cells[clmIndex].Value = value;
            rowIndex = dgv.Rows.Add();
            clmIndex++;
        }

        /// <summary>
        /// 列のインクリメント無し
        /// </summary>
        public static void DataGridView_SetCellValue(string typeName, string filePath, string value, DataGridView dgv, ref int rowIndex, int clmIndex)
        {
            dgv.Rows[rowIndex].Cells[DgvClm抽出結果.オブジェクトタイプ名列].Value = typeName;
            dgv.Rows[rowIndex].Cells[DgvClm抽出結果.ファイルパス列].Value = filePath;
            dgv.Rows[rowIndex].Cells[clmIndex].Value = value;
            rowIndex = dgv.Rows.Add();
        }

    }
}
