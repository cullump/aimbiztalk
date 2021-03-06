// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AzureIntegrationMigration.BizTalk.Parse.Resources {
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
    internal class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AzureIntegrationMigration.BizTalk.Parse.Resources.ErrorMessages", typeof(ErrorMessages).Assembly);
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
        ///   Looks up a localized string similar to Unable to find the application name in the application definition file &apos;{0}&apos;..
        /// </summary>
        internal static string ApplicationNameNotFound {
            get {
                return ResourceManager.GetString("ApplicationNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An application with the name &apos;{0}&apos; already exists..
        /// </summary>
        internal static string DuplicateApplicationFound {
            get {
                return ResourceManager.GetString("DuplicateApplicationFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred parsing the filter expression for Send Port Group &apos;{0}&apos; in application &apos;{1}&apos;.  Details: {2}.
        /// </summary>
        internal static string ErrorParsingDistributionListFilter {
            get {
                return ResourceManager.GetString("ErrorParsingDistributionListFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred parsing the ODX for Orchestration &apos;{0}&apos; in application &apos;{1}&apos;.  Details: {2}.
        /// </summary>
        internal static string ErrorParsingMetaModel {
            get {
                return ResourceManager.GetString("ErrorParsingMetaModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred parsing the XML for Pipeline &apos;{0}&apos; in application &apos;{1}&apos;.  Details: {2}.
        /// </summary>
        internal static string ErrorParsingPipelineDocument {
            get {
                return ResourceManager.GetString("ErrorParsingPipelineDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred parsing the receive location &apos;{0}&apos; and its &apos;{1}&apos; pipeline data expression in application &apos;{2}&apos;.  Details: {3}.
        /// </summary>
        internal static string ErrorParsingReceiveLocationPipelineData {
            get {
                return ResourceManager.GetString("ErrorParsingReceiveLocationPipelineData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred parsing the receive port &apos;{0}&apos; and its &apos;{1}&apos; pipeline data expression in application &apos;{2}&apos;.  Details: {3}.
        /// </summary>
        internal static string ErrorParsingReceivePortPipelineData {
            get {
                return ResourceManager.GetString("ErrorParsingReceivePortPipelineData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error parsing schema &apos;{0}&apos; in application &apos;{1}&apos;.  Details: {2}.
        /// </summary>
        internal static string ErrorParsingSchemaXml {
            get {
                return ResourceManager.GetString("ErrorParsingSchemaXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred parsing the Send Port &apos;{0}&apos; in application &apos;{1}&apos;.  Details: {2}.
        /// </summary>
        internal static string ErrorParsingSendPort {
            get {
                return ResourceManager.GetString("ErrorParsingSendPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred parsing the send port &apos;{0}&apos; and its &apos;{1}&apos; pipeline data expression in application &apos;{2}&apos;.  Details: {3}.
        /// </summary>
        internal static string ErrorParsingSendPortPipelineData {
            get {
                return ResourceManager.GetString("ErrorParsingSendPortPipelineData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred reading the application definition file for application &apos;{0}&apos;. Details: {1}.
        /// </summary>
        internal static string ErrorReadingApplicationDefinition {
            get {
                return ResourceManager.GetString("ErrorReadingApplicationDefinition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred reading application from application definition file &apos;{0}&apos;. Details: {1}.
        /// </summary>
        internal static string ErrorReadingApplicationFromAdf {
            get {
                return ResourceManager.GetString("ErrorReadingApplicationFromAdf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred reading the binding file for application &apos;{0}&apos;. Details: {1}.
        /// </summary>
        internal static string ErrorReadingBindingInfo {
            get {
                return ResourceManager.GetString("ErrorReadingBindingInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error parsing schema &apos;{0}&apos; in application &apos;{1}&apos;.  Details: The schema XML is empty..
        /// </summary>
        internal static string ErrorSchemaXmlEmpty {
            get {
                return ResourceManager.GetString("ErrorSchemaXmlEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No module refs were found in the bindings XML file &apos;{0}&apos;..
        /// </summary>
        internal static string NoModuleRefsFound {
            get {
                return ResourceManager.GetString("NoModuleRefsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find the module in the orchestration metamodel for the orchestration &apos;{0}&apos;..
        /// </summary>
        internal static string UnableToFindModuleInOrchestrationModel {
            get {
                return ResourceManager.GetString("UnableToFindModuleInOrchestrationModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find a resource of type &apos;{0}&apos; in resource definition &apos;{1}&apos;..
        /// </summary>
        internal static string UnableToFindResource {
            get {
                return ResourceManager.GetString("UnableToFindResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An expected resource definition of type &apos;{0}&apos; with key &apos;{1}&apos; could not be found..
        /// </summary>
        internal static string UnableToFindResourceDefinition {
            get {
                return ResourceManager.GetString("UnableToFindResourceDefinition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find the service declaration in the orchestration model for the orchestration &apos;{0}&apos;..
        /// </summary>
        internal static string UnableToFindServiceDeclarationInOrchestrationModel {
            get {
                return ResourceManager.GetString("UnableToFindServiceDeclarationInOrchestrationModel", resourceCulture);
            }
        }
    }
}
