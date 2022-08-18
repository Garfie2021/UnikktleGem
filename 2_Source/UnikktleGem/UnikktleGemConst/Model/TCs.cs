using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
//using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

using System.Collections.Immutable;
using System.Globalization;
using System.Threading;

namespace UnikktleGemConst
{
    [Serializable()]
    public class TC_Solution
    {
        //public Microsoft.CodeAnalysis.Solution CodeAnalysisSolution;

        // ソリューション名とslnファイル名は同じもの
        public string Name;

        public IdCounter IdCounter;

        public List<TC_Project> ProjectList = new List<TC_Project>();
    }

    [Serializable()]
    public class IdCounter
    {
        public int Project = 0;
        public int ResxFile = 0;
        public int SrcFile = 0;
        public int Namespace = 0;
        public int Struct = 0;
        public int Enum = 0;
        public int Delegate = 0;
        public int Class = 0;
        public int Event = 0;
        public int Indexer = 0;
        public int Property = 0;
        public int Constructor = 0;
        public int Field = 0;
        public int Interface = 0;
        public int Method = 0;
        public int CallMethod = 0;
    }

    [Serializable()]
    public class TC_Project
    {
        //public Microsoft.CodeAnalysis.Project CodeAnalysisSolution;

        public int ID;

        public string Name;
        public string FilePath;

        public List<TC_SrcFile> SrcFileList = new List<TC_SrcFile>();

        public List<TC_ResxFile> ResxFileList = new List<TC_ResxFile>();
    }

    /// <summary>
    /// リソースファイル用
    /// </summary>
    [Serializable()]
    public class TC_ResxFile
    {
        public int ID;

        public string Name;
        public string FilePath;

        // リソース内のキー・バリュー
        public Dictionary<string, string> ResourceDictionary = new Dictionary<string, string>();
    }

    [Serializable()]
    public class TC_SrcFile
    {
        public int ID;

        public string Name;
        public string FilePath;

        // UsingしているNamespaceのリスト
        public List<string> UsingNamespaceList = new List<string>();

        // 1ファイルに複数クラスがある場合を想定
        public List<TC_Namespace> NamespaceList = new List<TC_Namespace>();
    }

    /// <summary>
    /// Namespace配下に置けるオブジェクトはこれ=> 
    /// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/namespace
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax?view=roslyn-dotnet
    /// </summary>
    [Serializable()]
    public class TC_Namespace
    {
        public int ID;

        public TC_NamespaceSymbol DeclaredSymbol;  // Microsoft.CodeAnalysis上での定義情報

        public string Name;

        public List<TC_Class> ClassList = new List<TC_Class>();
        public List<TC_Interface> InterfaceList = new List<TC_Interface>();
        public List<TC_Struct> StructList = new List<TC_Struct>();
        public List<TC_Enum> EnumList = new List<TC_Enum>();
        public List<TC_Delegate> DelegateList = new List<TC_Delegate>();
        public List<TC_Namespace> NamespaceList = new List<TC_Namespace>();
    }

    [Serializable()]
    public class TC_Struct
    {
        public int ID;

        //public TC_DeclaredSymbol DeclaredSymbol;

        public string Name;
    }

    [Serializable()]
    public class TC_Enum
    {
        public int ID;

        //public TC_DeclaredSymbol DeclaredSymbol;

        public string Name;
    }

    [Serializable()]
    public class TC_Delegate
    {
        public int ID;

        //public TC_DeclaredSymbol DeclaredSymbol;

        public string Name;
    }


    /// <summary>
    /// Class配下に置けるオブジェクトはこれ=> 
    /// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/class
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntax?view=roslyn-dotnet
    /// </summary>
    [Serializable()]
    public class TC_Class
    {
        public int ID;

        public TC_NamedTypeSymbol DeclaredSymbol;

        public string Name;

        // 継承クラス
        // フォーム画面は「Form」が含まれる。
        public List<string> BaseNameList = new List<string>();

        //クラス
        public List<TC_Class> ClassList = new List<TC_Class>();
        //インターフェイス
        public List<TC_Interface> InterfaceList = new List<TC_Interface>();
        //メソッド
        public List<TC_Method> MethodList = new List<TC_Method>();
        //プロパティ
        public List<TC_Property> PropertyList = new List<TC_Property>();
        //コンストラクター
        public List<TC_Constructor> ConstructorList = new List<TC_Constructor>();
        //フィールド
        public List<TC_Field> FieldList = new List<TC_Field>();
        //インデクサー
        public List<TC_Indexer> IndexerList = new List<TC_Indexer>();
        //イベント
        public List<TC_Event> EventList = new List<TC_Event>();
        //デリゲート
        public List<TC_Delegate> DelegateList = new List<TC_Delegate>();
        //構造体型
        public List<TC_Struct> StructList = new List<TC_Struct>();
        //列挙型
        public List<TC_Enum> EnumList = new List<TC_Enum>();

        
        //定数

