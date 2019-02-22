﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SonarScanner.MSBuild.PostProcessor {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SonarScanner.MSBuild.PostProcessor.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to SonarScanner for MSBuild End Step.
        /// </summary>
        internal static string AssemblyDescription {
            get {
                return ResourceManager.GetString("AssemblyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inconsistent build environment settings: the build Uri in the analysis config file does not match the build uri from the environment variable.
        ///Build Uri from environment: {0}
        ///Build Uri from config: {1}
        ///Analysis config file: {2}
        ///Please delete the analysis config file and try the build again..
        /// </summary>
        internal static string ERROR_BuildUrisDontMatch {
            get {
                return ResourceManager.GetString("ERROR_BuildUrisDontMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This setting is not valid in the &quot;end&quot; phase in this version of the C# plugin: {0}.
        /// </summary>
        internal static string ERROR_CmdLine_DisallowedArgument {
            get {
                return ResourceManager.GetString("ERROR_CmdLine_DisallowedArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SonarQube analysis could not be completed because the analysis configuration file could not be found.
        ///Expected location: {0}.
        /// </summary>
        internal static string ERROR_ConfigFileNotFound {
            get {
                return ResourceManager.GetString("ERROR_ConfigFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Credentials must be passed in both begin and end steps or not at all.
        /// </summary>
        internal static string ERROR_CredentialsNotSpecified {
            get {
                return ResourceManager.GetString("ERROR_CredentialsNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading the SonarQube analysis config from {0}.
        /// </summary>
        internal static string MSG_LoadingConfig {
            get {
                return ResourceManager.GetString("MSG_LoadingConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not delete {0} from {1}.
        /// </summary>
        internal static string MSG_UninstallTargets_CouldNotDelete {
            get {
                return ResourceManager.GetString("MSG_UninstallTargets_CouldNotDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not exist at {1}.
        /// </summary>
        internal static string MSG_UninstallTargets_NotExists {
            get {
                return ResourceManager.GetString("MSG_UninstallTargets_NotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstalling target: {0}\{1}.
        /// </summary>
        internal static string MSG_UninstallTargets_Uninstalling {
            get {
                return ResourceManager.GetString("MSG_UninstallTargets_Uninstalling", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis failed for SonarQube project {0}.
        /// </summary>
        internal static string Report_AnalysisFailed {
            get {
                return ResourceManager.GetString("Report_AnalysisFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis succeeded for SonarQube project {0} [(Analysis results)] ({1}).
        /// </summary>
        internal static string Report_AnalysisSucceeded {
            get {
                return ResourceManager.GetString("Report_AnalysisSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a summary markdown file....
        /// </summary>
        internal static string Report_CreatingSummaryMarkdown {
            get {
                return ResourceManager.GetString("Report_CreatingSummaryMarkdown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to   Invalid projects: {0}, skipped projects: {1}, excluded projects: {2}.
        /// </summary>
        internal static string Report_InvalidSkippedAndExcludedMessage {
            get {
                return ResourceManager.GetString("Report_InvalidSkippedAndExcludedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis failed for SonarQube project {0}.
        /// </summary>
        internal static string Report_MdSummaryAnalysisFailed {
            get {
                return ResourceManager.GetString("Report_MdSummaryAnalysisFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis succeeded for SonarQube project {0} [Analysis results]({1}).
        /// </summary>
        internal static string Report_MdSummaryAnalysisSucceeded {
            get {
                return ResourceManager.GetString("Report_MdSummaryAnalysisSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to - Invalid projects: {0}, skipped projects: {1}, excluded projects: {2}.
        /// </summary>
        internal static string Report_MdSummaryInvalidSkippedAndExcludedMessage {
            get {
                return ResourceManager.GetString("Report_MdSummaryInvalidSkippedAndExcludedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to - Product projects: {0}, test projects: {1}.
        /// </summary>
        internal static string Report_MdSummaryProductAndTestMessage {
            get {
                return ResourceManager.GetString("Report_MdSummaryProductAndTestMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to   Product projects: {0}, test projects: {1}.
        /// </summary>
        internal static string Report_ProductAndTestMessage {
            get {
                return ResourceManager.GetString("Report_ProductAndTestMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot;, version {2}.
        /// </summary>
        internal static string Report_SonarQubeProjectDescription {
            get {
                return ResourceManager.GetString("Report_SonarQubeProjectDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating the TeamBuild summary....
        /// </summary>
        internal static string Report_UpdatingTeamBuildSummary {
            get {
                return ResourceManager.GetString("Report_UpdatingTeamBuildSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis base directory: {0}
        ///Build directory: {1}
        ///Bin directory: {2}
        ///Config directory: {3}
        ///Output directory: {4}
        ///Config file: {5}.
        /// </summary>
        internal static string SETTING_DumpSettings {
            get {
                return ResourceManager.GetString("SETTING_DumpSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Legacy TeamBuild environment detected.
        /// </summary>
        internal static string SETTINGS_InLegacyTeamBuild {
            get {
                return ResourceManager.GetString("SETTINGS_InLegacyTeamBuild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TeamBuild environment detected.
        /// </summary>
        internal static string SETTINGS_InTeamBuild {
            get {
                return ResourceManager.GetString("SETTINGS_InTeamBuild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not running under TeamBuild.
        /// </summary>
        internal static string SETTINGS_NotInTeamBuild {
            get {
                return ResourceManager.GetString("SETTINGS_NotInTeamBuild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot process the code coverage information. Look at the previous warnings for details..
        /// </summary>
        internal static string WARN_CannotProcessCoverage {
            get {
                return ResourceManager.GetString("WARN_CannotProcessCoverage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ** WARNING: Support for XAML builds is deprecated since version 4.1 and will be removed in version 5.0 of the Scanner for MSBuild **.
        /// </summary>
        internal static string WARN_XamlBuildDeprecated {
            get {
                return ResourceManager.GetString("WARN_XamlBuildDeprecated", resourceCulture);
            }
        }
    }
}
