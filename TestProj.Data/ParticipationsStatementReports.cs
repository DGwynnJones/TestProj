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
    
    public partial class ParticipationsStatementReports
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParticipationsStatementReports()
        {
            this.ParticipationsStatementReportLines = new HashSet<ParticipationsStatementReportLines>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ParticipationsStatementId { get; set; }
        public System.Guid ParticipationsReportId { get; set; }
        public Nullable<int> LegacyPk { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual ParticipationsReports ParticipationsReports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipationsStatementReportLines> ParticipationsStatementReportLines { get; set; }
        public virtual ParticipationsStatements ParticipationsStatements { get; set; }
    }
}
