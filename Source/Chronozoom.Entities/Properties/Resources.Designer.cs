﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chronozoom.Entities.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Chronozoom.Entities.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to CREATE PROCEDURE TimelineSubtreeQuery
        ///	@Collection_Id UNIQUEIDENTIFIER,
        ///	@LCA UNIQUEIDENTIFIER,
        ///	@min_span DECIMAL,
        ///	@startTime DECIMAL,
        ///	@endTime DECIMAL,
        ///	@max_elem INT
        ///AS
        ///BEGIN
        ///	DECLARE @return_entire_subtree BIT
        ///	DECLARE @subtree_size INT
        ///	DECLARE @current_level_cnt INT
        ///	DECLARE @cnt INT
        ///	DECLARE @num_ge_min_span INT
        ///	DECLARE @current_id UNIQUEIDENTIFIER
        ///	DECLARE @current_level TABLE (
        ///		Id UNIQUEIDENTIFIER
        ///	)
        ///	DECLARE @next_level TABLE (
        ///		Id UNIQUEIDENTIFIER
        ///	)
        ///	DECLARE @results TABLE (
        ///		Id UNIQUEIDE [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TimelineSubtreeQuery {
            get {
                return ResourceManager.GetString("TimelineSubtreeQuery", resourceCulture);
            }
        }
    }
}