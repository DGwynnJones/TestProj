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
    
    public partial class ReportCriteriaDefaults
    {
        public System.Guid Id { get; set; }
        public System.Guid CriteriaSetId { get; set; }
        public string CriteriaType { get; set; }
        public System.Guid GuidValue { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public bool Exclude { get; set; }
        public string ExtraData { get; set; }
    
        public virtual ReportCriteriaDefaultSets ReportCriteriaDefaultSets { get; set; }
        public virtual ReportCriteriaTypes ReportCriteriaTypes { get; set; }
    }
}
