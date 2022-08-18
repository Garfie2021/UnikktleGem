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
    public partial class FTestCode : Form
    {
        private 解析パック _解析パック;

        public FTestCode(解析パック 解析パック)
        {
            InitializeComponent();

            _解析パック = 解析パック;
        }

        private void FTestCode_Load(object sender, EventArgs e)
        {
            try
            {
                using (var fWait = new FWait())
                {
                    fWait.Show();

                    this.Text += _解析パック._画面タイトル補足;

                    txtテストコード出力先フォルダ.Text = _解析パック._SolutionSetting.TestCodeSetting.OutPutFolderPath;

                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnテストコード出力先フォルダ選択_Click(object sender, EventArgs e)
        {
            try
            {
                //FolderBrowserDialogクラスのインスタンスを作成
                var fbd = new FolderBrowserDialog();

                //上部に表示する説明テキストを指定する
                fbd.Description = "フォルダを指定してください。";
                //ルートフォルダを指定する
                //デフォルトでDesktop
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                //最初に選択するフォルダを指定する
                //RootFolder以下にあるフォルダである必要がある
                fbd.SelectedPath = Directory.GetCurrentDirectory();
                //ユーザーが新しいフォルダを作成できるようにする
                //デフォルトでTrue
                fbd.ShowNewFolderButton = true;

                //ダイアログを表示する
                if (fbd.ShowDialog(this) == DialogResult.OK)
                {
                    //選択されたフォルダを表示する
                    txtテストコード出力先フォルダ.Text = fbd.SelectedPath;
                    //SingletonData._Selected_SolutionSetting.TestCodeSetting.OutPutFolderPath = fbd.SelectedPath;

                    SingletonData._SolutionSettings.SolutionSettingList.First(x => x.ID == _解析パック._SolutionSetting.ID).TestCodeSetting.OutPutFolderPath 
                        = fbd.SelectedPath;

                    DirectoryOps.WriteBinaryFile(SingletonData._SolutionSettingsFilePath, SingletonData._SolutionSettings);
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnテストコード生成_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var tcProject in _解析パック._TC_Solution.ProjectList)
                {
                    foreach (var tcSrcFile in tcProject.SrcFileList)
                    {
                        var projectFolderPath = tcProject.FilePath.Substring(0, tcProject.FilePath.LastIndexOf("\\"));
                        var testCodeFilePath = tcSrcFile.FilePath.Replace(projectFolderPath, "");
                        testCodeFilePath = txtテストコード出力先フォルダ.Text + testCodeFilePath;

                        var testCode = txtテストコード出力先フォルダ.Text;

                        foreach (var tcNamespace in tcSrcFile.NamespaceList)
                        {
                            foreach (var tcClass in tcNamespace.ClassList)
                            {
                                foreach (var tcMethod先 in tcClass.MethodList)
                                {

                                }
                            }
                        }

                        File.WriteAllText(testCodeFilePath, testCode, Encoding.UTF8);
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
