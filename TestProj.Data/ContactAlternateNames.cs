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
    
    public partial class ContactAlternateNames
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContactAlternateNames()
        {
            this.ContractParties = new HashSet<ContractParties>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContactId { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual Contacts Contacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractParties> ContractParties { get; set; }
    }
}
