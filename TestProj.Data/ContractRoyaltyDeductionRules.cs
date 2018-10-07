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
    
    public partial class ContractRoyaltyDeductionRules
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractRoyaltyDeductionRules()
        {
            this.ContractRoyaltyDeductionRuleChannels = new HashSet<ContractRoyaltyDeductionRuleChannels>();
            this.ContractRoyaltyDeductionRuleLanguages = new HashSet<ContractRoyaltyDeductionRuleLanguages>();
            this.ContractRoyaltyDeductionRuleProjects = new HashSet<ContractRoyaltyDeductionRuleProjects>();
            this.ContractRoyaltyDeductionRuleReportingColumns = new HashSet<ContractRoyaltyDeductionRuleReportingColumns>();
            this.ContractRoyaltyDeductionRuleRights = new HashSet<ContractRoyaltyDeductionRuleRights>();
            this.ContractRoyaltyDeductionRuleTerritories = new HashSet<ContractRoyaltyDeductionRuleTerritories>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContractId { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public decimal MaximumPercent { get; set; }
        public decimal MaximumAmount { get; set; }
        public decimal MaximumPerUnit { get; set; }
        public string TimingOption { get; set; }
        public string CombinationOption { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDeductionRuleChannels> ContractRoyaltyDeductionRuleChannels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDeductionRuleLanguages> ContractRoyaltyDeductionRuleLanguages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDeductionRuleProjects> ContractRoyaltyDeductionRuleProjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDeductionRuleReportingColumns> ContractRoyaltyDeductionRuleReportingColumns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDeductionRuleRights> ContractRoyaltyDeductionRuleRights { get; set; }
        public virtual RoyaltyDeductionRuleCombinationOptions RoyaltyDeductionRuleCombinationOptions { get; set; }
        public virtual RoyaltyDeductionRuleTimingOptions RoyaltyDeductionRuleTimingOptions { get; set; }
        public virtual Contracts Contracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDeductionRuleTerritories> ContractRoyaltyDeductionRuleTerritories { get; set; }
    }
}
