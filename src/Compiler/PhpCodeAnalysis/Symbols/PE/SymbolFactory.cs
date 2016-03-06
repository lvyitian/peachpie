﻿using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cci = Microsoft.Cci;

namespace Pchp.CodeAnalysis.Symbols
{
    internal sealed class SymbolFactory : SymbolFactory<PEModuleSymbol, TypeSymbol>
    {
        internal static readonly SymbolFactory Instance = new SymbolFactory();

        internal override TypeSymbol GetMDArrayTypeSymbol(PEModuleSymbol moduleSymbol, int rank, TypeSymbol elementType, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers,
                                                          ImmutableArray<int> sizes, ImmutableArray<int> lowerBounds)
        {
            if (elementType is UnsupportedMetadataTypeSymbol)
            {
                return elementType;
            }

            throw new NotImplementedException();
            //return ArrayTypeSymbol.CreateMDArray(moduleSymbol.ContainingAssembly, elementType, rank, sizes, lowerBounds, CSharpCustomModifier.Convert(customModifiers));
        }

        internal override TypeSymbol GetByRefReturnTypeSymbol(PEModuleSymbol moduleSymbol, TypeSymbol referencedType, ushort countOfCustomModifiersPrecedingByRef)
        {
            throw new NotImplementedException();
            //return new ByRefReturnErrorTypeSymbol(referencedType, countOfCustomModifiersPrecedingByRef);
        }

        internal override TypeSymbol GetSpecialType(PEModuleSymbol moduleSymbol, SpecialType specialType)
        {
            return moduleSymbol.ContainingAssembly.GetSpecialType(specialType);
        }

        internal override TypeSymbol GetSystemTypeSymbol(PEModuleSymbol moduleSymbol)
        {
            throw new NotImplementedException();
            //return moduleSymbol.SystemTypeSymbol;
        }

        internal override TypeSymbol MakePointerTypeSymbol(PEModuleSymbol moduleSymbol, TypeSymbol type, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers)
        {
            if (type is UnsupportedMetadataTypeSymbol)
            {
                return type;
            }

            throw new NotImplementedException();
            //return new PointerTypeSymbol(type, CSharpCustomModifier.Convert(customModifiers));
        }

        internal override TypeSymbol GetEnumUnderlyingType(PEModuleSymbol moduleSymbol, TypeSymbol type)
        {
            throw new NotImplementedException();
            //return type.GetEnumUnderlyingType();
        }

        internal override Cci.PrimitiveTypeCode GetPrimitiveTypeCode(PEModuleSymbol moduleSymbol, TypeSymbol type)
        {
            throw new NotImplementedException();
            //return type.PrimitiveTypeCode;
        }

        internal override bool IsVolatileModifierType(PEModuleSymbol moduleSymbol, TypeSymbol type)
        {
            return type.SpecialType == SpecialType.System_Runtime_CompilerServices_IsVolatile;
        }

        internal override TypeSymbol GetSZArrayTypeSymbol(PEModuleSymbol moduleSymbol, TypeSymbol elementType, ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers)
        {
            if (elementType is UnsupportedMetadataTypeSymbol)
            {
                return elementType;
            }

            throw new NotImplementedException();
            //return ArrayTypeSymbol.CreateSZArray(moduleSymbol.ContainingAssembly, elementType, CSharpCustomModifier.Convert(customModifiers));
        }

        internal override TypeSymbol GetUnsupportedMetadataTypeSymbol(PEModuleSymbol moduleSymbol, BadImageFormatException exception)
        {
            return new UnsupportedMetadataTypeSymbol(exception);
        }

        internal override TypeSymbol SubstituteTypeParameters(
            PEModuleSymbol moduleSymbol,
            TypeSymbol genericTypeDef,
            ImmutableArray<KeyValuePair<TypeSymbol, ImmutableArray<ModifierInfo<TypeSymbol>>>> arguments,
            ImmutableArray<bool> refersToNoPiaLocalType)
        {
            if (genericTypeDef is UnsupportedMetadataTypeSymbol)
            {
                return genericTypeDef;
            }

            // Let's return unsupported metadata type if any argument is unsupported metadata type 
            foreach (var arg in arguments)
            {
                if (arg.Key.Kind == SymbolKind.ErrorType &&
                    arg.Key is UnsupportedMetadataTypeSymbol)
                {
                    return new UnsupportedMetadataTypeSymbol();
                }
            }

            NamedTypeSymbol genericType = (NamedTypeSymbol)genericTypeDef;

            throw new NotImplementedException();
            //// See if it is or its enclosing type is a non-interface closed over NoPia local types. 
            //ImmutableArray<AssemblySymbol> linkedAssemblies = moduleSymbol.ContainingAssembly.GetLinkedReferencedAssemblies();

            //bool noPiaIllegalGenericInstantiation = false;

            //if (!linkedAssemblies.IsDefaultOrEmpty || moduleSymbol.Module.ContainsNoPiaLocalTypes())
            //{
            //    NamedTypeSymbol typeToCheck = genericType;
            //    int argumentIndex = refersToNoPiaLocalType.Length - 1;

            //    do
            //    {
            //        if (!typeToCheck.IsInterface)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            argumentIndex -= typeToCheck.Arity;
            //        }

            //        typeToCheck = typeToCheck.ContainingType;
            //    }
            //    while ((object)typeToCheck != null);

            //    for (int i = argumentIndex; i >= 0; i--)
            //    {
            //        if (refersToNoPiaLocalType[i] ||
            //            (!linkedAssemblies.IsDefaultOrEmpty &&
            //            MetadataDecoder.IsOrClosedOverATypeFromAssemblies(arguments[i].Key, linkedAssemblies)))
            //        {
            //            noPiaIllegalGenericInstantiation = true;
            //            break;
            //        }
            //    }
            //}

            //// Collect generic parameters for the type and its containers in the order
            //// that matches passed in arguments, i.e. sorted by the nesting.
            //ImmutableArray<TypeParameterSymbol> typeParameters = genericType.GetAllTypeParameters();
            //Debug.Assert(typeParameters.Length > 0);

            //if (typeParameters.Length != arguments.Length)
            //{
            //    return new UnsupportedMetadataTypeSymbol();
            //}

            //TypeMap substitution = new TypeMap(typeParameters, arguments.SelectAsArray(arg => new TypeWithModifiers(arg.Key, CSharpCustomModifier.Convert(arg.Value))));

            //NamedTypeSymbol constructedType = substitution.SubstituteNamedType(genericType);

            //if (noPiaIllegalGenericInstantiation)
            //{
            //    constructedType = new NoPiaIllegalGenericInstantiationSymbol(moduleSymbol, constructedType);
            //}

            //return constructedType;
        }

        internal override TypeSymbol MakeUnboundIfGeneric(PEModuleSymbol moduleSymbol, TypeSymbol type)
        {
            throw new NotImplementedException();
            //var namedType = type as NamedTypeSymbol;
            //return ((object)namedType != null && namedType.IsGenericType) ? namedType.AsUnboundGenericType() : type;
        }
    }
}
