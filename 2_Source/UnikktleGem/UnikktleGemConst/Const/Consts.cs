using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnikktleGemConst
{
    public static class DgvClm解析実行履歴
    {
        public const string AnalizeFilePath = "0";
        public const string AnalizeDate = "1";
        public const string Project = "2";
        public const string SrcFile = "3";
        public const string ResxFile = "4";
        public const string Namespace = "5";
        public const string Struct = "6";
        public const string Enum = "7";
        public const string Delegate = "8";
        public const string Class = "9";
        public const string Event = "10";
        public const string Indexer = "11";
        public const string Property = "12";
        public const string Constructor = "13";
        public const string Field = "14";
        public const string Interface = "15";
        public const string Method = "16";
        public const string CallMethod = "17";
    }

    public static class DgvClm抽出結果
    {
        public const int オブジェクトタイプ名列 = 0;
        public const int ファイルパス列 = 1;

        public const int Project開始列 = 2;

        public const int SrcFile開始列 = 3;
        public const int リソースファイル開始列 = 3;

        public const int Namespace開始列 = 4;
        public const int ResxKeyValue開始列 = 4;

        public const int Interface開始列 = 5;
        public const int Struct開始列 = 5;
        public const int Enum開始列 = 5;
        public const int Delegate開始列 = 5;
        public const int Class開始列 = 5;

        // ToDo:ソリューションフォルダは？

        // これ以降は動的
        //public const int InnerNamespace開始列 = 4;
        //public const int InnerClass開始列 = 4;
        //public const int Method開始列 = 4;

        //public const int MethodParameter開始列 = 5;
        //public const int CallMethod開始列 = 5;
        //public const int Throw開始列 = 5;
        //public const int Resources開始列 = 5;
        //public const int Literal開始列 = 5;
    }

    // MemberDeclarationSyntax の派生クラスのTypeに対応したEnum
    public static class SrcMemberTypeName
    {
        public const string Project = "Project";
        public const string SourceFile = "Source file";
        public const string ResourceFile = "Resource file";
        public const string ResourceKeyValue = "Resource key value";
        public const string Namespace = "Namespace";
        public const string Class = "Class";
        public const string Interface = "Interface";
        public const string Struct = "Struct";
        public const string Enum = "Enum";
        public const string Delegate = "Delegate";
        public const string Method = "Method";
        public const string MethodParameter = "MethodParameter";
        public const string CallMethod = "CallMethod";
        public const string Throw = "Throw";
        public const string Literal = "Literal";
        public const string Resources = "Resources";
    }

}
