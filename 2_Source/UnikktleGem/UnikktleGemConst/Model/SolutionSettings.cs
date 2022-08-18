using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnikktleGemConst
{
    [Serializable()]
    public class SolutionSettings
    {
        public List<SolutionSetting> SolutionSettingList { get; set; } = new List<SolutionSetting>();
    }

    [Serializable()]
    public class SolutionSetting
    {
        // 「yyyyMMddHHmmssF」フォーマット
        public string ID { get; set; }

        /// <summary>
        /// ユーザが入力したソリューションファイルのファイルパス。
        /// </summary>
        public string SolutionFilePath { get; set; }

        /// <summary>
        /// SolutionFilePath から切り出したファイル名。
        /// </summary>
        public string SolutionFileName { get; set; }

        /// <summary>
        /// SolutionFilePath から切り出したファイル名。
        /// </summary>
        public string SolutionFolderPath { get; set; }

        public string SolutionDataFolderPath__Top { get; set; }
        public string SolutionDataFolderPath__Hist { get; set; }

        public List<AnalizeHistory> AnalizeHistoryList { get; set; } = new List<AnalizeHistory>();

        private TestCodeSetting _TestCodeSetting;
        public TestCodeSetting TestCodeSetting
        {
            set { _TestCodeSetting = value; }
            get
            {
                if (_TestCodeSetting == null)
                {
                    // 既定値。バージョンアップデシリアライズ対応。
                    // こうしないとバージョンアップ時にnullがreturnされる。「{ get; set; } = new TestCodeSetting();」ではダメだった。
                    _TestCodeSetting = new TestCodeSetting();
                    return _TestCodeSetting;
                }
                else
                {
                    return _TestCodeSetting;
                }
            }
        }
    }

    [Serializable()]
    public class AnalizeHistory
    {
        public DateTime AnalizeDate { get; set; }

        public string AnalizeFilePath { get; set; }

        public IdCounter IdCounter { get; set; }
    }

    [Serializable()]
    public class TestCodeSetting
    {
        public string OutPutFolderPath { get; set; }
    }

}
