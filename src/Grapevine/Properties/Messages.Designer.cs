﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grapevine.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Grapevine.Properties.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to {0}: must accept one and only one argument..
        /// </summary>
        internal static string MethodAcceptsMultipleArguments {
            get {
                return ResourceManager.GetString("MethodAcceptsMultipleArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: argument {1} must be of type {2}..
        /// </summary>
        internal static string MethodArgumentMustBeOfType {
            get {
                return ResourceManager.GetString("MethodArgumentMustBeOfType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: cannot be invoked..
        /// </summary>
        internal static string MethodCannotBeInvoked {
            get {
                return ResourceManager.GetString("MethodCannotBeInvoked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: does not have a parameterless constructor..
        /// </summary>
        internal static string MethodDoesNotHaveParameterlessConstructor {
            get {
                return ResourceManager.GetString("MethodDoesNotHaveParameterlessConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: may be treated in a special way by some compilers (such as property accessors and operator overloading methods)..
        /// </summary>
        internal static string MethodIsSpecial {
            get {
                return ResourceManager.GetString("MethodIsSpecial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: does not have the {1} attribute..
        /// </summary>
        internal static string MethodMissingAttribute {
            get {
                return ResourceManager.GetString("MethodMissingAttribute", resourceCulture);
            }
        }
    }
}
