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
    
    public partial class Currencies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Currencies()
        {
            this.ContractAllocationRules = new HashSet<ContractAllocationRules>();
            this.ContractLedgerStatementCurrencyMapping = new HashSet<ContractLedgerStatementCurrencyMapping>();
            this.ContractLedgerStatementItems = new HashSet<ContractLedgerStatementItems>();
            this.ExchangeRates = new HashSet<ExchangeRates>();
            this.ExchangeRates1 = new HashSet<ExchangeRates>();
            this.RoyaltyIngestStatements = new HashSet<RoyaltyIngestStatements>();
            this.RoyaltyReports = new HashSet<RoyaltyReports>();
            this.ContractInvoiceScheduleItems = new HashSet<ContractInvoiceScheduleItems>();
            this.ContractReleaseData = new HashSet<ContractReleaseData>();
            this.ContractRoyaltyScheduleItemDetail = new HashSet<ContractRoyaltyScheduleItemDetail>();
            this.Contracts = new HashSet<Contracts>();
            this.Invoices = new HashSet<Invoices>();
            this.Payments = new HashSet<Payments>();
            this.RegionAskingPrices = new HashSet<RegionAskingPrices>();
            this.TerritoryAskingPrices = new HashSet<TerritoryAskingPrices>();
        }
    
        public string ISOCode { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public string Symbol { get; set; }
        public Nullable<int> LegacyPk { get; set; }
        public System.Guid AuditId { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractAllocationRules> ContractAllocationRules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractLedgerStatementCurrencyMapping> ContractLedgerStatementCurrencyMapping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractLedgerStatementItems> ContractLedgerStatementItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExchangeRates> ExchangeRates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExchangeRates> ExchangeRates1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyIngestStatements> RoyaltyIngestStatements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyReports> RoyaltyReports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItems> ContractInvoiceScheduleItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractReleaseData> ContractReleaseData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyScheduleItemDetail> ContractRoyaltyScheduleItemDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contracts> Contracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoices> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payments> Payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegionAskingPrices> RegionAskingPrices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerritoryAskingPrices> TerritoryAskingPrices { get; set; }
    }
}