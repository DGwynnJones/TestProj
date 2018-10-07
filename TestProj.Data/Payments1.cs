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
    
    public partial class Payments1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payments1()
        {
            this.PaymentItems = new HashSet<PaymentItems>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid AgreementId { get; set; }
        public int PaymentID { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public Nullable<bool> ThridPartyOriginator { get; set; }
        public string Note { get; set; }
        public System.DateTime ActionedDate { get; set; }
        public string ActionedBy { get; set; }
        public string DisbursementSupportCode { get; set; }
        public Nullable<System.Guid> ReversalPaymentId { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual Agreements Agreements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentItems> PaymentItems { get; set; }
    }
}