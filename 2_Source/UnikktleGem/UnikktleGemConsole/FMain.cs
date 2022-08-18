using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;
using UnikktleGemCodeAnalyzer;


namespace UnikktleGemConsole
{


    public partial class FMain : Form
    {
        //private const string DgvClm解析実行履歴.AnalizeDate = "AnalizeDate";
        //private const string DgvClm解析実行履歴.AnalizeFilePath = "AnalizeFilePath";
        //private TC_Solution _TC_Solution;
        private SolutionSetting _SolutionSetting_Selected;


        public FMain()
        {
            InitializeComponent();
        }

        

        private void FMain_Load(object sender, EventArgs e)
        {
            try
            {
                listSolution.DisplayMember = nameof(SolutionSetting.SolutionFileName);
                listSolution.ValueMember = nameof(SolutionSetting.ID);

                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.AnalizeFilePath, "", false, DataGridViewContentAlignment.MiddleLeft);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.AnalizeDate, "解析日時", true, DataGridViewContentAlignment.MiddleLeft);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Project, "プロジェクト数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.SrcFile, "ソースファイル数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.ResxFile, "リソースファイル数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Namespace, "Namespace数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Struct, "Struct数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Enum, "Enum数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Delegate, "Delegate数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Class, "Class数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Event, "Event数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Indexer, "Indexer数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Property, "Property数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Constructor, "Constructor数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Field, "Field数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Interface, "Interface数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.Method, "Method数", true, DataGridViewContentAlignment.MiddleRight);
                Dgv解析実行履歴_AddClm(DgvClm解析実行履歴.CallMethod, "CallMethod数", true, DataGridViewContentAlignment.MiddleRight);

                ListSettingUpdate();

