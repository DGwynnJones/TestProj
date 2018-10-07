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
    
    public partial class ParticipationsReports
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParticipationsReports()
        {
            this.ParticipationsReportLines = new HashSet<ParticipationsReportLines>();
            this.ParticipationsStatementReports = new HashSet<ParticipationsStatementReports>();
        }
    
        public System.Guid Id { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string ReportNumber { get; set; }
        public decimal ExchangeRate { get; set; }
        public Nullable<int> LegacyPk { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public System.Guid ContractVersionSetId { get; set; }
    
        public virtual ContractVersionSets ContractVersionSets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipationsReportLines> ParticipationsReportLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipationsStatementReports> ParticipationsStatementReports { get; set; }
    }
}