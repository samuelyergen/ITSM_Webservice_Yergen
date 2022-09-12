﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrinterForm.ServicePrint {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicePrint.IPrintSystem")]
    public interface IPrintSystem {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintSystem/AddAmount", ReplyAction="http://tempuri.org/IPrintSystem/AddAmountResponse")]
        int AddAmount(string username, float amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintSystem/AddAmount", ReplyAction="http://tempuri.org/IPrintSystem/AddAmountResponse")]
        System.Threading.Tasks.Task<int> AddAmountAsync(string username, float amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintSystem/TransferMoney", ReplyAction="http://tempuri.org/IPrintSystem/TransferMoneyResponse")]
        int TransferMoney(int id, float amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintSystem/TransferMoney", ReplyAction="http://tempuri.org/IPrintSystem/TransferMoneyResponse")]
        System.Threading.Tasks.Task<int> TransferMoneyAsync(int id, float amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPrintSystemChannel : PrinterForm.ServicePrint.IPrintSystem, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PrintSystemClient : System.ServiceModel.ClientBase<PrinterForm.ServicePrint.IPrintSystem>, PrinterForm.ServicePrint.IPrintSystem {
        
        public PrintSystemClient() {
        }
        
        public PrintSystemClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PrintSystemClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrintSystemClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrintSystemClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddAmount(string username, float amount) {
            return base.Channel.AddAmount(username, amount);
        }
        
        public System.Threading.Tasks.Task<int> AddAmountAsync(string username, float amount) {
            return base.Channel.AddAmountAsync(username, amount);
        }
        
        public int TransferMoney(int id, float amount) {
            return base.Channel.TransferMoney(id, amount);
        }
        
        public System.Threading.Tasks.Task<int> TransferMoneyAsync(int id, float amount) {
            return base.Channel.TransferMoneyAsync(id, amount);
        }
    }
}