                // ソリューション初回登録時、dgv解析実行履歴の列サイズが変わるのが違和感があるので、始めから列幅を調整しておく
                dgv解析実行履歴.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void バージョンToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FVersion();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }



        private void btnソリューション登録_Click(object sender, EventArgs e)
        {
            try
            {
                var fRegistSolution = new FRegistSolution(null);
                fRegistSolution.ShowDialog();

                ListSettingUpdate();
                SelectedIndexChanged();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn編集_Click(object sender, EventArgs e)
        {
            try
            {
                var solutionSetting = (SolutionSetting)listSolution.SelectedItems[0];
                var fRegistSolution = new FRegistSolution(solutionSetting);
                fRegistSolution.ShowDialog();

                // ソリューション設定欄を更新
                UpdataDetail();

                // ソリューション一覧欄を更新
                ListSettingUpdate();

                // ListBoxのアイテムを選択し直す
                listSolution.SelectedItem = solutionSetting;
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private async void btn解析実行_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("解析を実行しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    != DialogResult.OK)
                {
                    return;
                }

                using (var fWait = new FWait())
                {
                    fWait.Show();

                    DirectoryOps.CreateFolder(SingletonData._Selected_DB_Folder);

                    // 現在選択している行のインデックスを取得
                    var selectedItem = (SolutionSetting)listSolution.SelectedItems[0];

                    // ソリューションデータフォルダを削除
                    var solutionSettings = SingletonData._SolutionSettings.SolutionSettingList.First(x => x.ID == selectedItem.ID);

                    var dt = DateTime.Now;
                    var analizeHistory = new AnalizeHistory()
                    {
                        AnalizeDate = dt,
                        AnalizeFilePath = solutionSettings.SolutionDataFolderPath__Hist + "\\" + dt.ToString(SettingFileConst._ID_Format) + SettingFileConst._DataFileExtension
                    };

                    //ソースコード解析
                    var result = await CodeAnalyze1_Solution.RunAsync(txtSolutionFile.Text);
                    analizeHistory.IdCounter = result.IdCounter;

                    DirectoryOps.WriteBinaryFile(analizeHistory.AnalizeFilePath, result);

                    _SolutionSetting_Selected.AnalizeHistoryList.Add(analizeHistory);

                    // 解析結果を日次で降順でソートしてから保存する。
                    _SolutionSetting_Selected.AnalizeHistoryList.Sort((a, b) => b.AnalizeDate.CompareTo(a.AnalizeDate));

                    //DirectoryOps.WriteSolutionSettings(SingletonData._SolutionSettings);
                    DirectoryOps.WriteBinaryFile(SingletonData._SolutionSettingsFilePath, SingletonData._SolutionSettings);


                    Renew解析実行履歴();
                }

                MessageBox.Show("解析完了");
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn抽出_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FViewAnalyze(Get解析パック());
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnリファクタリング_Click(object sender, EventArgs e)
        {
            try
            {
                //if (dgv解析実行履歴.Columns[dgv解析実行履歴.CurrentCell.ColumnIndex].Name == DgvClm解析実行履歴.AnalizeDate)
                //{
                var form = new FRefactoringList(Get解析パック());
                form.ShowDialog();
                //}
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnテストコード_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FTestCode(Get解析パック());
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void listSolution_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Delete)
                {
                    // Deleteキーが押されたら項目を削除

                    if (listSolution.SelectedItems.Count < 1)
                    {
                        // ソリューションが未登録なので、何もしない。
                        return;
                    }

                    if (MessageBox.Show("削除しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    {
                        return;
                    }

                    // 現在選択している行のインデックスを取得
                    var selectedItem = (SolutionSetting)listSolution.SelectedItems[0];

                    // ソリューションデータフォルダを削除
                    var solutionSettings =  SingletonData._SolutionSettings.SolutionSettingList.First(x => x.ID == selectedItem.ID);
                    Directory.Delete(solutionSettings.SolutionDataFolderPath__Top, true);
                    

                    SingletonData._SolutionSettings.SolutionSettingList.RemoveAll(x => x.ID == selectedItem.ID);
                    txtSolutionName.Text = "";
                    txtSolutionFile.Text = "";
                    btnソリューション編集.Enabled = false;

                    //DirectoryOps.WriteSolutionSettings(SingletonData._SolutionSettings);
                    DirectoryOps.WriteBinaryFile(SingletonData._SolutionSettingsFilePath, SingletonData._SolutionSettings);

                    listSolution.Items.RemoveAt(listSolution.SelectedIndex);
                    dgv解析実行履歴.Rows.Clear();

                    if (listSolution.Items.Count > 0)
                    {
                        listSolution.SelectedIndex = 0;
                    }

                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void dgv解析実行履歴_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void listSolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedIndexChanged();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }
        private void dgv解析実行履歴_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedIndexChanged解析実行履歴();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void SelectedIndexChanged()
        {
            if (listSolution.SelectedItems.Count > 0)
            {
                Renew解析実行履歴();

                btnソリューション編集.Enabled = true;
                btn解析実行.Enabled = true;
            }
            else
            {
                btnソリューション編集.Enabled = false;
                btn抽出.Enabled = false;
                btnリファクタリング.Enabled = false;
                btn解析実行.Enabled = false;
                btnテストコード.Enabled = false;
            }
        }

        private void SelectedIndexChanged解析実行履歴()
        {
            if (dgv解析実行履歴.Rows.Count > 0)
            {
                btn抽出.Enabled = true;
                btnリファクタリング.Enabled = true;
                btnテストコード.Enabled = true;
            }
        }

        private void dgv解析履歴_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (dgv解析実行履歴.Columns[e.ColumnIndex].Name == DgvClm解析実行履歴.AnalizeDate)
            //    {
            //        var form2 = new FViewAnalyze((string)dgv解析実行履歴.Rows[e.RowIndex].Cells[DgvClm解析実行履歴.AnalizeFilePath].Value);
            //        form2.ShowDialog();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    LoggerSt.Error(ex);
            //}
        }

        //private void btn解析結果表示_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (var fWait = new FWait())
        //        {
        //            fWait.Show();

        //            SingletonData._Selected_TC_Solution = (TC_Solution)DirectoryOps.ReadBinaryFile(SingletonData._Selected_DB_Folder + "\\1.dat");

        //            fWait.Hide();

        //            //var form2 = new FViewAnalyze(SingletonData._Selected_TC_Solution);
        //            //form2.ShowDialog();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.WriteLog(ex);
        //    }
        //}

        private void Dgv解析実行履歴_AddClm(string name, string headerText, bool visible, DataGridViewContentAlignment alignment)
        {
            dgv解析実行履歴.Columns.Add(new DataGridViewColumn()
            {
                Name = name,
                HeaderText = headerText,
                Visible = visible,
                CellTemplate = new DataGridViewTextBoxCell()
            });

            dgv解析実行履歴.Columns[name].DefaultCellStyle.Alignment = alignment;
        }

        private void Renew解析実行履歴()
        {
            dgv解析実行履歴.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgv解析実行履歴.Rows.Clear();

            // 現在選択している行のインデックスを取得
            _SolutionSetting_Selected = (SolutionSetting)listSolution.SelectedItems[0];
            SingletonData._Selected_DB_Folder = FolderConst._Db + "\\" + _SolutionSetting_Selected.ID;

            txtSolutionName.Text = _SolutionSetting_Selected.SolutionFileName;
            txtSolutionFile.Text = _SolutionSetting_Selected.SolutionFilePath;

            foreach (var analizeHistory in _SolutionSetting_Selected.AnalizeHistoryList)
            {
                var rowIndex = dgv解析実行履歴.Rows.Add();

                //row.Cells[_ClmName_Solution].Value = _TC_Solution.SolutionName;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.AnalizeFilePath].Value = analizeHistory.AnalizeFilePath;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.AnalizeDate].Value = analizeHistory.AnalizeDate;

                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Project].Value = analizeHistory.IdCounter.Project;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.SrcFile].Value = analizeHistory.IdCounter.SrcFile;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.ResxFile].Value = analizeHistory.IdCounter.ResxFile;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Namespace].Value = analizeHistory.IdCounter.Namespace;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Struct].Value = analizeHistory.IdCounter.Struct;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Enum].Value = analizeHistory.IdCounter.Enum;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Delegate].Value = analizeHistory.IdCounter.Delegate;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Class].Value = analizeHistory.IdCounter.Class;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Event].Value = analizeHistory.IdCounter.Event;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Indexer].Value = analizeHistory.IdCounter.Indexer;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Property].Value = analizeHistory.IdCounter.Property;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Constructor].Value = analizeHistory.IdCounter.Constructor;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Field].Value = analizeHistory.IdCounter.Field;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Interface].Value = analizeHistory.IdCounter.Interface;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.Method].Value = analizeHistory.IdCounter.Method;
                dgv解析実行履歴.Rows[rowIndex].Cells[DgvClm解析実行履歴.CallMethod].Value = analizeHistory.IdCounter.CallMethod;
            }

            dgv解析実行履歴.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ListSettingUpdate()
        {
            listSolution.Items.Clear();

            foreach (var solutionSetting in SingletonData._SolutionSettings.SolutionSettingList)
            {
                listSolution.Items.Add(solutionSetting);
            }

            if (SingletonData._SolutionSettings.SolutionSettingList.Count() > 0)
            {
                // これで SelectedIndexChanged()メソッドをキックする。
                listSolution.SelectedIndex = 0;
            }
        }

        //private void SelectedIndexChanged()
        //{
        //    if (listSolution.SelectedItems.Count > 0)
        //    {
        //        UpdataDetail();

        //        btnソリューション編集.Enabled = true;
        //        btn解析実行.Enabled = true;

        //        if (dgv解析実行履歴.Rows.Count > 0)
        //        {
        //            btnテストコード.Enabled = true;
        //        }
        //    }
        //    else
        //    {
        //        btnソリューション編集.Enabled = false;
        //        btn解析実行.Enabled = false;
        //        btnテストコード.Enabled = false;
        //    }
        //}

        private void UpdataDetail()
        {
            // 現在選択している行のインデックスを取得
            var selectedItem = (SolutionSetting)listSolution.SelectedItems[0];

            txtSolutionName.Text = selectedItem.SolutionFileName;
            txtSolutionFile.Text = selectedItem.SolutionFilePath;
        }

        private 解析パック Get解析パック()
        {
            var analizeFilePath = (string)dgv解析実行履歴.Rows[dgv解析実行履歴.CurrentCell.RowIndex].Cells[DgvClm解析実行履歴.AnalizeFilePath].Value;
            var analizeDate = (DateTime)dgv解析実行履歴.Rows[dgv解析実行履歴.CurrentCell.RowIndex].Cells[DgvClm解析実行履歴.AnalizeDate].Value;

            return new 解析パック()
            {
                _SolutionSetting = _SolutionSetting_Selected,
                _TC_Solution = (TC_Solution)DirectoryOps.ReadBinaryFile(analizeFilePath),
                _ソリューション名 = txtSolutionName.Text,
                _AnalizeFilePath = analizeFilePath,
                _AnalizeDate = analizeDate,
                _画面タイトル補足 = "(" + txtSolutionName.Text + " " + analizeDate + ")",
            };
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

}
