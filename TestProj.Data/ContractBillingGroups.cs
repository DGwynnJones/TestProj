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
    
    public partial class ContractBillingGroups
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractBillingGroups()
        {
            this.ContractBillingGroupChannels = new HashSet<ContractBillingGroupChannels>();
            this.ContractBillingGroupLanguages = new HashSet<ContractBillingGroupLanguages>();
            this.ContractBillingGroupProjectCategories = new HashSet<ContractBillingGroupProjectCategories>();
            this.ContractBillingGroupProjects = new HashSet<ContractBillingGroupProjects>();
            this.ContractBillingGroupRights = new HashSet<ContractBillingGroupRights>();
            this.ContractBillingGroups1 = new HashSet<ContractBillingGroups>();
            this.ContractBillingGroupTerritories = new HashSet<ContractBillingGroupTerritories>();
            this.ContractRoyaltyConsumptionHistory = new HashSet<ContractRoyaltyConsumptionHistory>();
            this.ContractInvoiceScheduleItems = new HashSet<ContractInvoiceScheduleItems>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContractId { get; set; }
        public int SequenceNumber { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.Guid RevenueRecognitionMethodId { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public bool UseCrossCollateralization { get; set; }
        public bool ConsumeUnbilledAdvances { get; set; }
        public Nullable<System.Guid> OriginalId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBillingGroupChannels> ContractBillingGroupChannels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBillingGroupLanguages> ContractBillingGroupLanguages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBillingGroupProjectCategories> ContractBillingGroupProjectCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBillingGroupProjects> ContractBillingGroupProjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBillingGroupRights> ContractBillingGroupRights { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBillingGroups> ContractBillingGroups1 { get; set; }
        public virtual ContractBillingGroups ContractBillingGroups2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBillingGroupTerritories> ContractBillingGroupTerritories { get; set; }
        public virtual RevenueRecognitionMethods RevenueRecognitionMethods { get; set; }
        public virtual Contracts Contracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyConsumptionHistory> ContractRoyaltyConsumptionHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItems> ContractInvoiceScheduleItems { get; set; }
    }
}