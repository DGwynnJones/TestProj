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
    
    public partial class EventSubscriptionTemplates
    {
        public System.Guid Id { get; set; }
        public string AreaName { get; set; }
        public string ControlName { get; set; }
        public string WorkflowName { get; set; }
        public Nullable<bool> NoApprovalRequiredDefault { get; set; }
        public Nullable<bool> IsOneShotTriggerDefault { get; set; }
        public string Description { get; set; }
        public string EventName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public string EventSourceCode { get; set; }
        public string SubscriptionClass { get; set; }
        public int SortOrder { get; set; }
        public string MvcActionName { get; set; }
    
        public virtual EventSources EventSources { get; set; }
    }
}
