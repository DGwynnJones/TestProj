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
    
    public partial class ParticipationsReportLineShareReserves
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParticipationsReportLineShareReserves()
        {
            this.ParticipationsReportLineValues = new HashSet<ParticipationsReportLineValues>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ParticipationsReportLineShareId { get; set; }
        public System.Guid ParticipationsReserveTypeId { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountBaseCurrency { get; set; }
        public System.DateTime ReleaseAfter { get; set; }
        public bool IsReleased { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual ParticipationsReportLineShares ParticipationsReportLineShares { get; set; }
        public virtual ParticipationsReserveTypes ParticipationsReserveTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipationsReportLineValues> ParticipationsReportLineValues { get; set; }
    }
}
