﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Peachpie.CodeAnalysis.Errors {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ErrorStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Peachpie.CodeAnalysis.Errors.ErrorStrings", typeof(ErrorStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use spl_autoload_register() instead..
        /// </summary>
        internal static string AutoloadDeprecatedMessage {
            get {
                return ResourceManager.GetString("AutoloadDeprecatedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid assembly name: {0}.
        /// </summary>
        internal static string ERR_BadAssemblyName {
            get {
                return ResourceManager.GetString("ERR_BadAssemblyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid &apos;{0}&apos; value: &apos;{1}&apos;..
        /// </summary>
        internal static string ERR_BadCompilationOptionValue {
            get {
                return ResourceManager.GetString("ERR_BadCompilationOptionValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided documentation mode is unsupported or invalid: &apos;{0}&apos;..
        /// </summary>
        internal static string ERR_BadDocumentationMode {
            get {
                return ResourceManager.GetString("ERR_BadDocumentationMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided source code kind is unsupported or invalid: &apos;{0}&apos;.
        /// </summary>
        internal static string ERR_BadSourceCodeKind {
            get {
                return ResourceManager.GetString("ERR_BadSourceCodeKind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized option: &apos;{0}&apos;.
        /// </summary>
        internal static string ERR_BadSwitch {
            get {
                return ResourceManager.GetString("ERR_BadSwitch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot re-assign $this.
        /// </summary>
        internal static string ERR_CannotAssignToThis {
            get {
                return ResourceManager.GetString("ERR_CannotAssignToThis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}() cannot declare a return type.
        /// </summary>
        internal static string ERR_CannotDeclareReturnType {
            get {
                return ResourceManager.GetString("ERR_CannotDeclareReturnType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /embed switch is only supported when emitting Portable PDB (/debug:portable or /debug:embedded)..
        /// </summary>
        internal static string ERR_CannotEmbedWithoutPdb {
            get {
                return ResourceManager.GetString("ERR_CannotEmbedWithoutPdb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class {0} cannot extend from {1} {2}.
        /// </summary>
        internal static string ERR_CannotExtendFrom {
            get {
                return ResourceManager.GetString("ERR_CannotExtendFrom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot implement {1} - it is not an interface.
        /// </summary>
        internal static string ERR_CannotImplementNonInterface {
            get {
                return ResourceManager.GetString("ERR_CannotImplementNonInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot instantiate {0} {1}.
        /// </summary>
        internal static string ERR_CannotInstantiateType {
            get {
                return ResourceManager.GetString("ERR_CannotInstantiateType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot use {1} - it is not a trait.
        /// </summary>
        internal static string ERR_CannotUseNonTrait {
            get {
                return ResourceManager.GetString("ERR_CannotUseNonTrait", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot open &apos;{0}&apos; for writing -- &apos;{1}&apos;.
        /// </summary>
        internal static string ERR_CantOpenFileWrite {
            get {
                return ResourceManager.GetString("ERR_CantOpenFileWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error reading resource &apos;{0}&apos; -- &apos;{1}&apos;.
        /// </summary>
        internal static string ERR_CantReadResource {
            get {
                return ResourceManager.GetString("ERR_CantReadResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Circular base class dependency involving &apos;{0}&apos; and &apos;{1}&apos;.
        /// </summary>
        internal static string ERR_CircularBase {
            get {
                return ResourceManager.GetString("ERR_CircularBase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compilation cancelled by user.
        /// </summary>
        internal static string ERR_CompileCancelled {
            get {
                return ResourceManager.GetString("ERR_CompileCancelled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default value for parameter ${0} with a {1} type can only be {1} or NULL, {2} type given.
        /// </summary>
        internal static string ERR_DefaultParameterValueTypeMismatch {
            get {
                return ResourceManager.GetString("ERR_DefaultParameterValueTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot emit debug information for a source text without encoding..
        /// </summary>
        internal static string ERR_EncodinglessSyntaxTree {
            get {
                return ResourceManager.GetString("ERR_EncodinglessSyntaxTree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot update &apos;{0}&apos;; attribute &apos;{1}&apos; is missing..
        /// </summary>
        internal static string ERR_EncUpdateFailedMissingAttribute {
            get {
                return ResourceManager.GetString("ERR_EncUpdateFailedMissingAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error opening assembly file &apos;{0}&apos;: {1}.
        /// </summary>
        internal static string ERR_ErrorOpeningAssemblyFile {
            get {
                return ResourceManager.GetString("ERR_ErrorOpeningAssemblyFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source file &apos;{0}&apos; could not be found..
        /// </summary>
        internal static string ERR_FileNotFound {
            get {
                return ResourceManager.GetString("ERR_FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use the final modifier on an abstract class.
        /// </summary>
        internal static string ERR_FinalAbstractClassDeclared {
            get {
                return ResourceManager.GetString("ERR_FinalAbstractClassDeclared", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Constant expression contains invalid operations.
        /// </summary>
        internal static string ERR_InvalidConstantExpression {
            get {
                return ResourceManager.GetString("ERR_InvalidConstantExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to read debug information of method &apos;{0}&apos; (token 0x{1:X8}) from assembly &apos;{2}&apos;.
        /// </summary>
        internal static string ERR_InvalidDebugInfo {
            get {
                return ResourceManager.GetString("ERR_InvalidDebugInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Function name must be a string, {0} given.
        /// </summary>
        internal static string ERR_InvalidFunctionName {
            get {
                return ResourceManager.GetString("ERR_InvalidFunctionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid hash algorithm name: &apos;{0}&apos;.
        /// </summary>
        internal static string ERR_InvalidHashAlgorithmName {
            get {
                return ResourceManager.GetString("ERR_InvalidHashAlgorithmName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid instrumentation kind: {0}.
        /// </summary>
        internal static string ERR_InvalidInstrumentationKind {
            get {
                return ResourceManager.GetString("ERR_InvalidInstrumentationKind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metadata file &apos;{0}&apos; could not be found.
        /// </summary>
        internal static string ERR_MetadataFileNotFound {
            get {
                return ResourceManager.GetString("ERR_MetadataFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call to a member function {0}() on {1}.
        /// </summary>
        internal static string ERR_MethodCalledOnNonObject {
            get {
                return ResourceManager.GetString("ERR_MethodCalledOnNonObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to emit module &apos;{0}&apos;..
        /// </summary>
        internal static string ERR_ModuleEmitFailure {
            get {
                return ResourceManager.GetString("ERR_ModuleEmitFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} {1}() must take exactly {2} arguments.
        /// </summary>
        internal static string ERR_MustTakeArgs {
            get {
                return ResourceManager.GetString("ERR_MustTakeArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compilation options &apos;{0}&apos; and &apos;{1}&apos; can&apos;t both be specified at the same time..
        /// </summary>
        internal static string ERR_MutuallyExclusiveOptions {
            get {
                return ResourceManager.GetString("ERR_MutuallyExclusiveOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; not in the &apos;loop&apos; or &apos;switch&apos; context.
        /// </summary>
        internal static string ERR_NeedsLoopOrSwitch {
            get {
                return ResourceManager.GetString("ERR_NeedsLoopOrSwitch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No overload for method {0} can be called..
        /// </summary>
        internal static string ERR_NoMatchingOverload {
            get {
                return ResourceManager.GetString("ERR_NoMatchingOverload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source file &apos;{0}&apos; could not be opened -- {1}.
        /// </summary>
        internal static string ERR_NoSourceFile {
            get {
                return ResourceManager.GetString("ERR_NoSourceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is currently not supported by PeachPie..
        /// </summary>
        internal static string ERR_NotYetImplemented {
            get {
                return ResourceManager.GetString("ERR_NotYetImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Option &apos;{0}&apos; must be an absolute path..
        /// </summary>
        internal static string ERR_OptionMustBeAbsolutePath {
            get {
                return ResourceManager.GetString("ERR_OptionMustBeAbsolutePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not write to output file &apos;{0}&apos; -- &apos;{1}&apos;.
        /// </summary>
        internal static string ERR_OutputWriteFailed {
            get {
                return ResourceManager.GetString("ERR_OutputWriteFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failure writing debug information: {0}.
        /// </summary>
        internal static string ERR_PdbWritingFailed {
            get {
                return ResourceManager.GetString("ERR_PdbWritingFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while writing the output file: {0}..
        /// </summary>
        internal static string ERR_PeWritingFailure {
            get {
                return ResourceManager.GetString("ERR_PeWritingFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use positional argument after argument unpacking.
        /// </summary>
        internal static string ERR_PositionalArgAfterUnpacking {
            get {
                return ResourceManager.GetString("ERR_PositionalArgAfterUnpacking", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use of primitive type &apos;{0}&apos; is misused.
        /// </summary>
        internal static string ERR_PrimitiveTypeNameMisused {
            get {
                return ResourceManager.GetString("ERR_PrimitiveTypeNameMisused", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access level to {0}::${1} must be {2} (as in class {3}) or weaker.
        /// </summary>
        internal static string ERR_PropertyAccessibilityError {
            get {
                return ResourceManager.GetString("ERR_PropertyAccessibilityError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot set read-only property {0}::${1}.
        /// </summary>
        internal static string ERR_ReadOnlyPropertyWritten {
            get {
                return ResourceManager.GetString("ERR_ReadOnlyPropertyWritten", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource identifier &apos;{0}&apos; has already been used in this assembly.
        /// </summary>
        internal static string ERR_ResourceNotUnique {
            get {
                return ResourceManager.GetString("ERR_ResourceNotUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Startup object matching &apos;{0}&apos; could not be resolved.
        /// </summary>
        internal static string ERR_StartupObjectNotFound {
            get {
                return ResourceManager.GetString("ERR_StartupObjectNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing value for &apos;{0}&apos; option.
        /// </summary>
        internal static string ERR_SwitchNeedsValue {
            get {
                return ResourceManager.GetString("ERR_SwitchNeedsValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using $this when not in object context.
        /// </summary>
        internal static string ERR_ThisOutOfObjectContext {
            get {
                return ResourceManager.GetString("ERR_ThisOutOfObjectContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals..
        /// </summary>
        internal static string ERR_TooManyUserStrings {
            get {
                return ResourceManager.GetString("ERR_TooManyUserStrings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type name &apos;{0}&apos; could not be resolved..
        /// </summary>
        internal static string ERR_TypeNameCannotBeResolved {
            get {
                return ResourceManager.GetString("ERR_TypeNameCannotBeResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; cannot be declared..
        /// </summary>
        internal static string ERR_UnknownTypeDependencies {
            get {
                return ResourceManager.GetString("ERR_UnknownTypeDependencies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value of type &apos;{0}&apos; cannot be passed by reference.
        /// </summary>
        internal static string ERR_ValueOfTypeCannotBeAliased {
            get {
                return ResourceManager.GetString("ERR_ValueOfTypeCannotBeAliased", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only the last parameter can be variadic.
        /// </summary>
        internal static string ERR_VariadicParameterNotLast {
            get {
                return ResourceManager.GetString("ERR_VariadicParameterNotLast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A void function must not return a value.
        /// </summary>
        internal static string ERR_VoidFunctionCannotReturnValue {
            get {
                return ResourceManager.GetString("ERR_VoidFunctionCannotReturnValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code page &apos;{0}&apos; is invalid or not installed.
        /// </summary>
        internal static string FTL_BadCodepage {
            get {
                return ResourceManager.GetString("FTL_BadCodepage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File name &apos;{0}&apos; is empty, contains invalid characters, has a drive specification without an absolute path, or is too long.
        /// </summary>
        internal static string FTL_InvalidInputFileName {
            get {
                return ResourceManager.GetString("FTL_InvalidInputFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use of &apos;__destruct&apos; is discouraged. Garbage collection behavior is a subject to change..
        /// </summary>
        internal static string INF_DestructDiscouraged {
            get {
                return ResourceManager.GetString("INF_DestructDiscouraged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use of &apos;eval()&apos; is discouraged. Construct allows execution of arbitrary code and is subject to performance and memory overhead..
        /// </summary>
        internal static string INF_EvalDiscouraged {
            get {
                return ResourceManager.GetString("INF_EvalDiscouraged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overriden function name &apos;{0}&apos; does not match it&apos;s parent name &apos;{1}&apos;, letter casing mismatch..
        /// </summary>
        internal static string INF_OverrideNameCaseMismatch {
            get {
                return ResourceManager.GetString("INF_OverrideNameCaseMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cast is redundant..
        /// </summary>
        internal static string INF_RedundantCast {
            get {
                return ResourceManager.GetString("INF_RedundantCast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name &apos;{0}&apos; does not match the expected name &apos;{1}&apos;, letter casing mismatch..
        /// </summary>
        internal static string INF_TypeNameCaseMismatch {
            get {
                return ResourceManager.GetString("INF_TypeNameCaseMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The declaration of &apos;{0}&apos; is ambiguous resulting in multiple versions to be compiled. Fix this issue by ensuring every base type is declared just once unconditionally..
        /// </summary>
        internal static string WRN_AmbiguousDeclaration {
            get {
                return ResourceManager.GetString("WRN_AmbiguousDeclaration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument has no value, parameter will be always NULL.
        /// </summary>
        internal static string WRN_ArgumentVoid {
            get {
                return ResourceManager.GetString("WRN_ArgumentVoid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assertion will always fail.
        /// </summary>
        internal static string WRN_AssertAlwaysFail {
            get {
                return ResourceManager.GetString("WRN_AssertAlwaysFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assignment made to same variable; did you mean to assign something else?.
        /// </summary>
        internal static string WRN_AssigningSameVariable {
            get {
                return ResourceManager.GetString("WRN_AssigningSameVariable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script file &apos;{0}&apos; could not be resolved, the script inclusion is unbound..
        /// </summary>
        internal static string WRN_CannotIncludeFile {
            get {
                return ResourceManager.GetString("WRN_CannotIncludeFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cloning of non-object: {0}..
        /// </summary>
        internal static string WRN_CloneNonObject {
            get {
                return ResourceManager.GetString("WRN_CloneNonObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate array key: &apos;{0}&apos;..
        /// </summary>
        internal static string WRN_DuplicateArrayKey {
            get {
                return ResourceManager.GetString("WRN_DuplicateArrayKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expression is not being read. Did you mean to assign it somewhere?.
        /// </summary>
        internal static string WRN_ExpressionNotRead {
            get {
                return ResourceManager.GetString("WRN_ExpressionNotRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value of type {0} assigned to field {1} is incompatible with its PHPDoc type {2}..
        /// </summary>
        internal static string WRN_FieldPhpDocAssignIncompatible {
            get {
                return ResourceManager.GetString("WRN_FieldPhpDocAssignIncompatible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using non-iterable type in foreach: {0}..
        /// </summary>
        internal static string WRN_ForeachNonIterable {
            get {
                return ResourceManager.GetString("WRN_ForeachNonIterable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call to &apos;{0}()&apos; expects {1} argument(s), {2} given..
        /// </summary>
        internal static string WRN_FormatStringWrongArgCount {
            get {
                return ResourceManager.GetString("WRN_FormatStringWrongArgCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid array key type: {0}..
        /// </summary>
        internal static string WRN_InvalidArrayKeyType {
            get {
                return ResourceManager.GetString("WRN_InvalidArrayKeyType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}() expects at least {1} parameter(s), {2} given.
        /// </summary>
        internal static string WRN_MissingArguments {
            get {
                return ResourceManager.GetString("WRN_MissingArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No source files specified.
        /// </summary>
        internal static string WRN_NoSourceFiles {
            get {
                return ResourceManager.GetString("WRN_NoSourceFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} will be ignored, because it is currently not supported by Peachpie..
        /// </summary>
        internal static string WRN_NotYetImplementedIgnored {
            get {
                return ResourceManager.GetString("WRN_NotYetImplementedIgnored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PHPDoc type &apos;{0}&apos; of parameter ${1} is incompatible with its type hint &apos;{2}&apos;..
        /// </summary>
        internal static string WRN_ParamPhpDocTypeHintIncompatible {
            get {
                return ResourceManager.GetString("WRN_ParamPhpDocTypeHintIncompatible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing the call of parent::__construct from {0}::__construct..
        /// </summary>
        internal static string WRN_ParentCtorNotCalled {
            get {
                return ResourceManager.GetString("WRN_ParentCtorNotCalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PCRE pattern parse error: {0} at offset {1}.
        /// </summary>
        internal static string WRN_PCRE_Pattern_Error {
            get {
                return ResourceManager.GetString("WRN_PCRE_Pattern_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using string as the assertion is deprecated.
        /// </summary>
        internal static string WRN_StringAssertionDeprecated {
            get {
                return ResourceManager.GetString("WRN_StringAssertionDeprecated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deprecated: {0} &apos;{1}&apos; has been deprecated. {2}.
        /// </summary>
        internal static string WRN_SymbolDeprecated {
            get {
                return ResourceManager.GetString("WRN_SymbolDeprecated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}() expects {1} parameter(s), {2} given.
        /// </summary>
        internal static string WRN_TooManyArguments {
            get {
                return ResourceManager.GetString("WRN_TooManyArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method {0}::__toString() must return a string value.
        /// </summary>
        internal static string WRN_ToStringMustReturnString {
            get {
                return ResourceManager.GetString("WRN_ToStringMustReturnString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} &apos;{1}&apos; is already defined.
        /// </summary>
        internal static string WRN_TypeNameInUse {
            get {
                return ResourceManager.GetString("WRN_TypeNameInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call to undefined function: &apos;{0}&apos;.
        /// </summary>
        internal static string WRN_UndefinedFunctionCall {
            get {
                return ResourceManager.GetString("WRN_UndefinedFunctionCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call to undefined method: {0}::{1}().
        /// </summary>
        internal static string WRN_UndefinedMethodCall {
            get {
                return ResourceManager.GetString("WRN_UndefinedMethodCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class &apos;{0}&apos; not found.
        /// </summary>
        internal static string WRN_UndefinedType {
            get {
                return ResourceManager.GetString("WRN_UndefinedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Undefined variable: ${0}.
        /// </summary>
        internal static string WRN_UninitializedVariableUse {
            get {
                return ResourceManager.GetString("WRN_UninitializedVariableUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unreachable code detected.
        /// </summary>
        internal static string WRN_UnreachableCode {
            get {
                return ResourceManager.GetString("WRN_UnreachableCode", resourceCulture);
            }
        }
    }
}
