using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;

namespace UnikktleGemConsole
{
    public partial class FNotUseMethod : Form
    {
        private 解析パック _解析パック;

        public FNotUseMethod(解析パック 解析パック)
        {
            InitializeComponent();

            _解析パック = 解析パック;
        }

        private void FNotUseMethod_Load(object sender, EventArgs e)
        {
            try
            {
                DataGridView初期化(dgv結果);
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn未使用メソッドを抽出_Click(object sender, EventArgs e)
        {
            try
            {
                dgv結果.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                foreach (var project in _解析パック._TC_Solution.ProjectList)
                {
                    foreach (var srcFile in project.SrcFileList)
                    {
                        foreach (var _namespace in srcFile.NamespaceList)
                        {
                            foreach (var _class in _namespace.ClassList)
                            {
                                foreach (var _method in _class.MethodList)
                                {
                                    if (_method.CallMethodList.Count() > 0)
                                    {
                                        continue;
                                    }

                                    int rowIndex = dgv結果.Rows.Add();
                                    dgv結果.Rows[rowIndex].Cells[1].Value = project.Name;
                                    dgv結果.Rows[rowIndex].Cells[2].Value = srcFile.Name;
                                    dgv結果.Rows[rowIndex].Cells[3].Value = _namespace.Name;
                                    dgv結果.Rows[rowIndex].Cells[4].Value = _class.Name;
                                    dgv結果.Rows[rowIndex].Cells[5].Value = _method.Name;
                                }
                            }
                        }
                    }
                }

                dgv結果.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn削除_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("選択されているメソッドを削除しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    return;
                }


            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        public static void DataGridView初期化(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "選択"
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "プロジェクト名"
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "ソースファイル名"
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "namespace名"
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "class名"
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "method名"
            });

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


    }
}
