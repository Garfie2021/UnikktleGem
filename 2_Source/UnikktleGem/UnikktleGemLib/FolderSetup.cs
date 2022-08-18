using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using UnikktleGemConst;


namespace UnikktleGemLib
{
    public static class FolderSetup
    {
        public static void Initialize()
        {
            //var configFolder = Directory.GetCurrentDirectory() + Folders._Confit;
            var configFolder = FolderConst._Config;

            if (!Directory.Exists(configFolder))
            {
                Directory.CreateDirectory(configFolder);
            }

            //var dbFolder = Directory.GetCurrentDirectory() + Folders._Db;
            var dbFolder = FolderConst._Db;

            if (!Directory.Exists(dbFolder))
            {
                Directory.CreateDirectory(dbFolder);
            }
        }
    }
}
