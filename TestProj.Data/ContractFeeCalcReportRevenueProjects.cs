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
    
    public partial class ContractFeeCalcReportRevenueProjects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractFeeCalcReportRevenueProjects()
        {
            this.ContractFeeCalcReportRevenueProjectAllocations = new HashSet<ContractFeeCalcReportRevenueProjectAllocations>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContractFeeCalcReportRevenueId { get; set; }
        public System.Guid SourceFeeCalcReportId { get; set; }
        public System.Guid ProjectId { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountBaseCurrency { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public System.DateTime CreateDateTimeUtc { get; set; }
        public Nullable<System.Guid> OriginalScheduleItemProjectId { get; set; }
    
        public virtual ContractFeeCalcReportRevenue ContractFeeCalcReportRevenue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcReportRevenueProjectAllocations> ContractFeeCalcReportRevenueProjectAllocations { get; set; }
        public virtual ContractFeeCalcReports ContractFeeCalcReports { get; set; }
        public virtual ContractInvoiceScheduleItemProjects ContractInvoiceScheduleItemProjects { get; set; }
    }
}
