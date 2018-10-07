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
    
    public partial class C_old_Contacts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_old_Contacts()
        {
            this.Agreements = new HashSet<Agreements>();
        }
    
        public System.Guid Id { get; set; }
        public string RoleCode { get; set; }
        public string CompanyName { get; set; }
        public string Alias { get; set; }
        public string Honorific { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string JobTitle { get; set; }
        public int SortOrder { get; set; }
        public string Note { get; set; }
        public Nullable<int> LegacyPk { get; set; }
        public string AccountNo { get; set; }
        public string ShippingStreet { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingCountry { get; set; }
        public string VatCountry { get; set; }
        public string VatNumber { get; set; }
        public string AreaCovered { get; set; }
        public string LegacyPkText { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public string ShippingContactNote { get; set; }
        public string LegalContactNote { get; set; }
        public string FinanceContactNote { get; set; }
        public string Rating { get; set; }
        public string ContactCode { get; set; }
        public string TaxID { get; set; }
        public Nullable<System.Guid> BankId { get; set; }
        public string BankAccount { get; set; }
        public string Color { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agreements> Agreements { get; set; }
    }
}
