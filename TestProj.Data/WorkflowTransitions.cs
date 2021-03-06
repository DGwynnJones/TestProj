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
    
    public partial class WorkflowTransitions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkflowTransitions()
        {
            this.TransitionActions = new HashSet<TransitionActions>();
            this.WorkflowTransitionAttempts = new HashSet<WorkflowTransitionAttempts>();
            this.WorkflowTransitionRoles = new HashSet<WorkflowTransitionRoles>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> FromWorkflowStateId { get; set; }
        public System.Guid ToWorkflowStateId { get; set; }
        public bool OnChangeResetOverrideRules { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public System.Guid WorkflowId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransitionActions> TransitionActions { get; set; }
        public virtual Workflows Workflows { get; set; }
        public virtual WorkflowStates WorkflowStates { get; set; }
        public virtual WorkflowStates WorkflowStates1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkflowTransitionAttempts> WorkflowTransitionAttempts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkflowTransitionRoles> WorkflowTransitionRoles { get; set; }
    }
}
