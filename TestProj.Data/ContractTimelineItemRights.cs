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
    
    public partial class ContractTimelineItemRights
    {
        public System.Guid Id { get; set; }
        public System.Guid ContractTimelineItemId { get; set; }
        public System.Guid RightId { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual Rights Rights { get; set; }
        public virtual ContractTimelineItems ContractTimelineItems { get; set; }
    }
}
