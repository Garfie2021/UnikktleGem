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
using System.Xml.Serialization;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;

namespace UnikktleGemConsole
{
    public partial class FRegistSolution : Form
    {
        //private 登録更新画面モード _登録更新画面モード;
        private SolutionSetting _SolutionSetting;

        public FRegistSolution(SolutionSetting solutionSetting)
        {
            InitializeComponent();

            //_登録更新画面モード = 登録更新画面モード;
            _SolutionSetting = solutionSetting;
        }

        private void FRegistSolution_Load(object sender, EventArgs e)
        {
            try
            {
                if (_SolutionSetting != null)
                {
                    // 更新

                    //txtSolutionName.Text = _SolutionSetting.SolutionName;
                    txtSolutionFilePath.Text = _SolutionSetting.SolutionFilePath;
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn登録_Click(object sender, EventArgs e)
        {
            try
            {

                if (_SolutionSetting == null)
                {
                    // 新規登録

                    var id = DateTime.Now.ToString(SettingFileConst._ID_Format);

                    var slutionSetting = new SolutionSetting()
                    {
                        ID = id,
                        SolutionFilePath = txtSolutionFilePath.Text,
                        SolutionFolderPath = txtSolutionFilePath.Text.Substring(0, txtSolutionFilePath.Text.LastIndexOf("\\") + "\\".Length),
                        SolutionFileName = txtSolutionFilePath.Text.Substring(txtSolutionFilePath.Text.LastIndexOf("\\") + "\\".Length),
                        SolutionDataFolderPath__Top = FolderConst._Db + "\\" + id,
                        SolutionDataFolderPath__Hist = FolderConst._Db + "\\" + id + FolderConst._AnalyzeHist
                    };

                    SingletonData._SolutionSettings.SolutionSettingList.Add(slutionSetting);

                    Directory.CreateDirectory(slutionSetting.SolutionDataFolderPath__Top);
                    Directory.CreateDirectory(slutionSetting.SolutionDataFolderPath__Hist);
                }
                else
                {
                    // 更新

                    var first = SingletonData._SolutionSettings.SolutionSettingList.First(x => x.ID == _SolutionSetting.ID);

                    first.SolutionFileName = txtSolutionFilePath.Text.Substring(txtSolutionFilePath.Text.LastIndexOf("\\"));
                    first.SolutionFilePath = txtSolutionFilePath.Text;
                }

                //DirectoryOps.WriteSolutionSettings(SingletonData._SolutionSettings);
                DirectoryOps.WriteBinaryFile(SingletonData._SolutionSettingsFilePath, SingletonData._SolutionSettings);

                MessageBox.Show("登録しました。");

                Close();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnキャンセル_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    var fileContent = string.Empty;
                    var filePath = string.Empty;
                    
                    openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                    //openFileDialog.Filter = "txt files (*.sln)|"; <= いまいち

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        txtSolutionFilePath.Text = openFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

    }
}
