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
    
    public partial class ReportAvailableCriteriaTypes
    {
        public System.Guid ReportId { get; set; }
        public string CriteriaTypeName { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public string Description { get; set; }
        public bool IsMutuallyExclusive { get; set; }
        public bool IsExcludeFilter { get; set; }
    
        public virtual ReportCriteriaTypes ReportCriteriaTypes { get; set; }
        public virtual Reports Reports { get; set; }
    }
}