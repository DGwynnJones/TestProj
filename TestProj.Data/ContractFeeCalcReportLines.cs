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
    
    public partial class ContractFeeCalcReportLines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractFeeCalcReportLines()
        {
            this.ContractFeeCalcReportLineAllocations = new HashSet<ContractFeeCalcReportLineAllocations>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContractFeeCalcReportId { get; set; }
        public System.Guid OriginalScheduleItemId { get; set; }
        public Nullable<System.Guid> ProjectCategoryId { get; set; }
        public System.Guid ProjectId { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountBaseCurrency { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public bool CanBeInvoiced { get; set; }
        public Nullable<System.Guid> InvoiceLineItemId { get; set; }
        public System.Guid OriginalScheduleItemProjectId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcReportLineAllocations> ContractFeeCalcReportLineAllocations { get; set; }
        public virtual ContractFeeCalcReports ContractFeeCalcReports { get; set; }
        public virtual ContractInvoiceScheduleItemProjects ContractInvoiceScheduleItemProjects { get; set; }
        public virtual ProjectCategories ProjectCategories { get; set; }
        public virtual ContractInvoiceScheduleItems ContractInvoiceScheduleItems { get; set; }
        public virtual InvoiceLineItems InvoiceLineItems { get; set; }
    }
}
