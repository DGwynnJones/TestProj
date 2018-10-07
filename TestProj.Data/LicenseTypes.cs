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
    
    public partial class LicenseTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LicenseTypes()
        {
            this.ContractNetCards = new HashSet<ContractNetCards>();
            this.ProjectAltCardProjectAssignments = new HashSet<ProjectAltCardProjectAssignments>();
            this.ProjectAltCardProjectSelections = new HashSet<ProjectAltCardProjectSelections>();
            this.ContractCards = new HashSet<ContractCards>();
        }
    
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public int SortOrder { get; set; }
        public string AcquisitionAvailabilityEffect { get; set; }
        public string SaleAvailabilityEffect { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public string PrintName { get; set; }
        public string PrintShortCode { get; set; }
        public string LicenseBehavior { get; set; }
        public Nullable<bool> IsGrant { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractNetCards> ContractNetCards { get; set; }
        public virtual LicenseBehaviors LicenseBehaviors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectAltCardProjectAssignments> ProjectAltCardProjectAssignments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectAltCardProjectSelections> ProjectAltCardProjectSelections { get; set; }
        public virtual AvailabilityEffects AvailabilityEffects { get; set; }
        public virtual AvailabilityEffects AvailabilityEffects1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractCards> ContractCards { get; set; }
    }
}