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
    
    public partial class ContractFeeCalcReports
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractFeeCalcReports()
        {
            this.ContractFeeCalcReportLines = new HashSet<ContractFeeCalcReportLines>();
            this.ContractFeeCalcReportRevenue = new HashSet<ContractFeeCalcReportRevenue>();
            this.ContractFeeCalcReportRevenueProjects = new HashSet<ContractFeeCalcReportRevenueProjects>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContractFeeCalcIngestStatementId { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public System.DateTime CreateDateTimeUtc { get; set; }
    
        public virtual ContractFeeCalcIngestStatements ContractFeeCalcIngestStatements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcReportLines> ContractFeeCalcReportLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcReportRevenue> ContractFeeCalcReportRevenue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcReportRevenueProjects> ContractFeeCalcReportRevenueProjects { get; set; }
    }
}
