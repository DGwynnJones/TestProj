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
    
    public partial class ContractRoyaltyData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractRoyaltyData()
        {
            this.ContractRoyaltyProjects = new HashSet<ContractRoyaltyProjects>();
            this.ContractRoyaltyScheduleItems = new HashSet<ContractRoyaltyScheduleItems>();
            this.ContractRoyaltyTerritories = new HashSet<ContractRoyaltyTerritories>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContractId { get; set; }
        public string TabName { get; set; }
        public System.DateTime StartDate { get; set; }
        public int FrequencyCount { get; set; }
        public string FrequencyType { get; set; }
        public string Note { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual Contracts Contracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyProjects> ContractRoyaltyProjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyScheduleItems> ContractRoyaltyScheduleItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyTerritories> ContractRoyaltyTerritories { get; set; }
    }
}
