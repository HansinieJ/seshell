﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeShell.Test.XMLTestResult.Resources {
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
    internal class TestResultResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestResultResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SeShell.Test.XMLTestResult.Resources.TestResultResources", typeof(TestResultResources).Assembly);
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
        ///   Looks up a localized string similar to SeShellAutomation.
        /// </summary>
        internal static string AutomationResultNamespace {
            get {
                return ResourceManager.GetString("AutomationResultNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FBLoginTest.
        /// </summary>
        internal static string ClassesToExecute {
            get {
                return ResourceManager.GetString("ClassesToExecute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to C:\FinalTestResult\.
        /// </summary>
        internal static string FinalResultLocation {
            get {
                return ResourceManager.GetString("FinalResultLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to C:\SeShellResult\.
        /// </summary>
        internal static string NUnitModifiedTestResultLocation {
            get {
                return ResourceManager.GetString("NUnitModifiedTestResultLocation", resourceCulture);
            }
        }
    }
}