        //ファイナライザー

        //演算子

    }

    [Serializable()]
    public class TC_Event
    {
        public int ID;

        //public TC_DeclaredSymbol DeclaredSymbol;

        public string Name;
    }

    [Serializable()]
    public class TC_Indexer
    {
        public int ID;

        //public TC_DeclaredSymbol DeclaredSymbol;

        public string Name;
    }

    [Serializable()]
    public class TC_Property
    {
        public int ID;

        //public TC_DeclaredSymbol DeclaredSymbol;

        public string Name;
    }

    [Serializable()]
    public class TC_Constructor
    {
        public int ID;

        //public TC_DeclaredSymbol DeclaredSymbol;

        public string Name;
    }

    [Serializable()]
    public class TC_Field
    {
        public int ID;

        //public TC_DeclaredSymbol DeclaredSymbol;

        public string Name;

    }

    [Serializable()]
    public class TC_Interface
    {
        public int ID;

        //public TC_DeclaredSymbol DeclaredSymbol;

        public string Name;

    }

    [Serializable()]
    public class TC_Method
    {
        public int ID;

        public TC_MethodSymbol DeclaredSymbol;

        public string Name;

        public string ソースコード;

        // このメソッドと全く同じ内容のメソッドのリスト
        public List<TC_重複メソッド> 重複メソッドList = new List<TC_重複メソッド>();

        // このメソッドのパラメータのリスト
        public List<TC_MethodParameter> MethodParameterList = new List<TC_MethodParameter>();

        // このメソッドが呼び出している、他のメソッド
        public List<TC_CallMethod> CallMethodList = new List<TC_CallMethod>();

        // このメソッドを呼び出している、他のメソッド
        public List<TC_MethodSymbol> DeclaredSymbolList_CallMethod = new List<TC_MethodSymbol>();
        // このメソッドを呼び出している、他のクラスのコンストラクタ
        public List<TC_ConstructorSymbol> DeclaredSymbolList_CallConstructor = new List<TC_ConstructorSymbol>();
        // このメソッドを呼び出している、他のクラスのコンストラクタ
        public List<TC_DestructorSymbol> DeclaredSymbolList_CallDestructor = new List<TC_DestructorSymbol>();
        // このメソッドを呼び出している、他のクラスのコンストラクタ
        public List<TC_PropertySymbol> DeclaredSymbolList_CallProperty = new List<TC_PropertySymbol>();

        // このメソッド内で使用しているリソースのリスト
        public List<string> ThrowAugmentList = new List<string>();

        // このメソッド内で使用しているリソースのリスト
        public List<TC_Resources> ResourcesList = new List<TC_Resources>();

        // このメソッド内で使用している固定値のリスト
        public List<TC_Literal> LiteralList = new List<TC_Literal>();
    }

    [Serializable()]
    public class TC_Resources
    {
        public string ClassName;
        public string KeyName;

        public List<TC_ResourcesLocationValue> ResourcesLocationValue = new List<TC_ResourcesLocationValue>();
    }

    [Serializable()]
    public class TC_ResourcesLocationValue
    {
        public string LocationName;
        public string ResxFilePath;
        public string Value;
    }

    [Serializable()]
    public class TC_Literal
    {
        //public TC_DeclaredSymbol DeclaredSymbol;

        /// <summary>
        /// 下記のリテラルが含まれる
        /// NumericLiteralExpression = 8749,
        /// StringLiteralExpression = 8750,
        /// CharacterLiteralExpression = 8751,
        /// TrueLiteralExpression = 8752,
        /// FalseLiteralExpression = 8753,
        /// NullLiteralExpression = 8754,
        /// DefaultLiteralExpression = 8755,
        /// </summary>
        public SyntaxKind SyntaxKind;

        public string Value;
    }

    [Serializable()]
    public class TC_MethodParameter
    {
        //public TC_DeclaredSymbol DeclaredSymbol;

        public string Name;
        public string ParameterType;
    }

    [Serializable()]
    public class TC_CallMethod
    {
        public int ID;

        //public TC_DeclaredSymbol DeclaredSymbol;

        // このどこかのNamespaceに所属してる。
        public List<string> NamespaceList = new List<string>();

        public string Methodが所属してるClassのName;
        public string MethodName;
    }

    [Serializable()]
    public class TC_重複メソッド
    {
        public string ProjectName;
        public string ProjectFilePath;
        public string SrcFileName;
        public string SrcFileFilePath;
        public string NamespaceName;
        public string ClassName;
        public string メソッドName;
    }
}
