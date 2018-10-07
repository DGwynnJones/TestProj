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
    
    public partial class Invoices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoices()
        {
            this.ContractRoyaltyConsumptionHistory = new HashSet<ContractRoyaltyConsumptionHistory>();
            this.ContractRoyaltyConsumptionHistory1 = new HashSet<ContractRoyaltyConsumptionHistory>();
            this.Invoices1 = new HashSet<Invoices>();
            this.ParticipationsStatements = new HashSet<ParticipationsStatements>();
            this.RoyaltyReports = new HashSet<RoyaltyReports>();
            this.SavedSearchInvoices = new HashSet<SavedSearchInvoices>();
            this.InvoiceActionLogEntries = new HashSet<InvoiceActionLogEntries>();
            this.InvoiceLineItems = new HashSet<InvoiceLineItems>();
            this.WorkflowTransitionAttempts = new HashSet<WorkflowTransitionAttempts>();
        }
    
        public System.Guid Id { get; set; }
        public string SupportCode { get; set; }
        public string InvoiceNo { get; set; }
        public System.Guid ContactId { get; set; }
        public Nullable<System.Guid> ContractInvoiceScheduleItemId { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<System.DateTime> SentDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string BillToInfo { get; set; }
        public string Term { get; set; }
        public string Note { get; set; }
        public string SpecialInstructions { get; set; }
        public Nullable<int> LegacyPk { get; set; }
        public string LegacyPk2 { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public Nullable<System.Guid> BankId { get; set; }
        public string BankAccountNo { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool IsVoid { get; set; }
        public Nullable<System.DateTime> LockDate { get; set; }
        public Nullable<System.Guid> WorkflowStateId { get; set; }
        public string ValidationTargetTypeCode { get; set; }
        public Nullable<bool> ConsolidateInvoice { get; set; }
        public string ConsolidatedInvoiceDescription { get; set; }
        public bool IsEstimatedDueDate { get; set; }
        public Nullable<System.Guid> TaxTypeId { get; set; }
        public decimal TaxRate { get; set; }
        public decimal ExchangeRate { get; set; }
        public Nullable<System.Guid> ContractVersionSetId { get; set; }
        public Nullable<System.Guid> ApplyToInvoiceId { get; set; }
        public Nullable<System.DateTime> PostedDateUTC { get; set; }
        public bool IsTransitioning { get; set; }
    
        public virtual Contacts Contacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyConsumptionHistory> ContractRoyaltyConsumptionHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyConsumptionHistory> ContractRoyaltyConsumptionHistory1 { get; set; }
        public virtual ContractVersionSets ContractVersionSets { get; set; }
        public virtual Currencies Currencies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoices> Invoices1 { get; set; }
        public virtual Invoices Invoices2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipationsStatements> ParticipationsStatements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyReports> RoyaltyReports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SavedSearchInvoices> SavedSearchInvoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceActionLogEntries> InvoiceActionLogEntries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceLineItems> InvoiceLineItems { get; set; }
        public virtual TargetTypes TargetTypes { get; set; }
        public virtual TaxTypes TaxTypes { get; set; }
        public virtual ContractInvoiceScheduleItems ContractInvoiceScheduleItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkflowTransitionAttempts> WorkflowTransitionAttempts { get; set; }
    }
}
