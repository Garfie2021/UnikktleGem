using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;

namespace UnikktleGemLib
{
    public static class DirectoryOps
    {
        // TODO :using System.Runtime.InteropServices;
        private const int FO_DELETE = 0x0003;
        private const int FOF_ALLOWUNDO = 0x0040;           // Preserve undo information, if possible. 
        private const int FOF_NOCONFIRMATION = 0x0010;      // Show no confirmation dialog box to the user

        // Struct which contains information that the SHFileOperation function uses to perform file operations. 
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHFILEOPSTRUCT
        {
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.U4)]
            public int wFunc;
            public string pFrom;
            public string pTo;
            public short fFlags;
            [MarshalAs(UnmanagedType.Bool)]
            public bool fAnyOperationsAborted;
            public IntPtr hNameMappings;
            public string lpszProgressTitle;
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        static extern int SHFileOperation(ref SHFILEOPSTRUCT FileOp);

        public static void DeleteFileOrFolder(string path)
        {
            SHFILEOPSTRUCT fileop = new SHFILEOPSTRUCT();
            fileop.wFunc = FO_DELETE;
            fileop.pFrom = path + '\0' + '\0';
            //fileop.fFlags = FOF_ALLOWUNDO | FOF_NOCONFIRMATION;
            fileop.fFlags = FOF_NOCONFIRMATION;
            SHFileOperation(ref fileop);
        }

        public static void CreateFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                LoggerSt.Info("Create folder : " + folderPath);

                Directory.CreateDirectory(folderPath);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="結果出力先フォルダ"></param>
        /// <param name="solution"></param>
        public static void CreateFile(string 結果出力先フォルダ, TC_Solution solution)
        {
            var solutionFolderPath = 結果出力先フォルダ + "\\" + solution.Name;

            if (Directory.Exists(solutionFolderPath))
            {
                LoggerSt.Info("Delete folder : " + solutionFolderPath);

                //Directory.Delete(solutionFolderPath, true);
                DeleteFileOrFolder(solutionFolderPath);
            }

            LoggerSt.Info("Create folder : " + solutionFolderPath);

            Directory.CreateDirectory(solutionFolderPath);

            foreach (var project in solution.ProjectList)
            {
                var projectFolderPath = solutionFolderPath + "\\" + project.Name;
                Directory.CreateDirectory(projectFolderPath);

                foreach (var document in project.SrcFileList)
                {
                    var fileName = document.Name.Substring(0, document.Name.IndexOf(".")) + "_Test.cs";
                    var documentFolderPath = projectFolderPath + "\\" + fileName;

                    File.WriteAllText(documentFolderPath, "");
                }
            }
        }


        //public static void WriteViewTemplateSettingsSettings(ViewTemplateSettings viewTemplateSettings)
        //{
        //    LoggerSt.Info("Write file : " + SingletonData._ViewTemplateSettingsFilePath);

        //    var xmlSerializer1 = new XmlSerializer(typeof(ViewTemplateSettings));
        //    using (var streamWriter = new StreamWriter(SingletonData._SolutionSettingsFilePath, false, Encoding.UTF8))
        //    {
        //        xmlSerializer1.Serialize(streamWriter, viewTemplateSettings);
        //        streamWriter.Flush();
        //    }
        //}

        //public static void WriteSolutionSettings(SolutionSettings solutionSettings)
        //{
        //    LoggerSt.Info("Write file : " + SingletonData._SolutionSettingsFilePath);

        //    var xmlSerializer1 = new XmlSerializer(typeof(SolutionSettings));
        //    using (var streamWriter = new StreamWriter(SingletonData._SolutionSettingsFilePath, false, Encoding.UTF8))
        //    {
        //        xmlSerializer1.Serialize(streamWriter, solutionSettings);
        //        streamWriter.Flush();
        //    }
        //}

        public static void WriteBinaryFile(string path, object obj)
        {
            //var fullFilePath = Directory.GetCurrentDirectory() + "\\" + path;
            var fullFilePath = path;

            LoggerSt.Info("Write file : " + fullFilePath);

            using ( var fs = new FileStream(fullFilePath, FileMode.Create, FileAccess.Write))
            {
                var bf = new BinaryFormatter();

                bf.Serialize(fs, obj);
            }
        }

        /// <summary>
        /// 解析結果
        /// </summary>
        /// <param name="solutionSettingsFilePath"></param>
        /// <returns></returns>
        //public static SolutionSettings ReadSolutionSettings(string solutionSettingsFilePath)
        //{
        //    var xmlSerializer2 = new XmlSerializer(typeof(SolutionSettings));

        //    var xmlSettings = new XmlReaderSettings()
        //    {
        //        CheckCharacters = true,
        //    };

        //    LoggerSt.Info("Read file : " + solutionSettingsFilePath);

        //    using (var streamReader = new StreamReader(solutionSettingsFilePath, Encoding.UTF8))
        //    using (var xmlReader = XmlReader.Create(streamReader, xmlSettings))
        //    {
        //        return (SolutionSettings)xmlSerializer2.Deserialize(xmlReader);
        //    }
        //}

        public static object ReadBinaryFile(string path)
        {
            //var fullFilePath = Directory.GetCurrentDirectory() + "\\" + path;
            var fullFilePath = path;

            LoggerSt.Info("Read file : " + fullFilePath);

            using (var fs = new FileStream(fullFilePath, FileMode.Open, FileAccess.Read))
            {
                var binaryFormatter = new BinaryFormatter();

                return binaryFormatter.Deserialize(fs);
            }
        }
    }
}
