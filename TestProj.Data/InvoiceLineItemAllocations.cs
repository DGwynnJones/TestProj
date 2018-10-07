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
    
    public partial class InvoiceLineItemAllocations
    {
        public System.Guid Id { get; set; }
        public System.Guid InvoiceLineItemId { get; set; }
        public System.Guid ProjectId { get; set; }
        public Nullable<System.Guid> RightId { get; set; }
        public Nullable<System.Guid> TerritoryId { get; set; }
        public Nullable<System.Guid> ChannelId { get; set; }
        public string LanguageCode { get; set; }
        public decimal Amount { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public decimal AmountBaseCurrency { get; set; }
        public Nullable<System.Guid> ProjectCategoryId { get; set; }
    
        public virtual Channels Channels { get; set; }
        public virtual Languages Languages { get; set; }
        public virtual ProjectCategories ProjectCategories { get; set; }
        public virtual Rights Rights { get; set; }
        public virtual Territories Territories { get; set; }
        public virtual InvoiceLineItems InvoiceLineItems { get; set; }
    }
}