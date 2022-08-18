using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;
using UnikktleGemConsole.Properties;

namespace UnikktleGemConsole
{
    public partial class FRefactoringList_VisualStudio : Form
    {
        private 解析パック _解析パック;

        public FRefactoringList_VisualStudio(解析パック 解析パック)
        {
            InitializeComponent();

            _解析パック = 解析パック;
        }

        private void FRefactoringList_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text += _解析パック._画面タイトル補足;
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnドキュメントフォーマット実行_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FDocumentFormat())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn使われていないusingnamespaceを削除_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FUsingNamespaceDeleteNotUses())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnUsingNamespace並び替え_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FUsingNamespaceSort())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnアクセシビリティ修飾子を追加_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FAccessibilityQualifierAdd())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnアクセシビリティ修飾子をソート_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FAccessibilityQualifierSort())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnprivateフィールドを可能な限り読み取り専用にする_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FMakePrivateFieldsReadOnly())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn使われていないメソッド_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FNotUseMethod(_解析パック))
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn使われていない変数を削除_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FUnusedVariable())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnthis修飾子を加える_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FAddThisModifier())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn不要なキャストを削除_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FRemoveUnnecessaryCast())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn型が明確な変数はvarを使う_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FUseVar())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnインライン変数優先_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FInlineVariablePriority())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnオブジェクトコレクションの初期化の基本設定を適用_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new Fオブジェクトコレクションの初期化の基本設定を適用())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn単一行のコントロールステートメントに対する波かっこの追加削除_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new F単一行のコントロールステートメントに対する波かっこの追加削除())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn言語フレームワークの型の基本設定を適用_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new F言語フレームワークの型の基本設定を適用())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する_Click(object sender, EventArgs e)
        {
            try
            {
                var editorConfigファイルパス = _解析パック._SolutionSetting.SolutionFolderPath + @"\.editorconfig";

                if (MessageBox.Show("UnikktleGem推奨設定の .editorconfigファイルをソリューションフォルダに配置します。\r\nよろしいですか？\r\n\r\n【.editorconfigファイルパス】\r\n"
                    + editorConfigファイルパス, "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    return;
                }

                File.WriteAllText(editorConfigファイルパス, Resources.EditorConfigValue);

                MessageBox.Show(".editorconfigファイルを配置しました。SVN/Gitなどのバージョン管理ツールを使用している場合、各ソースファイルと同様に.editorconfigファイルも登録して下さい。" 
                    + editorConfigファイルパス, "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

    }
}
