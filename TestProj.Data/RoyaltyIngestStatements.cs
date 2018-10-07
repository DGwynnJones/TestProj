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
    
    public partial class RoyaltyIngestStatements
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoyaltyIngestStatements()
        {
            this.RoyaltyIngestStatementLines = new HashSet<RoyaltyIngestStatementLines>();
            this.RoyaltyReports = new HashSet<RoyaltyReports>();
        }
    
        public System.Guid Id { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string ReportingCurrencyCode { get; set; }
        public decimal ReportingCurrencyExchangeRate { get; set; }
        public Nullable<decimal> ContractCurrencyExchangeRate { get; set; }
        public decimal ReportedOurshareAmount { get; set; }
        public bool IsStatementComplete { get; set; }
        public System.DateTime CreatedDateTimeUtc { get; set; }
        public string UploadFormat { get; set; }
        public string SourceFileName { get; set; }
        public string BatchNumber { get; set; }
        public Nullable<System.Guid> LicenseeId { get; set; }
        public bool IsProcessing { get; set; }
        public Nullable<System.DateTime> ProcessedDateTimeUtc { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual Contacts Contacts { get; set; }
        public virtual Currencies Currencies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyIngestStatementLines> RoyaltyIngestStatementLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyReports> RoyaltyReports { get; set; }
    }
}
