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
    
    public partial class ContractInvoiceScheduleItemProjects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractInvoiceScheduleItemProjects()
        {
            this.ContractFeeCalcReportLines = new HashSet<ContractFeeCalcReportLines>();
            this.ContractFeeCalcReportRevenueProjects = new HashSet<ContractFeeCalcReportRevenueProjects>();
            this.ContractInvoiceScheduleItemAllocations = new HashSet<ContractInvoiceScheduleItemAllocations>();
            this.ContractInvoiceScheduleItemProjectFeeCalcInputCategories = new HashSet<ContractInvoiceScheduleItemProjectFeeCalcInputCategories>();
            this.ContractInvoiceScheduleItemProjectInstallments = new HashSet<ContractInvoiceScheduleItemProjectInstallments>();
            this.ContractInvoiceScheduleItemProjectInvoiceLineItems = new HashSet<ContractInvoiceScheduleItemProjectInvoiceLineItems>();
            this.ContractInvoiceScheduleItemProjects1 = new HashSet<ContractInvoiceScheduleItemProjects>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContractInvoiceScheduleItemId { get; set; }
        public System.Guid ProjectId { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<decimal> AllocationAmount { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public Nullable<System.Guid> ContractProjectCategoryId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.Guid> OriginalId { get; set; }
        public string ExternalSystemKey { get; set; }
        public Nullable<int> ExternalNo { get; set; }
        public Nullable<System.Guid> ContractAllocationRuleId { get; set; }
        public Nullable<int> LegacyPk { get; set; }
    
        public virtual ContractAllocationRules ContractAllocationRules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcReportLines> ContractFeeCalcReportLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcReportRevenueProjects> ContractFeeCalcReportRevenueProjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItemAllocations> ContractInvoiceScheduleItemAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItemProjectFeeCalcInputCategories> ContractInvoiceScheduleItemProjectFeeCalcInputCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItemProjectInstallments> ContractInvoiceScheduleItemProjectInstallments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItemProjectInvoiceLineItems> ContractInvoiceScheduleItemProjectInvoiceLineItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItemProjects> ContractInvoiceScheduleItemProjects1 { get; set; }
        public virtual ContractInvoiceScheduleItemProjects ContractInvoiceScheduleItemProjects2 { get; set; }
        public virtual ContractProjectCategories ContractProjectCategories { get; set; }
        public virtual ContractInvoiceScheduleItems ContractInvoiceScheduleItems { get; set; }
    }
}
