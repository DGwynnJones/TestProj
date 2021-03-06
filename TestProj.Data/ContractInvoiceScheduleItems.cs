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
    
    public partial class ContractInvoiceScheduleItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractInvoiceScheduleItems()
        {
            this.ContractFeeCalcReportLines = new HashSet<ContractFeeCalcReportLines>();
            this.ContractInvoiceScheduleItemAllocations = new HashSet<ContractInvoiceScheduleItemAllocations>();
            this.ContractInvoiceScheduleItemFeeParameters = new HashSet<ContractInvoiceScheduleItemFeeParameters>();
            this.ContractInvoiceScheduleItemProjects = new HashSet<ContractInvoiceScheduleItemProjects>();
            this.ContractRoyaltyConsumptionHistory = new HashSet<ContractRoyaltyConsumptionHistory>();
            this.ContractRoyaltyConsumptionHistory1 = new HashSet<ContractRoyaltyConsumptionHistory>();
            this.Invoices = new HashSet<Invoices>();
            this.C_old_ContractInvoiceScheduleItemProjects = new HashSet<C_old_ContractInvoiceScheduleItemProjects>();
            this.ContractInvoiceScheduleItems1 = new HashSet<ContractInvoiceScheduleItems>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContractId { get; set; }
        public System.Guid ItemCategoryId { get; set; }
        public int Sequence { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<decimal> PercentOfGross { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public bool IsDueDateEstimated { get; set; }
        public bool IsDeposit { get; set; }
        public string Term { get; set; }
        public string Note { get; set; }
        public Nullable<int> LegacyPk { get; set; }
        public string LegacyPk2 { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public Nullable<System.Guid> ContractAllocationRuleId { get; set; }
        public bool IsSystemDefault { get; set; }
        public bool DisableInvoiceGeneration { get; set; }
        public string ItemCategorySystemCode { get; set; }
        public string RecurrenceTypeCode { get; set; }
        public Nullable<int> RecurrenceEvery { get; set; }
        public string RecurrenceDayOfWeek { get; set; }
        public string RecurrenceSequence { get; set; }
        public Nullable<System.Guid> ContractBillingGroupId { get; set; }
        public Nullable<System.DateTime> NoLaterThanDate { get; set; }
        public Nullable<int> RecurrenceCount { get; set; }
        public Nullable<System.Guid> ContractProjectCategoryId { get; set; }
        public Nullable<byte> RecurrenceMonth { get; set; }
        public Nullable<byte> RecurrenceDayOfMonth { get; set; }
        public Nullable<System.Guid> OriginalId { get; set; }
        public string FeeParameterAggregateOperationCode { get; set; }
        public string FeeCalcGuaranteeEvaluationOrderCode { get; set; }
        public bool AreFeeCalcResultsBilledOnStatement { get; set; }
        public string FeeCalcReallocationMethodCode { get; set; }
        public Nullable<byte> FeeCalcDayThreshold { get; set; }
        public bool RecurrenceUsesDateTrigger { get; set; }
        public Nullable<decimal> RecurrenceLastAmount { get; set; }
        public bool ForceLastStatementToUseEndDate { get; set; }
        public bool ProrateFirstAndLastStatement { get; set; }
    
        public virtual ContractAllocationRules ContractAllocationRules { get; set; }
        public virtual ContractBillingGroups ContractBillingGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcReportLines> ContractFeeCalcReportLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItemAllocations> ContractInvoiceScheduleItemAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItemFeeParameters> ContractInvoiceScheduleItemFeeParameters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItemProjects> ContractInvoiceScheduleItemProjects { get; set; }
        public virtual ContractProjectCategories ContractProjectCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyConsumptionHistory> ContractRoyaltyConsumptionHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyConsumptionHistory> ContractRoyaltyConsumptionHistory1 { get; set; }
        public virtual Currencies Currencies { get; set; }
        public virtual FeeCalcAggregateOperations FeeCalcAggregateOperations { get; set; }
        public virtual FeeCalcGuaranteeEvaluationOrder FeeCalcGuaranteeEvaluationOrder { get; set; }
        public virtual FeeCalcReallocationMethods FeeCalcReallocationMethods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual RecurrenceDaysOfWeek RecurrenceDaysOfWeek { get; set; }
        public virtual RecurrenceMonthlySequences RecurrenceMonthlySequences { get; set; }
        public virtual RecurrenceTypes RecurrenceTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_old_ContractInvoiceScheduleItemProjects> C_old_ContractInvoiceScheduleItemProjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItems> ContractInvoiceScheduleItems1 { get; set; }
        public virtual ContractInvoiceScheduleItems ContractInvoiceScheduleItems2 { get; set; }
        public virtual Contracts Contracts { get; set; }
    }
}
