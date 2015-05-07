﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18408.
// 
#pragma warning disable 1591

namespace Integra.Web.integraEssencial {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="IntegraEssencialSoap", Namespace="http://tempuri.org/")]
    public partial class IntegraEssencial : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddNewUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddNewUserNotifyOperationCompleted;
        
        private System.Threading.SendOrPostCallback VerifyUserOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public IntegraEssencial() {
            this.Url = global::Integra.Web.Properties.Settings.Default.Integra_Web_integraEssencial_IntegraEssencial;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AddNewUserCompletedEventHandler AddNewUserCompleted;
        
        /// <remarks/>
        public event AddNewUserNotifyCompletedEventHandler AddNewUserNotifyCompleted;
        
        /// <remarks/>
        public event VerifyUserCompletedEventHandler VerifyUserCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddNewUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AddNewUser(string email, string senha, int codigoClinica, string nomeClinica) {
            object[] results = this.Invoke("AddNewUser", new object[] {
                        email,
                        senha,
                        codigoClinica,
                        nomeClinica});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void AddNewUserAsync(string email, string senha, int codigoClinica, string nomeClinica) {
            this.AddNewUserAsync(email, senha, codigoClinica, nomeClinica, null);
        }
        
        /// <remarks/>
        public void AddNewUserAsync(string email, string senha, int codigoClinica, string nomeClinica, object userState) {
            if ((this.AddNewUserOperationCompleted == null)) {
                this.AddNewUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddNewUserOperationCompleted);
            }
            this.InvokeAsync("AddNewUser", new object[] {
                        email,
                        senha,
                        codigoClinica,
                        nomeClinica}, this.AddNewUserOperationCompleted, userState);
        }
        
        private void OnAddNewUserOperationCompleted(object arg) {
            if ((this.AddNewUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddNewUserCompleted(this, new AddNewUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddNewUserNotify", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AddNewUserNotify(string email, string senha, int codigoClinica, string nomeClinica) {
            object[] results = this.Invoke("AddNewUserNotify", new object[] {
                        email,
                        senha,
                        codigoClinica,
                        nomeClinica});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void AddNewUserNotifyAsync(string email, string senha, int codigoClinica, string nomeClinica) {
            this.AddNewUserNotifyAsync(email, senha, codigoClinica, nomeClinica, null);
        }
        
        /// <remarks/>
        public void AddNewUserNotifyAsync(string email, string senha, int codigoClinica, string nomeClinica, object userState) {
            if ((this.AddNewUserNotifyOperationCompleted == null)) {
                this.AddNewUserNotifyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddNewUserNotifyOperationCompleted);
            }
            this.InvokeAsync("AddNewUserNotify", new object[] {
                        email,
                        senha,
                        codigoClinica,
                        nomeClinica}, this.AddNewUserNotifyOperationCompleted, userState);
        }
        
        private void OnAddNewUserNotifyOperationCompleted(object arg) {
            if ((this.AddNewUserNotifyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddNewUserNotifyCompleted(this, new AddNewUserNotifyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/VerifyUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string VerifyUser(string email) {
            object[] results = this.Invoke("VerifyUser", new object[] {
                        email});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void VerifyUserAsync(string email) {
            this.VerifyUserAsync(email, null);
        }
        
        /// <remarks/>
        public void VerifyUserAsync(string email, object userState) {
            if ((this.VerifyUserOperationCompleted == null)) {
                this.VerifyUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerifyUserOperationCompleted);
            }
            this.InvokeAsync("VerifyUser", new object[] {
                        email}, this.VerifyUserOperationCompleted, userState);
        }
        
        private void OnVerifyUserOperationCompleted(object arg) {
            if ((this.VerifyUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerifyUserCompleted(this, new VerifyUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void AddNewUserCompletedEventHandler(object sender, AddNewUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddNewUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddNewUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void AddNewUserNotifyCompletedEventHandler(object sender, AddNewUserNotifyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddNewUserNotifyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddNewUserNotifyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void VerifyUserCompletedEventHandler(object sender, VerifyUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerifyUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VerifyUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591