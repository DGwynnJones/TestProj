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
    
    public partial class TransitionActions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransitionActions()
        {
            this.TransitionActionConfigurations = new HashSet<TransitionActionConfigurations>();
            this.TransitionAttemptActionResults = new HashSet<TransitionAttemptActionResults>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid WorkflowTransitionId { get; set; }
        public System.Guid ActionId { get; set; }
        public int SeverityLevel { get; set; }
        public int ExecutionRank { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public bool IsEnabled { get; set; }
        public string TransitionActionStageCode { get; set; }
    
        public virtual Actions Actions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransitionActionConfigurations> TransitionActionConfigurations { get; set; }
        public virtual TransitionActionStages TransitionActionStages { get; set; }
        public virtual WorkflowTransitions WorkflowTransitions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransitionAttemptActionResults> TransitionAttemptActionResults { get; set; }
    }
}
