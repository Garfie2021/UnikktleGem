using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.CodeAnalysis.MSBuild;
using System.Windows.Forms;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;

namespace UnikktleGemCodeAnalyzer
{
    public static class DeclaredSymbolConvert
    {
        public static TC_NamespaceSymbol NamespaceSymbol(INamespaceSymbol symbol)
        {
            return new TC_NamespaceSymbol()
            {
                // TC_Symbolメンバ
                _TC_Symbol = Symbol(symbol),

                // TC_NamespaceSymbolメンバ
                IsGlobalNamespace = symbol.IsGlobalNamespace,
                NamespaceKind = symbol.NamespaceKind,

            };
        }

        public static TC_NamedTypeSymbol NamedTypeSymbol(INamedTypeSymbol symbol)
        {
            return new TC_NamedTypeSymbol()
            {
                // TC_Symbolメンバ
                _TC_Symbol = Symbol(symbol),

                // TC_NamedTypeSymbolメンバ
                MightContainExtensionMethods = symbol.MightContainExtensionMethods,
                IsSerializable = symbol.IsSerializable,
                IsComImport = symbol.IsComImport,
                IsImplicitClass = symbol.IsImplicitClass,
                IsScriptClass = symbol.IsScriptClass,
                IsUnboundGenericType = symbol.IsUnboundGenericType,
                IsGenericType = symbol.IsGenericType,
                Arity = symbol.Arity,
            };
        }

        public static TC_MethodSymbol MethodSymbol(string filePath, IMethodSymbol symbol)
        {
            var tcMethodSymbol = new TC_MethodSymbol()
            {
                FilePath = filePath,

                // TC_Symbolメンバ
                _TC_Symbol = Symbol(symbol),

                // TC_MethodSymbolメンバ
                IsReadOnly = symbol.IsReadOnly,
                IsInitOnly = symbol.IsInitOnly,
                ReceiverNullableAnnotation = symbol.ReceiverNullableAnnotation,
                IsConditional = symbol.IsConditional,
                ReturnNullableAnnotation = symbol.ReturnNullableAnnotation,
                MethodKind = symbol.MethodKind,
                Arity = symbol.Arity,
                IsGenericMethod = symbol.IsGenericMethod,
                IsAsync = symbol.IsAsync,
                IsVararg = symbol.IsVararg,
                IsExtensionMethod = symbol.IsExtensionMethod,
                HidesBaseMethodsByName = symbol.HidesBaseMethodsByName,
                ReturnsVoid = symbol.ReturnsVoid,
                ReturnsByRef = symbol.ReturnsByRef,
                ReturnsByRefReadonly = symbol.ReturnsByRefReadonly,
                RefKind = symbol.RefKind,
                IsCheckedBuiltin = symbol.IsCheckedBuiltin,

                OriginalDefinition = symbol.OriginalDefinition.ToDisplayString(),
                ReceiverType = symbol.ReceiverType.ToDisplayString(),
            };

            foreach (var parameter in symbol.Parameters)
            {
                tcMethodSymbol._TC_ParameterSymbolList.Add(new TC_ParameterSymbol()
                {
                    // TC_Symbolメンバ
                    _TC_Symbol = Symbol(parameter),

                    // TC_ParameterSymbolメンバ
                    HasExplicitDefaultValue = parameter.HasExplicitDefaultValue,
                    IsDiscard = parameter.IsDiscard,
                    IsOptional = parameter.IsOptional,
                    IsParams = parameter.IsParams,
                    IsThis = parameter.IsThis,
                    NullableAnnotation = parameter.NullableAnnotation,
                    Ordinal = parameter.Ordinal,
                    //OriginalDefinition = parameter.OriginalDefinition,
                    //RefCustomModifiers = parameter.RefCustomModifiers,
                    RefKind = parameter.RefKind,
                    Type = parameter.Type.TypeKind,
                });
            }

            return tcMethodSymbol;
        }

        public static TC_Symbol Symbol(ISymbol symbol)
        {
            return new TC_Symbol()
            {
                DeclaredAccessibility = symbol.DeclaredAccessibility,
                CanBeReferencedByName = symbol.CanBeReferencedByName,
                IsImplicitlyDeclared = symbol.IsImplicitlyDeclared,
                IsExtern = symbol.IsExtern,
                IsSealed = symbol.IsSealed,
                IsAbstract = symbol.IsAbstract,
                IsOverride = symbol.IsOverride,
                IsVirtual = symbol.IsVirtual,
                IsStatic = symbol.IsStatic,
                IsDefinition = symbol.IsDefinition,
                HasUnsupportedMetadata = symbol.HasUnsupportedMetadata,
                MetadataName = symbol.MetadataName,
                Name = symbol.Name,
                Language = symbol.Language,
                Kind = symbol.Kind,

                ContainingModule = symbol.ContainingModule.ToDisplayString(),
                ContainingNamespace = symbol.ContainingNamespace.ToDisplayString(),
                ContainingType = (symbol.ContainingType == null ? "" : symbol.ContainingType.ToDisplayString()),
                OriginalDefinition = symbol.OriginalDefinition.ToDisplayString(),

                //UnderlyingSymbol = symbol.UnderlyingSymbol.ToDisplayString(),
                //_lazyReturnType = symbol._lazyReturnType.ToDisplayString(),

            };
        }

    }
}
