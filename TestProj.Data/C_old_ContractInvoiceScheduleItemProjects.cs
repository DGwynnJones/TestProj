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
    
    public partial class C_old_ContractInvoiceScheduleItemProjects
    {
        public System.Guid ContractInvoiceScheduleItemId { get; set; }
        public System.Guid ProjectId { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public Nullable<System.Guid> InvoiceLineItemId { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<decimal> AllocationAmount { get; set; }
    
        public virtual ContractInvoiceScheduleItems ContractInvoiceScheduleItems { get; set; }
        public virtual InvoiceLineItems InvoiceLineItems { get; set; }
    }
}
