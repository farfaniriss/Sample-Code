﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18046
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.WcfUnit.Library {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.WcfUnit.Library.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to There were errors during code compilation for the service contract..
        /// </summary>
        internal static string CompileErrors {
            get {
                return ResourceManager.GetString("CompileErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration file {0} does not exist..
        /// </summary>
        internal static string Configuration_FileNotFound {
            get {
                return ResourceManager.GetString("Configuration_FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} is not a valid configuration file..
        /// </summary>
        internal static string Configuration_InvalidFile {
            get {
                return ResourceManager.GetString("Configuration_InvalidFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The assembly list is null so cannot remove an entry.
        /// </summary>
        internal static string ConfigurationX_CannotRemoveAssemblyFromNullList {
            get {
                return ResourceManager.GetString("ConfigurationX_CannotRemoveAssemblyFromNullList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is not entry with index {0} is the assembly list.
        /// </summary>
        internal static string ConfigurationX_CannotRemoveAssemblyIndex {
            get {
                return ResourceManager.GetString("ConfigurationX_CannotRemoveAssemblyIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not load the configured type &quot;{0}&quot;. The error is: {1}.
        /// </summary>
        internal static string ConfiguredTypeLoadError {
            get {
                return ResourceManager.GetString("ConfiguredTypeLoadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configured type &quot;{0}&quot; does not implement {1}..
        /// </summary>
        internal static string ConfiguredTypeMismatch {
            get {
                return ResourceManager.GetString("ConfiguredTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contract method does not have a declaring type.
        /// </summary>
        internal static string DeserializerContractMethodNoDeclaringType {
            get {
                return ResourceManager.GetString("DeserializerContractMethodNoDeclaringType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The tool does not support certain types of configurations for message contracts. It does not support service side message logs with memory streams..
        /// </summary>
        internal static string DeserializerMessageContractNotSupported {
            get {
                return ResourceManager.GetString("DeserializerMessageContractNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate action found for {0}.
        /// </summary>
        internal static string DuplicateAction {
            get {
                return ResourceManager.GetString("DuplicateAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message log file did not contain any usable data. Please make sure that LogMessagesAtServiceLevel and LogEntireMessage are set.
        /// </summary>
        internal static string NoDataInTraceFile {
            get {
                return ResourceManager.GetString("NoDataInTraceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can only handle single-dimensional arrays.
        /// </summary>
        internal static string ObjectGenerator_ArrayRank {
            get {
                return ResourceManager.GetString("ObjectGenerator_ArrayRank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected 2 generic parameters for type {0}, but found {1}.
        /// </summary>
        internal static string ObjectGenerator_DictionaryParamsLength {
            get {
                return ResourceManager.GetString("ObjectGenerator_DictionaryParamsLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only generic collections with one type parameter are supported. Type {0} does not have one type parameter..
        /// </summary>
        internal static string ObjectGenerator_GenericCollectionOneTypeParameterExpected {
            get {
                return ResourceManager.GetString("ObjectGenerator_GenericCollectionOneTypeParameterExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object graph is nested too deeply, make sure there are no cycles in it. The maximum nesting level allowed is {0}.
        /// </summary>
        internal static string ObjectGenerator_NestingLevel {
            get {
                return ResourceManager.GetString("ObjectGenerator_NestingLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data or message contract attribute expected on type {0}.
        /// </summary>
        internal static string ObjectGenerator_NoDataOrMessageContract {
            get {
                return ResourceManager.GetString("ObjectGenerator_NoDataOrMessageContract", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected object of type {0} to be an array so that it can be matched to the collection type {1}.
        /// </summary>
        internal static string ObjectGenerator_ObjectNotAnArray {
            get {
                return ResourceManager.GetString("ObjectGenerator_ObjectNotAnArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected object of type {0}, but was of type {1}.
        /// </summary>
        internal static string ObjectGenerator_ObjectTypeMismatch {
            get {
                return ResourceManager.GetString("ObjectGenerator_ObjectTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected stream object derived from type {0}, but was of type {1}.
        /// </summary>
        internal static string ObjectGenerator_StreamObjectTypeMismatch1 {
            get {
                return ResourceManager.GetString("ObjectGenerator_StreamObjectTypeMismatch1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message log file {0} does not exist..
        /// </summary>
        internal static string Parser_FileNotFound {
            get {
                return ResourceManager.GetString("Parser_FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [FILTERED OUT].
        /// </summary>
        internal static string Parser_FilteredOut {
            get {
                return ResourceManager.GetString("Parser_FilteredOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} is not a valid message log file..
        /// </summary>
        internal static string Parser_InvalidMessageLogFile {
            get {
                return ResourceManager.GetString("Parser_InvalidMessageLogFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  [OK].
        /// </summary>
        internal static string Parser_OK {
            get {
                return ResourceManager.GetString("Parser_OK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parsed message with action {0}.
        /// </summary>
        internal static string Parser_ParsedMessage {
            get {
                return ResourceManager.GetString("Parser_ParsedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setup has already been called..
        /// </summary>
        internal static string Parser_SetupAlreadyDone {
            get {
                return ResourceManager.GetString("Parser_SetupAlreadyDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setup must have been called first..
        /// </summary>
        internal static string Parser_SetupNotCalled {
            get {
                return ResourceManager.GetString("Parser_SetupNotCalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} is a trace file, a message log file is required..
        /// </summary>
        internal static string Parser_TraceFileFound {
            get {
                return ResourceManager.GetString("Parser_TraceFileFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find method for SOAP action &quot;{0}&quot;, check that the right proxy assemblies have been supplied..
        /// </summary>
        internal static string Processor_MethodNotFound {
            get {
                return ResourceManager.GetString("Processor_MethodNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The assembly {0} does not exist..
        /// </summary>
        internal static string ProxyManager_FileNotFound {
            get {
                return ResourceManager.GetString("ProxyManager_FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} is not a valid assembly..
        /// </summary>
        internal static string ProxyManager_InvalidAssembly {
            get {
                return ResourceManager.GetString("ProxyManager_InvalidAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access denied when trying to modify the configuration file..
        /// </summary>
        internal static string SRMAccessDenied {
            get {
                return ResourceManager.GetString("SRMAccessDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The executable &apos;{0}&apos; was not found.
        /// </summary>
        internal static string SRMExeNotFound {
            get {
                return ResourceManager.GetString("SRMExeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected SOAP namespace {0} on soap envelope.
        /// </summary>
        internal static string UnexpectedSoapNamespace {
            get {
                return ResourceManager.GetString("UnexpectedSoapNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error.
        /// </summary>
        internal static string UnknownError {
            get {
                return ResourceManager.GetString("UnknownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following line may need to be customised to select the appropriate binding from the configuration file.
        /// </summary>
        internal static string UTGenerator_ProxyConstructionComment {
            get {
                return ResourceManager.GetString("UTGenerator_ProxyConstructionComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified scenario name {0} is the same as one of the operations called, please use a different scenario name..
        /// </summary>
        internal static string UTGenerator_ScenarioNameAndMethodNameConflict {
            get {
                return ResourceManager.GetString("UTGenerator_ScenarioNameAndMethodNameConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} is not supported..
        /// </summary>
        internal static string UTGenerator_TypeNotSupported {
            get {
                return ResourceManager.GetString("UTGenerator_TypeNotSupported", resourceCulture);
            }
        }
    }
}