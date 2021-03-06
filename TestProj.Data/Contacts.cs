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
    
    public partial class Contacts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contacts()
        {
            this.ContactAlternateNames = new HashSet<ContactAlternateNames>();
            this.ContactMethods = new HashSet<ContactMethods>();
            this.ContactRelationships = new HashSet<ContactRelationships>();
            this.ContactRelationships1 = new HashSet<ContactRelationships>();
            this.ContactRoles = new HashSet<ContactRoles>();
            this.Agreements = new HashSet<Agreements>();
            this.ContractParties = new HashSet<ContractParties>();
            this.ContractParties1 = new HashSet<ContractParties>();
            this.RoyaltyIngestStatements = new HashSet<RoyaltyIngestStatements>();
            this.ContractRoyaltyScheduleItems = new HashSet<ContractRoyaltyScheduleItems>();
            this.Contracts = new HashSet<Contracts>();
            this.Contracts1 = new HashSet<Contracts>();
            this.Contracts2 = new HashSet<Contracts>();
            this.Contracts3 = new HashSet<Contracts>();
            this.Contracts4 = new HashSet<Contracts>();
            this.DefaultContacts = new HashSet<DefaultContacts>();
            this.DefaultContacts1 = new HashSet<DefaultContacts>();
            this.DefaultContacts2 = new HashSet<DefaultContacts>();
            this.Investments = new HashSet<Investments>();
            this.InvestorPercentages = new HashSet<InvestorPercentages>();
            this.Invoices = new HashSet<Invoices>();
            this.PaymentDisbursements = new HashSet<PaymentDisbursements>();
            this.PaymentItems = new HashSet<PaymentItems>();
            this.Payments = new HashSet<Payments>();
        }
    
        public System.Guid Id { get; set; }
        public string LegalName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HonorificTitle { get; set; }
        public string JobTitle { get; set; }
        public string Website { get; set; }
        public string Code { get; set; }
        public string ContactInfo { get; set; }
        public string Notes { get; set; }
        public Nullable<System.Guid> BankId { get; set; }
        public string BankAccount { get; set; }
        public string VatNumber { get; set; }
        public string TaxId { get; set; }
        public string Color { get; set; }
        public string AreaCovered { get; set; }
        public string ShippingAccountNumber { get; set; }
        public string Rating { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.Guid> ContactAccountStatusTypeId { get; set; }
        public string SortName { get; set; }
        public int SortOrder { get; set; }
        public bool IsPerson { get; set; }
        public Nullable<int> LegacyPk { get; set; }
        public string LegacyPkText { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public Nullable<System.Guid> GLSubsetId { get; set; }
        public Nullable<System.Guid> DefaultRoyaltyIngestionMappingId { get; set; }
        public Nullable<System.Guid> DefaultFeeCalcIngestStatementTemplateId { get; set; }
    
        public virtual ContactAccountStatusTypes ContactAccountStatusTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactAlternateNames> ContactAlternateNames { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactMethods> ContactMethods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactRelationships> ContactRelationships { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactRelationships> ContactRelationships1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactRoles> ContactRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agreements> Agreements { get; set; }
        public virtual FeeCalcIngestStatementTemplates FeeCalcIngestStatementTemplates { get; set; }
        public virtual RoyaltyIngestionMappings RoyaltyIngestionMappings { get; set; }
        public virtual Subsets Subsets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractParties> ContractParties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractParties> ContractParties1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyIngestStatements> RoyaltyIngestStatements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyScheduleItems> ContractRoyaltyScheduleItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contracts> Contracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contracts> Contracts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contracts> Contracts2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contracts> Contracts3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contracts> Contracts4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DefaultContacts> DefaultContacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DefaultContacts> DefaultContacts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DefaultContacts> DefaultContacts2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Investments> Investments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvestorPercentages> InvestorPercentages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoices> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentDisbursements> PaymentDisbursements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentItems> PaymentItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
