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
    public partial class Fメソッド内のソースコードが全く同じメソッドをリストアップ : Form
    {
        private 解析パック _解析パック;

        public Fメソッド内のソースコードが全く同じメソッドをリストアップ(解析パック 解析パック)
        {
            InitializeComponent();

            _解析パック = 解析パック;
        }

        private void FRefactoringList_Load(object sender, EventArgs e)
        {
            try
            {
                dgv結果.SuspendLayout();

                this.Text += _解析パック._画面タイトル補足;

                FViewAnalyzeSt.DataGridView初期化(dgv結果);

                Fメソッド内のソースコードが全く同じメソッドをリストアップSt.DGV表示(_解析パック._TC_Solution, dgv結果);

                dgv結果.ResumeLayout();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

    }
}
