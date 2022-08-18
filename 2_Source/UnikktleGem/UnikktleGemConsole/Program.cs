using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;

namespace UnikktleGemConsole
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                LoggerSt.Info("UnikktleGem Startup.");

                FolderSetup.Initialize();
                SingletonData.Initialize();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FMain());
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }


        }
    }
}
