﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWindows.WebRefWcf {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Produto", Namespace="http://schemas.datacontract.org/2004/07/ExemploServico")]
    [System.SerializableAttribute()]
    public partial class Produto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrecoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Preco {
            get {
                return this.PrecoField;
            }
            set {
                if ((this.PrecoField.Equals(value) != true)) {
                    this.PrecoField = value;
                    this.RaisePropertyChanged("Preco");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebRefWcf.IServico01")]
    public interface IServico01 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico01/Mensagem", ReplyAction="http://tempuri.org/IServico01/MensagemResponse")]
        string Mensagem();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico01/Mensagem", ReplyAction="http://tempuri.org/IServico01/MensagemResponse")]
        System.Threading.Tasks.Task<string> MensagemAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico01/Somar", ReplyAction="http://tempuri.org/IServico01/SomarResponse")]
        int Somar(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico01/Somar", ReplyAction="http://tempuri.org/IServico01/SomarResponse")]
        System.Threading.Tasks.Task<int> SomarAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico01/PromocaoDoDia", ReplyAction="http://tempuri.org/IServico01/PromocaoDoDiaResponse")]
        ClientWindows.WebRefWcf.Produto PromocaoDoDia();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico01/PromocaoDoDia", ReplyAction="http://tempuri.org/IServico01/PromocaoDoDiaResponse")]
        System.Threading.Tasks.Task<ClientWindows.WebRefWcf.Produto> PromocaoDoDiaAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServico01Channel : ClientWindows.WebRefWcf.IServico01, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Servico01Client : System.ServiceModel.ClientBase<ClientWindows.WebRefWcf.IServico01>, ClientWindows.WebRefWcf.IServico01 {
        
        public Servico01Client() {
        }
        
        public Servico01Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Servico01Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Servico01Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Servico01Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Mensagem() {
            return base.Channel.Mensagem();
        }
        
        public System.Threading.Tasks.Task<string> MensagemAsync() {
            return base.Channel.MensagemAsync();
        }
        
        public int Somar(int x, int y) {
            return base.Channel.Somar(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SomarAsync(int x, int y) {
            return base.Channel.SomarAsync(x, y);
        }
        
        public ClientWindows.WebRefWcf.Produto PromocaoDoDia() {
            return base.Channel.PromocaoDoDia();
        }
        
        public System.Threading.Tasks.Task<ClientWindows.WebRefWcf.Produto> PromocaoDoDiaAsync() {
            return base.Channel.PromocaoDoDiaAsync();
        }
    }
}
