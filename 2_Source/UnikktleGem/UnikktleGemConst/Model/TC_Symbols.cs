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
    // Microsoft.CodeAnalysis.INamespaceSymbol を継承すると、シリアライズ出来ないエラーが出るので、シリアライズ可能な独自のクラスを設ける。
    // ToDo: INamespaceSymbol の全項目を網羅出来てない。
    [Serializable()]
    public class TC_NamespaceSymbol
    {
        public TC_Symbol _TC_Symbol;

        public bool IsGlobalNamespace;
        public NamespaceKind NamespaceKind;
    }

    // Microsoft.CodeAnalysis.INamedTypeSymbol を継承すると、シリアライズ出来ないエラーが出るので、シリアライズ可能な独自のクラスを設ける。
    // ToDo: INamedTypeSymbol、ITypeSymbol、INamespaceOrTypeSymbol の全項目を網羅出来てない。
    [Serializable()]
    public class TC_NamedTypeSymbol
    {
        public TC_Symbol _TC_Symbol;

        public bool MightContainExtensionMethods;
        public bool IsSerializable;
        public bool IsComImport;
        public bool IsImplicitClass;
        public bool IsScriptClass;
        public bool IsUnboundGenericType;
        public bool IsGenericType;
        public int Arity;
    }

    // Microsoft.CodeAnalysis.IMethodSymbol を継承すると、シリアライズ出来ないエラーが出るので、シリアライズ可能な独自のクラスを設ける。
    // ToDo: IMethodSymbol の全項目を網羅出来てない。
    [Serializable()]
    public class TC_MethodSymbol
    {
        public string FilePath;

        public TC_Symbol _TC_Symbol;

        public bool IsReadOnly;
        public bool IsInitOnly;
        public NullableAnnotation ReceiverNullableAnnotation;
        public bool IsConditional;
        public NullableAnnotation ReturnNullableAnnotation;
        public MethodKind MethodKind;
        public int Arity;
        public bool IsGenericMethod;
        public bool IsAsync;
        public bool IsVararg;
        public bool IsExtensionMethod;
        public bool HidesBaseMethodsByName;
        public bool ReturnsVoid;
        public bool ReturnsByRef;
        public bool ReturnsByRefReadonly;
        public RefKind RefKind;
        public bool IsCheckedBuiltin;

        public string OriginalDefinition;
        public string ReceiverType;

        public List<TC_ParameterSymbol> _TC_ParameterSymbolList = new List<TC_ParameterSymbol>();
        
    }

    [Serializable()]
    public class TC_ConstructorSymbol
    {
        public string FilePath;
        public string ClassName;
    }

    [Serializable()]
    public class TC_DestructorSymbol
    {
        public string FilePath;
        public string ClassName;
    }

    [Serializable()]
    public class TC_PropertySymbol
    {
        public string FilePath;
        public string ClassName;
        public string PropertyName;
    }

    // Microsoft.CodeAnalysis.IParameterSymbol を継承すると、シリアライズ出来ないエラーが出るので、シリアライズ可能な独自のクラスを設ける。
    // ToDo: IParameterSymbol の全項目を網羅出来てない。
    [Serializable()]
    public class TC_ParameterSymbol
    {
        public TC_Symbol _TC_Symbol;

        public bool HasExplicitDefaultValue;
        public bool IsDiscard;
        public bool IsOptional;
        public bool IsParams;
        public bool IsThis;
        public NullableAnnotation NullableAnnotation;
        public int Ordinal;
        public bool OriginalDefinition;
        public bool RefCustomModifiers;
        public RefKind RefKind;
        public TypeKind Type;
    }

    // Microsoft.CodeAnalysis.ISymbol を継承すると、シリアライズ出来ないエラーが出るので、シリアライズ可能な独自のクラスを設ける。
    // ToDo:ISymbolの全項目を網羅出来てない。
    [Serializable()]
    public class TC_Symbol
    {
        public Accessibility DeclaredAccessibility;
        public bool CanBeReferencedByName;
        public bool IsImplicitlyDeclared;
        public bool IsExtern;
        public bool IsSealed;
        public bool IsAbstract;
        public bool IsOverride;
        public bool IsVirtual;
        public bool IsStatic;
        public bool IsDefinition;
        public bool HasUnsupportedMetadata;
        public string MetadataName;
        public string Name;
        public string Language;
        public SymbolKind Kind;

        public string ContainingModule;
        public string ContainingNamespace;
        public string ContainingType;
        public string OriginalDefinition;

    }


}
