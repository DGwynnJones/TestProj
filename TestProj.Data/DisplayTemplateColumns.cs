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
    
    public partial class DisplayTemplateColumns
    {
        public System.Guid Id { get; set; }
        public System.Guid DisplayTemplateId { get; set; }
        public System.Guid FieldId { get; set; }
        public string DisplayName { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual DisplayTemplates DisplayTemplates { get; set; }
        public virtual Fields Fields { get; set; }
    }
}