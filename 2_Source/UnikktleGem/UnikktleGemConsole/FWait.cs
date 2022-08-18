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
    public partial class FWait : Form
    {
        public FWait()
        {
            InitializeComponent();
        }

        private void FWait_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //txtStatus.Text =  
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }

            

        }
    }
}
