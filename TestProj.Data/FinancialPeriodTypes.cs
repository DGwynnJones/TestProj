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
    
    public partial class FinancialPeriodTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FinancialPeriodTypes()
        {
            this.LedgerItems = new HashSet<LedgerItems>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public int MonthStart { get; set; }
        public int MonthEnd { get; set; }
        public int Year { get; set; }
        public int SortOrder { get; set; }
        public int YearEnd { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LedgerItems> LedgerItems { get; set; }
    }
}