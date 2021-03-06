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
    
    public partial class ContractRevenueCards
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractRevenueCards()
        {
            this.ContractRevenueCardAllocations = new HashSet<ContractRevenueCardAllocations>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContractId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.Guid> ContractAllocationRuleId { get; set; }
        public Nullable<System.DateTime> WindowStartDate { get; set; }
        public Nullable<System.DateTime> WindowEndDate { get; set; }
        public bool IsEstimatedRecognitionDate { get; set; }
        public bool GeneratedByPercent { get; set; }
    
        public virtual ContractAllocationRules ContractAllocationRules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRevenueCardAllocations> ContractRevenueCardAllocations { get; set; }
        public virtual Contracts Contracts { get; set; }
    }
}
