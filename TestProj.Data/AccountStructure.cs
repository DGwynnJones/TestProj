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
    
    public partial class AccountStructure
    {
        public System.Guid Id { get; set; }
        public int SegmentNumber { get; set; }
        public string SubsetSourceCode { get; set; }
        public string SegmentName { get; set; }
        public string SegmentHeading { get; set; }
        public int SegmentLength { get; set; }
        public bool IsRightJustified { get; set; }
        public bool IsZeroFilled { get; set; }
        public Nullable<int> LegacyPk { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual SubsetSources SubsetSources { get; set; }
    }
}
