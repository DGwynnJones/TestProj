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
    
    public partial class Payments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payments()
        {
            this.InvoiceLineItemPayments = new HashSet<InvoiceLineItemPayments>();
            this.PaymentDisbursements = new HashSet<PaymentDisbursements>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContactId { get; set; }
        public Nullable<System.Guid> GLAccountId { get; set; }
        public string TrackingData { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal BaseCurrencyAmount { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
        public Nullable<System.DateTime> ClearedDate { get; set; }
        public string Note { get; set; }
        public Nullable<int> LegacyPk { get; set; }
        public bool IsCredit { get; set; }
        public string DocumentNo { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string SupportCode { get; set; }
        public Nullable<System.Guid> BankId { get; set; }
        public string BankAccountNo { get; set; }
        public Nullable<System.DateTime> LockDate { get; set; }
        public bool IsReadyForSubmission { get; set; }
    
        public virtual Contacts Contacts { get; set; }
        public virtual Currencies Currencies { get; set; }
        public virtual GLAccounts GLAccounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceLineItemPayments> InvoiceLineItemPayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentDisbursements> PaymentDisbursements { get; set; }
    }
}