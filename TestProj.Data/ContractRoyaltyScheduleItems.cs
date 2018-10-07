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
    
    public partial class ContractRoyaltyScheduleItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractRoyaltyScheduleItems()
        {
            this.ContractRoyaltyScheduleItemDetail = new HashSet<ContractRoyaltyScheduleItemDetail>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid RoyaltyId { get; set; }
        public int Sequence { get; set; }
        public System.DateTime ReportDueDate { get; set; }
        public Nullable<System.DateTime> ChasedDate { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public System.Guid VendorId { get; set; }
        public Nullable<System.Guid> RightGroupId { get; set; }
    
        public virtual Contacts Contacts { get; set; }
        public virtual Rights Rights { get; set; }
        public virtual ContractRoyaltyData ContractRoyaltyData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyScheduleItemDetail> ContractRoyaltyScheduleItemDetail { get; set; }
    }
}
