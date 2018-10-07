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
    
    public partial class ContractProjectTelecastSchedules
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractProjectTelecastSchedules()
        {
            this.ContractProjectTelecastScheduleTerritories = new HashSet<ContractProjectTelecastScheduleTerritories>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContractId { get; set; }
        public System.Guid ProjectId { get; set; }
        public Nullable<System.DateTime> TelecastDate { get; set; }
        public Nullable<System.DateTime> TimeSlot { get; set; }
        public int RunSequence { get; set; }
        public string LicensedService { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public Nullable<decimal> TotalShare { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractProjectTelecastScheduleTerritories> ContractProjectTelecastScheduleTerritories { get; set; }
        public virtual Contracts Contracts { get; set; }
    }
}
