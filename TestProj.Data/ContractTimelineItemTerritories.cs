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
    
    public partial class ContractTimelineItemTerritories
    {
        public System.Guid Id { get; set; }
        public System.Guid ContractTimelineItemId { get; set; }
        public System.Guid TerritoryId { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual ContractTimelineItems ContractTimelineItems { get; set; }
        public virtual Territories Territories { get; set; }
    }
}