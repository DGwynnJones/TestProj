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
    
    public partial class ReportExcelConditionalFormatSettings
    {
        public System.Guid ReportId { get; set; }
        public string ColumnName { get; set; }
        public string FormatConditionType { get; set; }
        public string OperatorType { get; set; }
        public string Formula1 { get; set; }
        public string Formula2 { get; set; }
        public string FillColor { get; set; }
        public string FontColor { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool Underline { get; set; }
        public System.Guid Id { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual ReportExcelFormatConditionTypes ReportExcelFormatConditionTypes { get; set; }
        public virtual ReportExcelFormatOperatorTypes ReportExcelFormatOperatorTypes { get; set; }
        public virtual Reports Reports { get; set; }
    }
}
