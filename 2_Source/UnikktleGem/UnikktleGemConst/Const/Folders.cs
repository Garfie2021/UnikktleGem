using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnikktleGemConst
{
    public static class FolderConst
    {
        /// <summary>
        /// アプリケーションフォルダ
        /// パス：(インストールフォルダ)\Bin
        /// </summary>

        /// <summary>
        /// Confitフォルダ
        /// パス：(インストールフォルダ)\Config
        /// </summary>
        public const string _Config = @"..\Config";

        /// <summary>
        /// ソリューションデータフォルダ
        /// パス：(インストールフォルダ)\Db
        /// </summary>
        public const string _Db = @"..\Db";

        /// <summary>
        /// 解析結果履歴フォルダ
        /// パス：(インストールフォルダ)\Db\(ソリューションフォルダ)\Hist
        /// </summary>
        public const string _AnalyzeHist = @"\AnalyzeHist";

    }
}
