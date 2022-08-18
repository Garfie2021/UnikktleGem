using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;

namespace UnikktleGemLib
{
    public static class SingletonData
    {
        /// <summary>
        /// 表示テンプレート設定ファイルパス
        /// </summary>
        public static string _ViewTemplateSettingsFilePath;


        /// <summary>
        /// ソリューション設定ファイルパス
        /// </summary>
        public static string _SolutionSettingsFilePath;

        /// <summary>
        /// 全ソリューション設定
        /// </summary>
        public static SolutionSettings _SolutionSettings = new SolutionSettings();

        /// <summary>
        /// 選択中のソリューション
        /// </summary>
        //public static SolutionSetting _Selected_SolutionSetting;

        ///// <summary>
        ///// 選択中ソリューションの解析結果
        ///// </summary>
        //public static TC_Solution _Selected_TC_Solution;

        /// <summary>
        /// 選択中ソリューションのDBフォルダ
        /// </summary>
        public static string _Selected_DB_Folder;


        public static void Initialize()
        {
            _SolutionSettingsFilePath = FolderConst._Config + @"\" + SettingFileConst._SolutionSettingsFileName;

            if (!File.Exists(_SolutionSettingsFilePath))
            {
                //DirectoryOps.WriteSolutionSettings(_SolutionSettings);
                DirectoryOps.WriteBinaryFile(_SolutionSettingsFilePath, _SolutionSettings);
            }

            //_SolutionSettings = DirectoryOps.ReadSolutionSettings(_SolutionSettingsFilePath);
            _SolutionSettings = (SolutionSettings)DirectoryOps.ReadBinaryFile(_SolutionSettingsFilePath);

            // ファイルパスだけ作成しておく。ファイル読込は FViewAnalyze 画面表示時に行う。
            _ViewTemplateSettingsFilePath = FolderConst._Config + @"\" + SettingFileConst._ViewTemplateSettingsFileName;

        }
    }
}
