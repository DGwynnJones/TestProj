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
    
    public partial class InvoiceLineItemPaymentSplits
    {
        public System.Guid Id { get; set; }
        public System.Guid InvoiceLineItemPaymentId { get; set; }
        public System.Guid ItemCategoryId { get; set; }
        public decimal BaseCurrencyAmount { get; set; }
        public string Note { get; set; }
        public decimal Amount { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual InvoiceItemCategories InvoiceItemCategories { get; set; }
        public virtual InvoiceLineItemPayments InvoiceLineItemPayments { get; set; }
    }
}
