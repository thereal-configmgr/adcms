﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Azure.DataCenterMigration.App {
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
    internal class StringResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Azure.DataCenterMigration.App.StringResources", typeof(StringResources).Assembly);
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
        ///   Looks up a localized string similar to Exception of type {0} occurred : {1}.
        /// </summary>
        internal static string ExceptionOccurred {
            get {
                return ResourceManager.GetString("ExceptionOccurred", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press Any Key To Exit...
        /// </summary>
        internal static string ExitApplicationMessage {
            get {
                return ResourceManager.GetString("ExitApplicationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ---------------------------------------------------------------.
        /// </summary>
        internal static string HelpDash {
            get {
                return ResourceManager.GetString("HelpDash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -DeltaBackOff :  (optional) Delta backoff in seconds for &apos;Exponential Backoff&apos; retry strategy, Default is 90 seconds.
        /// </summary>
        internal static string HelpDeltaBackOff {
            get {
                return ResourceManager.GetString("HelpDeltaBackOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -DestinationCertificateThumbprint : Certificate thumbprint for source subscription. User needs to provide value for either DestinationPublishSettingsFilePath or DestinationCertificateThumbprint for authentiacation.
        /// </summary>
        internal static string HelpDestinationCertificateThumbprint {
            get {
                return ResourceManager.GetString("HelpDestinationCertificateThumbprint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -DestinationDCName : Destination Data Center Name.
        /// </summary>
        internal static string HelpDestinationDCName {
            get {
                return ResourceManager.GetString("HelpDestinationDCName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -DestinationPrefixName : Destination Prefix Name.
        /// </summary>
        internal static string HelpDestinationPrefixName {
            get {
                return ResourceManager.GetString("HelpDestinationPrefixName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -DestinationPublishSettingsFilePath : Destination PublishSettings file path.
        /// </summary>
        internal static string HelpDestinationPublishSettingsFilePath {
            get {
                return ResourceManager.GetString("HelpDestinationPublishSettingsFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -DestinationSubscriptionID : Destination Subscription Id.
        /// </summary>
        internal static string HelpDestinationSubscriptionId {
            get {
                return ResourceManager.GetString("HelpDestinationSubscriptionId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Example :  -Operation &quot;Export&quot; -SourceSubscriptionID &quot;5d14d4a2-8c5a-4fc5-8d7d-86efb48b3a07&quot; -SourceDCName &quot;East Asia&quot; -ExportMetadataFolderPath &quot;D:\\DataCenterMigration&quot; -SourcePublishSettingsFilePath  &quot;D:\\PublishSettings.PublishSettings&quot; -SourceCertificateThumbprint &quot;2180d782768926ee0e5ddbcc6e8d2efa8ddb98c7&quot; -QuietMode &quot;True&quot; -GenerateMapperXml &quot;True&quot; -RetryCount &quot;5&quot; -MinBackoff &quot;3&quot; -MaxBackoff &quot;3&quot; -DeltaBackoff &quot;90&quot;.
        /// </summary>
        internal static string HelpExportExample {
            get {
                return ResourceManager.GetString("HelpExportExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -ExportMetadataFolderPath : Folder path where the exported metadata file will be saved.
        /// </summary>
        internal static string HelpExportMetadataFolderPath {
            get {
                return ResourceManager.GetString("HelpExportMetadataFolderPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Help for Export Functionality : -.
        /// </summary>
        internal static string HelpForExportFunctionality {
            get {
                return ResourceManager.GetString("HelpForExportFunctionality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Help for Import Functionality : -.
        /// </summary>
        internal static string HelpForImportFunctionality {
            get {
                return ResourceManager.GetString("HelpForImportFunctionality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Help for Migrate Functionality : -.
        /// </summary>
        internal static string HelpForMigrateFunctionality {
            get {
                return ResourceManager.GetString("HelpForMigrateFunctionality", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -GenerateMapperXml : (optional) true if user wants to create mapper xml file for resource name. Default is false..
        /// </summary>
        internal static string HelpGenerateMapperXml {
            get {
                return ResourceManager.GetString("HelpGenerateMapperXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -DestinationPrefixName : Destination Prefix Name. User needs to provide value for either MapperXmlFilePath or DestinationPrefixName..
        /// </summary>
        internal static string HelpImportDestinationPrefixName {
            get {
                return ResourceManager.GetString("HelpImportDestinationPrefixName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Example : -Operation &quot;Import&quot; -SourceSubscriptionID &quot;5d14d4a2-8c5a-4fc5-8d7d-86efb48b3a07&quot; -DestinationSubscriptionID &quot;5d14d4a2-8c5a-4fc5-8d7d-86efb48b3a07&quot; -DestinationDCName &quot;West US&quot; -SourcePublishSettingsFilePath &quot;D:\\PublishSettings.PublishSettings&quot;  -SourceCertificateThumbprint &quot;2180d782768926ee0e5ddbcc6e8d2efa8ddb98c7&quot; -DestinationPublishSettingsFilePath &quot;D:\\PublishSettings.PublishSettings&quot; -DestinationCertificateThumbprint &quot;2180d782768926ee0e5ddbcc6e8d2efa8ddb98c7&quot; -ImportMetadataFilePath &quot;D:\\Data [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HelpImportExample {
            get {
                return ResourceManager.GetString("HelpImportExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -ImportMetadataFilePath: File path where the metadata is saved.
        /// </summary>
        internal static string HelpImportMetadataFilePath {
            get {
                return ResourceManager.GetString("HelpImportMetadataFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -MapperXmlFilePath: File path where the mapper xml is saved.
        /// </summary>
        internal static string HelpMapperXmlFilePath {
            get {
                return ResourceManager.GetString("HelpMapperXmlFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -MaxBackoff :  (optional) Maximum backoff in seconds for &apos;Exponential Backoff&apos; retry strategy, Default is 30 seconds.
        /// </summary>
        internal static string HelpMaxBackoff {
            get {
                return ResourceManager.GetString("HelpMaxBackoff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Example : -Operation &quot;Migrate&quot; -SourceSubscriptionID &quot;5d14d4a2-8c5a-4fc5-8d7d-86efb48b3a07&quot; -DestinationSubscriptionID &quot;5d14d4a2-8c5a-4fc5-8d7d-86efb48b3a07&quot; -SourceDCName &quot;East Asia&quot; -DestinationDCName &quot;West US&quot; -SourcePublishSettingsFilePath &quot;D:\\PublishSettings.PublishSettings&quot;  -SourceCertificateThumbprint &quot;2180d782768926ee0e5ddbcc6e8d2efa8ddb98c7&quot; -DestinationPublishSettingsFilePath &quot;D:\\PublishSettings.PublishSettings&quot; -DestinationCertificateThumbprint &quot;2180d782768926ee0e5ddbcc6e8d2efa8ddb98c7&quot; -Expor [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HelpMigrateExample {
            get {
                return ResourceManager.GetString("HelpMigrateExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -MinBackoff :  (optional) Minimum backoff in seconds for &apos;Exponential Backoff&apos; retry strategy, Default is 30 seconds.
        /// </summary>
        internal static string HelpMinBackoff {
            get {
                return ResourceManager.GetString("HelpMinBackoff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -QuietMode : (optional) true if user don&apos;t want to print progress messages on console. Default is false..
        /// </summary>
        internal static string HelpQuietMode {
            get {
                return ResourceManager.GetString("HelpQuietMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -ResumeImport : (optional)true if user wants to update import status in the same file. Default is false..
        /// </summary>
        internal static string HelpResumeImport {
            get {
                return ResourceManager.GetString("HelpResumeImport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -RetryCount : (optional) No. of times to retry in case of exception, Default is &apos;5&apos;.
        /// </summary>
        internal static string HelpRetryCount {
            get {
                return ResourceManager.GetString("HelpRetryCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -RollBackOnFailure : (optional)true if user wants to rollback all imported resources. Default is false..
        /// </summary>
        internal static string HelpRollbackOnFailure {
            get {
                return ResourceManager.GetString("HelpRollbackOnFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -SourceCertificateThumbprint : Certificate thumbprint for source subscription. User needs to provide value for either SourcePublishSettingsFilePath or SourceCertificateThumbprint for authentiacation.
        /// </summary>
        internal static string HelpSourceCertificateThumbprint {
            get {
                return ResourceManager.GetString("HelpSourceCertificateThumbprint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -SourceDCName : Source Data Center Name.
        /// </summary>
        internal static string HelpSourceDCName {
            get {
                return ResourceManager.GetString("HelpSourceDCName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -SourcePublishSettingsFilePath : SourcePublishSettings file path.
        /// </summary>
        internal static string HelpSourcePublishSettingsFilePath {
            get {
                return ResourceManager.GetString("HelpSourcePublishSettingsFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -SourceSubscriptionID : Source Subscription Id.
        /// </summary>
        internal static string HelpSourceSubscriptionId {
            get {
                return ResourceManager.GetString("HelpSourceSubscriptionId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING : Import process will stop virtual machines of source subscription. Do you want to continue? (Y/N) : .
        /// </summary>
        internal static string ImportWarning {
            get {
                return ResourceManager.GetString("ImportWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING : Import process will stop virtual machines of source subscription. .
        /// </summary>
        internal static string ImportWarningLog {
            get {
                return ResourceManager.GetString("ImportWarningLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid syntax. Argument name should be preceded with &apos;-&apos;. .
        /// </summary>
        internal static string InvalidArgumentDeclaration {
            get {
                return ResourceManager.GetString("InvalidArgumentDeclaration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid argument name : &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidArgumentName {
            get {
                return ResourceManager.GetString("InvalidArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid number of arguments..
        /// </summary>
        internal static string InvalidNumberOfArguments {
            get {
                return ResourceManager.GetString("InvalidNumberOfArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No input parameters are provided. Pass commandline arguments or provide the values in App.config file..
        /// </summary>
        internal static string MissingInputParameters {
            get {
                return ResourceManager.GetString("MissingInputParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -Operation parameter should be define first parameter with value as Export /Import /Migrate.
        /// </summary>
        internal static string MissingOperationParameter {
            get {
                return ResourceManager.GetString("MissingOperationParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required parameter &apos;{0}&apos; is missing. Define parameter in &apos;{1}&apos; ..
        /// </summary>
        internal static string MissingRequiredParameter {
            get {
                return ResourceManager.GetString("MissingRequiredParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select a valid option (y/n): .
        /// </summary>
        internal static string SelectValidOption {
            get {
                return ResourceManager.GetString("SelectValidOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validation Error : {0} .
        /// </summary>
        internal static string ValidationError {
            get {
                return ResourceManager.GetString("ValidationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument {0} should contain &quot;true&quot; / &quot;false&quot; value only.
        /// </summary>
        internal static string WrongInputForBoolArg {
            get {
                return ResourceManager.GetString("WrongInputForBoolArg", resourceCulture);
            }
        }
    }
}
