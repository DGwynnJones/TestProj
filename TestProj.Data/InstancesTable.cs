//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestProj.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class InstancesTable
    {
        public System.Guid Id { get; set; }
        public long SurrogateInstanceId { get; set; }
        public Nullable<long> SurrogateLockOwnerId { get; set; }
        public byte[] PrimitiveDataProperties { get; set; }
        public byte[] ComplexDataProperties { get; set; }
        public byte[] WriteOnlyPrimitiveDataProperties { get; set; }
        public byte[] WriteOnlyComplexDataProperties { get; set; }
        public byte[] MetadataProperties { get; set; }
        public Nullable<byte> DataEncodingOption { get; set; }
        public Nullable<byte> MetadataEncodingOption { get; set; }
        public long Version { get; set; }
        public Nullable<System.DateTime> PendingTimer { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<System.Guid> WorkflowHostType { get; set; }
        public Nullable<long> ServiceDeploymentId { get; set; }
        public string SuspensionExceptionName { get; set; }
        public string SuspensionReason { get; set; }
        public string BlockingBookmarks { get; set; }
        public string LastMachineRunOn { get; set; }
        public string ExecutionStatus { get; set; }
        public Nullable<bool> IsInitialized { get; set; }
        public Nullable<bool> IsSuspended { get; set; }
        public Nullable<bool> IsReadyToRun { get; set; }
        public Nullable<bool> IsCompleted { get; set; }
        public long SurrogateIdentityId { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    }
}
