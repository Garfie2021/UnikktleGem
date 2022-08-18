using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;

namespace UnikktleGemConsole
{
    public static class DgvClm重複メソッド
    {
        public const int ProjectName列 = 0;
        public const int ProjectFilePath列 = 1;
        public const int SrcFileName列 = 2;
        public const int SrcFileFilePath列 = 3;
        public const int NamespaceName列 = 4;
        public const int ClassName列 = 5;
        public const int メソッドName列 = 6;
    }


    public static class Fメソッド内のソースコードが全く同じメソッドをリストアップSt
    {

        public static void DGV表示(TC_Solution tcSolution, DataGridView dgv)
        {
            LoggerSt.Info("Start 更新.");

            int rowIndex = 0;
            foreach (var tcProject in tcSolution.ProjectList)
            {
                foreach (var tcSrcFile in tcProject.SrcFileList)
                {
                    foreach (var tcNamespace in tcSrcFile.NamespaceList)
                    {
                        // ToDo:Namespaceのネスト対応。「Namespace名.Namespace名.Namespace名...」という感じ。

                        foreach (var tcClass in tcNamespace.ClassList)
                        {
                            // ToDo:クラスのネスト対応。「クラス名.クラス名.クラス名...」という感じ。

                            foreach (var tcMethod in tcClass.MethodList)
                            {
                                if (tcMethod.重複メソッドList.Count() < 1)
                                {
                                    continue;
                                }

                                foreach (var 重複メソッド in tcMethod.重複メソッドList)
                                {
                                    dgv.Rows[rowIndex].Cells[DgvClm重複メソッド.ProjectName列].Value = 重複メソッド.ProjectName;
                                    dgv.Rows[rowIndex].Cells[DgvClm重複メソッド.ProjectFilePath列].Value = 重複メソッド.ProjectFilePath;
                                    dgv.Rows[rowIndex].Cells[DgvClm重複メソッド.SrcFileName列].Value = 重複メソッド.SrcFileName;
                                    dgv.Rows[rowIndex].Cells[DgvClm重複メソッド.SrcFileFilePath列].Value = 重複メソッド.SrcFileFilePath;
                                    dgv.Rows[rowIndex].Cells[DgvClm重複メソッド.NamespaceName列].Value = 重複メソッド.NamespaceName;
                                    dgv.Rows[rowIndex].Cells[DgvClm重複メソッド.ClassName列].Value = 重複メソッド.ClassName;
                                    dgv.Rows[rowIndex].Cells[DgvClm重複メソッド.メソッドName列].Value = 重複メソッド.メソッドName;
                                }
                            }
                        }
                    }
                }
            }

            //var rowIndex = 0;
            //foreach (var tcProject in tcSolution.ProjectList)
            //{
            //    Project単位(tcProject, dgv, ref rowIndex);
            //}

            //public static void Project単位(EC_Project ecProject, TC_Project tcProject, DataGridView dgv, ref int rowIndex)
            //{
            //    var clmIndex = DgvClm抽出結果.Project開始列;
            //    DataGridView_SetCellValue(SrcMemberTypeName.Project, tcProject.FilePath, tcProject.Name, dgv, ref rowIndex, ref clmIndex);

            //    foreach (var tcSrcFile in tcProject.SrcFileList)
            //    {
            //        SrcFile単位(ecProject, tcSrcFile, dgv, ref rowIndex);
            //    }

            //    foreach (var tcResxFile in tcProject.ResxFileList)
            //    {
            //        ResxFile単位(ecProject, tcResxFile, dgv, ref rowIndex);
            //    }

            //    //if (!Chk空行_SrcFileまで(dgv, rowIndex, _ClmNo_Project))
            //    //{
            //    //    rowIndex = dgv.Rows.Add();
            //    //}
            //}

            LoggerSt.Info("End 更新.");

            //dgv.Rows.RemoveAt(rowIndex);

        }
    }

}
