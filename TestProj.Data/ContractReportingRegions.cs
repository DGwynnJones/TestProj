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
    
    public partial class ContractReportingRegions
    {
        public System.Guid Id { get; set; }
        public System.Guid ContractId { get; set; }
        public System.Guid RegionId { get; set; }
        public Nullable<decimal> Allocation { get; set; }
        public int SortOrder { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual Territories Territories { get; set; }
        public virtual Contracts Contracts { get; set; }
    }
}
