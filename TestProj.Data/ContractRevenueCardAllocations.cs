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
    
    public partial class ContractRevenueCardAllocations
    {
        public System.Guid Id { get; set; }
        public System.Guid ContractRevenueCardId { get; set; }
        public System.Guid ProjectId { get; set; }
        public Nullable<System.Guid> RightId { get; set; }
        public Nullable<System.Guid> TerritoryId { get; set; }
        public Nullable<System.Guid> ChannelId { get; set; }
        public string LanguageCode { get; set; }
        public decimal Amount { get; set; }
        public Nullable<decimal> AmountBaseCurrency { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<System.DateTime> RecognitionDate { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual Channels Channels { get; set; }
        public virtual Languages Languages { get; set; }
        public virtual ContractRevenueCards ContractRevenueCards { get; set; }
        public virtual Rights Rights { get; set; }
        public virtual Territories Territories { get; set; }
    }
}
