using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnikktleGemConst
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable()]
    public class ViewTemplateSettings
    {
        public List<ViewTemplate> ViewTemplateList = new List<ViewTemplate>();
    }

    [Serializable()]
    public class ViewTemplate
    {
        public int? ID;
        public string TemplateName;
        public EC_Project EC_Project;

        // これがコンボボックスに表示される
        public override string ToString()
        {
            return TemplateName;
        }
    }

    /// <summary>
    /// 抽出条件
    /// </summary>
    [Serializable()]
    public class EC_Project
    {
        public bool SrcFile;
        public EC_SrcFile EC_SrcFile;

        public bool ResourceFile;
    }

    [Serializable()]
    public class EC_SrcFile
    {
        public bool Namespace;
        public EC_Namespace EC_Namespace;
    }

    [Serializable()]
    public class EC_Namespace
    {
        public bool Interface;
        public bool Struct;
        public bool Enum;
        public bool Delegate;
        public bool Namespace;

        public bool Class;
        public EC_Class EC_Class;
    }

    [Serializable()]
    public class EC_Class
    {
        public bool 継承無し;
        public bool 継承有り;
        public bool FormOnly;

        public bool Method;
        public EC_Method EC_Method;
    }

    [Serializable()]
    public class EC_Method
    {
        public bool MethodParameter;
        public bool CallMethod;
        public bool Throw;
        public bool Resources;

        public bool イベントハンドラのみ;
        public bool Resourcesを呼び出し元のメソッドに纏める;

        public bool Literal;
        public EC_Literal EC_Literal;
    }

    [Serializable()]
    public class EC_Literal
    {
        public bool String;
        public bool Numeric;
        public bool Boolean;
        public bool Other;
    }


    public class View件数
    {
        public int Project;
        public int ResxFile;
        public int Resources;

        public int SrcFile;
        public int Namespace;
        public int Class;
        public int Struct;
        public int Enum;
        public int Delegate;
        public int Interface;
        public int Method;
        public int Constructor;
        public int Field;
        public int Property;
        public int Indexer;
        public int Event;

        public int MethodParameter;
        public int CallMethod;
        public int ThrowAugment;
        public int Literal;
        public int UseResources;


    }

}
