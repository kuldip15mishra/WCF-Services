﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeaveSample.UI.Process.LeaveWorkflowService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LeaveWorkflowService.ILeaveWorkflowService")]
    public interface ILeaveWorkflowService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeaveWorkflowService/Apply", ReplyAction="http://tempuri.org/ILeaveWorkflowService/ApplyResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ApplyResponseResult")]
        LeaveSample.Entities.Leave Apply(LeaveSample.Entities.Leave leave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeaveWorkflowService/Apply", ReplyAction="http://tempuri.org/ILeaveWorkflowService/ApplyResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ApplyResponseResult")]
        System.Threading.Tasks.Task<LeaveSample.Entities.Leave> ApplyAsync(LeaveSample.Entities.Leave leave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeaveWorkflowService/Cancel", ReplyAction="http://tempuri.org/ILeaveWorkflowService/CancelResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="CancelResponseResult")]
        LeaveSample.Entities.Leave Cancel(LeaveSample.Entities.Leave leave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeaveWorkflowService/Cancel", ReplyAction="http://tempuri.org/ILeaveWorkflowService/CancelResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="CancelResponseResult")]
        System.Threading.Tasks.Task<LeaveSample.Entities.Leave> CancelAsync(LeaveSample.Entities.Leave leave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeaveWorkflowService/Approve", ReplyAction="http://tempuri.org/ILeaveWorkflowService/ApproveResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ApproveResponseResult")]
        LeaveSample.Entities.Leave Approve(LeaveSample.Entities.Leave leave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeaveWorkflowService/Approve", ReplyAction="http://tempuri.org/ILeaveWorkflowService/ApproveResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ApproveResponseResult")]
        System.Threading.Tasks.Task<LeaveSample.Entities.Leave> ApproveAsync(LeaveSample.Entities.Leave leave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeaveWorkflowService/Reject", ReplyAction="http://tempuri.org/ILeaveWorkflowService/RejectResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RejectResponseResult")]
        LeaveSample.Entities.Leave Reject(LeaveSample.Entities.Leave leave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeaveWorkflowService/Reject", ReplyAction="http://tempuri.org/ILeaveWorkflowService/RejectResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RejectResponseResult")]
        System.Threading.Tasks.Task<LeaveSample.Entities.Leave> RejectAsync(LeaveSample.Entities.Leave leave);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILeaveWorkflowServiceChannel : LeaveSample.UI.Process.LeaveWorkflowService.ILeaveWorkflowService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LeaveWorkflowServiceClient : System.ServiceModel.ClientBase<LeaveSample.UI.Process.LeaveWorkflowService.ILeaveWorkflowService>, LeaveSample.UI.Process.LeaveWorkflowService.ILeaveWorkflowService {
        
        public LeaveWorkflowServiceClient() {
        }
        
        public LeaveWorkflowServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LeaveWorkflowServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LeaveWorkflowServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LeaveWorkflowServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LeaveSample.Entities.Leave Apply(LeaveSample.Entities.Leave leave) {
            return base.Channel.Apply(leave);
        }
        
        public System.Threading.Tasks.Task<LeaveSample.Entities.Leave> ApplyAsync(LeaveSample.Entities.Leave leave) {
            return base.Channel.ApplyAsync(leave);
        }
        
        public LeaveSample.Entities.Leave Cancel(LeaveSample.Entities.Leave leave) {
            return base.Channel.Cancel(leave);
        }
        
        public System.Threading.Tasks.Task<LeaveSample.Entities.Leave> CancelAsync(LeaveSample.Entities.Leave leave) {
            return base.Channel.CancelAsync(leave);
        }
        
        public LeaveSample.Entities.Leave Approve(LeaveSample.Entities.Leave leave) {
            return base.Channel.Approve(leave);
        }
        
        public System.Threading.Tasks.Task<LeaveSample.Entities.Leave> ApproveAsync(LeaveSample.Entities.Leave leave) {
            return base.Channel.ApproveAsync(leave);
        }
        
        public LeaveSample.Entities.Leave Reject(LeaveSample.Entities.Leave leave) {
            return base.Channel.Reject(leave);
        }
        
        public System.Threading.Tasks.Task<LeaveSample.Entities.Leave> RejectAsync(LeaveSample.Entities.Leave leave) {
            return base.Channel.RejectAsync(leave);
        }
    }
}
