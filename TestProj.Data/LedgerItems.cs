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
    
    public partial class LedgerItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LedgerItems()
        {
            this.PaymentItemReceipts = new HashSet<PaymentItemReceipts>();
        }
    
        public System.Guid Id { get; set; }
        public string LedgerTypeCode { get; set; }
        public System.Guid AgreementId { get; set; }
        public System.Guid FinancialPeriodTypeId { get; set; }
        public Nullable<System.DateTime> FinancialReportDate { get; set; }
        public Nullable<System.DateTime> PeriodEndDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public Nullable<System.Guid> InvestmentLedgerItemCategoryId { get; set; }
        public Nullable<System.Guid> InvestmentLedgerSourceTypeId { get; set; }
        public string Source { get; set; }
        public decimal Amount { get; set; }
        public decimal Tax { get; set; }
        public string PaymentNumber { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
        public Nullable<System.DateTime> ReconciledDate { get; set; }
        public string DisbursementSupportCode { get; set; }
        public string Note { get; set; }
        public bool IsExcludedFromPayments { get; set; }
        public string ReversalDisbursementCode { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public Nullable<System.Guid> AdjustedPaymentId { get; set; }
        public Nullable<System.Guid> ContractVersionSetId { get; set; }
    
        public virtual ContractVersionSets ContractVersionSets { get; set; }
        public virtual Agreements Agreements { get; set; }
        public virtual FinancialPeriodTypes FinancialPeriodTypes { get; set; }
        public virtual LedgerCategories LedgerCategories { get; set; }
        public virtual PaymentItems PaymentItems { get; set; }
        public virtual LedgerSourceTypes LedgerSourceTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentItemReceipts> PaymentItemReceipts { get; set; }
    }
}
