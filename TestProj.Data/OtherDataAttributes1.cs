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
    
    public partial class OtherDataAttributes1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OtherDataAttributes1()
        {
            this.OtherDataAttributeValues1 = new HashSet<OtherDataAttributeValues1>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid OtherDataAttributeSetId { get; set; }
        public string DataType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BookmarkName { get; set; }
        public int SortOrder { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual OtherDataAttributeSets1 OtherDataAttributeSets1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherDataAttributeValues1> OtherDataAttributeValues1 { get; set; }
    }
}
