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
    
    public partial class ContractLedgerTempImport
    {
        public int ID { get; set; }
        public System.Guid SessionID { get; set; }
        public int ExternalIdentifier { get; set; }
        public string ExternalArea { get; set; }
        public string ExternalCategory { get; set; }
        public string ExternalTitle { get; set; }
        public string ExternalLocalCurrencyAmount { get; set; }
        public string ExternalBaseCurrencyAmount { get; set; }
        public string ExternalRight { get; set; }
        public string ExternalCurrency { get; set; }
        public Nullable<System.Guid> AreaID { get; set; }
        public Nullable<System.Guid> CategoryID { get; set; }
        public Nullable<System.Guid> ProjectID { get; set; }
        public Nullable<System.Guid> RightID { get; set; }
        public string Currency { get; set; }
        public Nullable<decimal> LocalCurrencyAmount { get; set; }
        public Nullable<decimal> BaseCurrencyAmount { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    }
}