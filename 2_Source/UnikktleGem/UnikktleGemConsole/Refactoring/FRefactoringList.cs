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
    public partial class FRefactoringList : Form
    {
        private 解析パック _解析パック;

        public FRefactoringList(解析パック 解析パック)
        {
            InitializeComponent();

            _解析パック = 解析パック;
        }

        private void btnリファクタリングを行う_VisualStudio_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FRefactoringList_VisualStudio(_解析パック);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btnリファクタリングを行う_UnikktleGem_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FRefactoringList_UnikktleGem(_解析パック);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }
    }
}
