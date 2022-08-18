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
    public partial class FRefactoringList_UnikktleGem : Form
    {
        private 解析パック _解析パック;

        public FRefactoringList_UnikktleGem(解析パック 解析パック)
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


        private void btnメソッド内のソースコードが全く同じメソッドをリストアップ_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new Fメソッド内のソースコードが全く同じメソッドをリストアップ(_解析パック))
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }
    }
}
