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
    public partial class FViewAnalyzeResult : Form
    {
        private TC_Solution _TC_Solution;
        private ViewTemplate _ViewTemplate;
        private string _画面タイトル補足;
        

        public FViewAnalyzeResult(TC_Solution tcSolution, ViewTemplate viewTemplate, string 画面タイトル補足)
        {
            _TC_Solution = tcSolution;
            _ViewTemplate = viewTemplate;
            _画面タイトル補足 = 画面タイトル補足;

            InitializeComponent();
        }

        private void FViewAnalyzeResult_Load(object sender, EventArgs e)
        {
            try
            {
                using (var fWait = new FWait())
                {
                    fWait.Show();

                    this.Text += _画面タイトル補足;

                    LoggerSt.Info("Start 更新.");

                    dgv結果.SuspendLayout();
                    dgv結果.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    var view件数_全件数 = FViewAnalyzeSt.全件数更新(_TC_Solution);

                    FViewAnalyzeSt.DataGridView初期化(dgv結果);

                    FViewAnalyzeSt.検索条件に合わせて解析結果を加工(_ViewTemplate.EC_Project, _TC_Solution);

                    FViewAnalyzeSt.DGV表示(_ViewTemplate.EC_Project, _TC_Solution, dgv結果);

                    // ToDo:ユーザが列幅を変更できなくなる。
                    //LoggerSt.Info("Start AutoSizeColumns.");
                    //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //LoggerSt.Info("End AutoSizeColumns.");
                    dgv結果.ResumeLayout();

                    var view件数_絞り込み後件数 = FViewAnalyzeSt.全件数更新(_TC_Solution);

                    // 件数表示
                    txt件数.Text =
                        $"Project({view件数_絞り込み後件数.Project}/{view件数_全件数.Project})  " +
                        $"ResxFile({view件数_絞り込み後件数.ResxFile}/{view件数_全件数.ResxFile})  " +
                        $"Resource({view件数_絞り込み後件数.Resources}/{view件数_全件数.Resources})  " +
                        $"SrcFile({view件数_絞り込み後件数.SrcFile}/{view件数_全件数.SrcFile})  " +
                        $"Namespace({view件数_絞り込み後件数.Namespace}/{view件数_全件数.Namespace})  " +
                        $"Class({view件数_絞り込み後件数.Class}/{view件数_全件数.Class})  " +
                        $"Struct({view件数_絞り込み後件数.Struct}/{view件数_全件数.Struct})  " +
                        $"Enum({view件数_絞り込み後件数.Enum}/{view件数_全件数.Enum})  " +
                        $"Delegate({view件数_絞り込み後件数.Delegate}/{view件数_全件数.Delegate})  " +
                        $"Interface({view件数_絞り込み後件数.Interface}/{view件数_全件数.Interface})  " +
                        $"Method({view件数_絞り込み後件数.Method}/{view件数_全件数.Method})  " +
                        $"Constructor({view件数_絞り込み後件数.Constructor}/{view件数_全件数.Constructor})  " +
                        $"Field({view件数_絞り込み後件数.Field}/{view件数_全件数.Field})  " +
                        $"Property({view件数_絞り込み後件数.Property}/{view件数_全件数.Property})  " +
                        $"Indexer({view件数_絞り込み後件数.Indexer}/{view件数_全件数.Indexer})  " +
                        $"Event({view件数_絞り込み後件数.Event}/{view件数_全件数.Event})  " +
                        $"MethodParameter({view件数_絞り込み後件数.MethodParameter}/{view件数_全件数.MethodParameter})  " +
                        $"CallMethod({view件数_絞り込み後件数.CallMethod}/{view件数_全件数.CallMethod})  " +
                        $"ThrowAugment({view件数_絞り込み後件数.ThrowAugment}/{view件数_全件数.ThrowAugment})  " +
                        $"Literal({view件数_絞り込み後件数.Literal}/{view件数_全件数.Literal})  " +
                        $"UseResources({view件数_絞り込み後件数.UseResources}/{view件数_全件数.UseResources})  ";
                }

                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void chkオブジェクトカテゴリ_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgv結果.Columns[DgvClm抽出結果.オブジェクトタイプ名列].Visible = chkオブジェクトカテゴリ.Checked;
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void chkファイルパス_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgv結果.Columns[DgvClm抽出結果.ファイルパス列].Visible = chkファイルパス.Checked;
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }
    }
}
