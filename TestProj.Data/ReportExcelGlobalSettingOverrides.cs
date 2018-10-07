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
    
    public partial class ReportExcelGlobalSettingOverrides
    {
        public System.Guid ReportId { get; set; }
        public Nullable<double> TopMargin { get; set; }
        public Nullable<double> LeftMargin { get; set; }
        public Nullable<double> BottomMargin { get; set; }
        public Nullable<double> RightMargin { get; set; }
        public Nullable<int> PaperSize { get; set; }
        public Nullable<int> Orientation { get; set; }
        public Nullable<int> FitToPagesWide { get; set; }
        public Nullable<int> FitToPagesTall { get; set; }
        public Nullable<int> Zoom { get; set; }
        public Nullable<bool> PrintGridlines { get; set; }
        public Nullable<bool> PrintHeadings { get; set; }
        public string LeftHeader { get; set; }
        public string CenterHeader { get; set; }
        public string RightHeader { get; set; }
        public string LeftFooter { get; set; }
        public string CenterFooter { get; set; }
        public string RightFooter { get; set; }
        public string PrintTitleColumns { get; set; }
        public string PrintTitleRows { get; set; }
        public string FontName { get; set; }
        public Nullable<int> FontSize { get; set; }
        public string DateFormat { get; set; }
        public Nullable<int> RowHeight { get; set; }
        public Nullable<int> DynamicColumnHeaderRotation { get; set; }
        public string LastStaticColumnName { get; set; }
        public string SortExpression { get; set; }
        public string GroupExpression { get; set; }
        public Nullable<bool> IncludeTotals { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public Nullable<bool> CenterHorizontally { get; set; }
        public Nullable<bool> CenterVertically { get; set; }
        public string WorksheetColumnName { get; set; }
        public string FreezePaneColumnName { get; set; }
        public bool ShowReportLogo { get; set; }
        public bool ShowUnmergedHeaders { get; set; }
    
        public virtual ExcelPaperOrientations ExcelPaperOrientations { get; set; }
        public virtual ExcelPaperSizes ExcelPaperSizes { get; set; }
        public virtual Reports Reports { get; set; }
    }
}
