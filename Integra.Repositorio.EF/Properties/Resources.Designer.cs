﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Integra.Repositorio.EF.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Integra.Repositorio.EF.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to insert into [integraDb].[dbo].[PessoaPrograma]
        ///select Codigo, Programa_Codigo from [integraDb].[dbo].[Pessoa];
        ///
        ///-- Correção Programa-Ata
        ///update a set Programa_Codigo=p.Programa_Codigo from ata a
        ///	inner join pessoa p on p.Codigo=a.Responsavel_Codigo;
        ///
        ///.
        /// </summary>
        public static string CorrecaoPrograma {
            get {
                return ResourceManager.GetString("CorrecaoPrograma", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN TRAN;
        ///INSERT INTO dbo.Grupos (Nome, Descricao) values (&apos;Íntegra&apos;, &apos;Íntegra&apos;);
        ///INSERT INTO dbo.Grupos (Nome, Descricao) values (&apos;Cliente&apos;, &apos;Cliente&apos;);
        ///
        ///INSERT INTO dbo.TipoDeCrm (Descricao) values (&apos;Representante&apos;);
        ///INSERT INTO dbo.TipoDeCrm (Descricao) values (&apos;Gerente de Marketing&apos;);
        ///INSERT INTO dbo.TipoDeCrm (Descricao) values (&apos;Gerente de Produto&apos;);
        ///
        ///INSERT INTO dbo.Cargo (Nome, Descricao) values (&apos;Administrador&apos;,&apos;Administrador&apos;);
        ///INSERT INTO dbo.Departamento (Nome, Descricao) values (&apos;Exe [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Initial {
            get {
                return ResourceManager.GetString("Initial", resourceCulture);
            }
        }
    }
}
