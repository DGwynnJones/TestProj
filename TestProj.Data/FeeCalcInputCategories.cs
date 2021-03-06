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
    
    public partial class FeeCalcInputCategories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FeeCalcInputCategories()
        {
            this.ContractFeeCalcIngestStatementInputValues = new HashSet<ContractFeeCalcIngestStatementInputValues>();
            this.ContractFeeCalcInputs = new HashSet<ContractFeeCalcInputs>();
            this.ContractInvoiceScheduleItemProjectFeeCalcInputCategories = new HashSet<ContractInvoiceScheduleItemProjectFeeCalcInputCategories>();
            this.FeeCalcIngestStatementTemplateInputs = new HashSet<FeeCalcIngestStatementTemplateInputs>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcIngestStatementInputValues> ContractFeeCalcIngestStatementInputValues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcInputs> ContractFeeCalcInputs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItemProjectFeeCalcInputCategories> ContractInvoiceScheduleItemProjectFeeCalcInputCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeeCalcIngestStatementTemplateInputs> FeeCalcIngestStatementTemplateInputs { get; set; }
    }
}
