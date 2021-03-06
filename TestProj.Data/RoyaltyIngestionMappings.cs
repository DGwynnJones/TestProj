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
    
    public partial class RoyaltyIngestionMappings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoyaltyIngestionMappings()
        {
            this.Contacts = new HashSet<Contacts>();
            this.RoyaltyIngestionMappingColumns = new HashSet<RoyaltyIngestionMappingColumns>();
            this.RoyaltyIngestionMappingTranslations = new HashSet<RoyaltyIngestionMappingTranslations>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public int SheetNumber { get; set; }
        public int StartingRow { get; set; }
        public bool UseEndingRow { get; set; }
        public Nullable<int> EndingRow { get; set; }
        public int BlankLineLimit { get; set; }
        public bool HoldAll { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public bool IsDefault { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contacts> Contacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyIngestionMappingColumns> RoyaltyIngestionMappingColumns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyIngestionMappingTranslations> RoyaltyIngestionMappingTranslations { get; set; }
    }
}
