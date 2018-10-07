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
    
    public partial class Territories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Territories()
        {
            this.ContractAllocationRuleTerritories = new HashSet<ContractAllocationRuleTerritories>();
            this.ContractBillingGroupTerritories = new HashSet<ContractBillingGroupTerritories>();
            this.ContractCardExclusionTerritoryAssignments = new HashSet<ContractCardExclusionTerritoryAssignments>();
            this.ContractCardTerritoryAssignments = new HashSet<ContractCardTerritoryAssignments>();
            this.ContractFeeCalcReportLineAllocations = new HashSet<ContractFeeCalcReportLineAllocations>();
            this.ContractFeeCalcReportRevenueProjectAllocations = new HashSet<ContractFeeCalcReportRevenueProjectAllocations>();
            this.ContractInvoiceScheduleItemAllocations = new HashSet<ContractInvoiceScheduleItemAllocations>();
            this.ContractNetCardTerritoryAssignments = new HashSet<ContractNetCardTerritoryAssignments>();
            this.ContractProjectTelecastScheduleTerritories = new HashSet<ContractProjectTelecastScheduleTerritories>();
            this.ContractRevenueAllocations = new HashSet<ContractRevenueAllocations>();
            this.ContractRevenueCardAllocations = new HashSet<ContractRevenueCardAllocations>();
            this.ContractRoyaltyDeductionRuleTerritories = new HashSet<ContractRoyaltyDeductionRuleTerritories>();
            this.ContractRoyaltyDefinitionTerritories = new HashSet<ContractRoyaltyDefinitionTerritories>();
            this.ContractTimelineItemTerritories = new HashSet<ContractTimelineItemTerritories>();
            this.InvoiceLineItemAllocations = new HashSet<InvoiceLineItemAllocations>();
            this.ParticipationsActivityLines = new HashSet<ParticipationsActivityLines>();
            this.ParticipationsReportLineShares = new HashSet<ParticipationsReportLineShares>();
            this.ProjectAltCardTerritoryAssignments = new HashSet<ProjectAltCardTerritoryAssignments>();
            this.RoyaltyIngestStatementLines = new HashSet<RoyaltyIngestStatementLines>();
            this.RoyaltyReportLines = new HashSet<RoyaltyReportLines>();
            this.RoyaltyReportLineShares = new HashSet<RoyaltyReportLineShares>();
            this.TerritoryLanguageMembers = new HashSet<TerritoryLanguageMembers>();
            this.TerritoryMembers = new HashSet<TerritoryMembers>();
            this.TerritoryMembers1 = new HashSet<TerritoryMembers>();
            this.TerritoryRelations = new HashSet<TerritoryRelations>();
            this.TerritoryRelations1 = new HashSet<TerritoryRelations>();
            this.TerritoryRoles = new HashSet<TerritoryRoles>();
            this.ContractReleaseTerritories = new HashSet<ContractReleaseTerritories>();
            this.ContractReportingRegions = new HashSet<ContractReportingRegions>();
            this.ContractRoyaltyTerritories = new HashSet<ContractRoyaltyTerritories>();
            this.RegionAskingPrices = new HashSet<RegionAskingPrices>();
            this.TerritoryAskingPrices = new HashSet<TerritoryAskingPrices>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public int SortOrder { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public decimal RelativeWeight { get; set; }
        public Nullable<System.Guid> RegionZoneId { get; set; }
        public string DvDRegionCodeList { get; set; }
        public Nullable<int> LegacyPkInt { get; set; }
        public Nullable<System.Guid> LegacyPkGuid { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public bool IsActive { get; set; }
        public string TypeCode { get; set; }
        public Nullable<System.Guid> GLSubsetId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractAllocationRuleTerritories> ContractAllocationRuleTerritories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractBillingGroupTerritories> ContractBillingGroupTerritories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractCardExclusionTerritoryAssignments> ContractCardExclusionTerritoryAssignments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractCardTerritoryAssignments> ContractCardTerritoryAssignments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcReportLineAllocations> ContractFeeCalcReportLineAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcReportRevenueProjectAllocations> ContractFeeCalcReportRevenueProjectAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractInvoiceScheduleItemAllocations> ContractInvoiceScheduleItemAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractNetCardTerritoryAssignments> ContractNetCardTerritoryAssignments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractProjectTelecastScheduleTerritories> ContractProjectTelecastScheduleTerritories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRevenueAllocations> ContractRevenueAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRevenueCardAllocations> ContractRevenueCardAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDeductionRuleTerritories> ContractRoyaltyDeductionRuleTerritories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDefinitionTerritories> ContractRoyaltyDefinitionTerritories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractTimelineItemTerritories> ContractTimelineItemTerritories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceLineItemAllocations> InvoiceLineItemAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipationsActivityLines> ParticipationsActivityLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipationsReportLineShares> ParticipationsReportLineShares { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectAltCardTerritoryAssignments> ProjectAltCardTerritoryAssignments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyIngestStatementLines> RoyaltyIngestStatementLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyReportLines> RoyaltyReportLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyReportLineShares> RoyaltyReportLineShares { get; set; }
        public virtual Subsets Subsets { get; set; }
        public virtual RegionZones RegionZones { get; set; }
        public virtual TerritoryTypeCodes TerritoryTypeCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerritoryLanguageMembers> TerritoryLanguageMembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerritoryMembers> TerritoryMembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerritoryMembers> TerritoryMembers1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerritoryRelations> TerritoryRelations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerritoryRelations> TerritoryRelations1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerritoryRoles> TerritoryRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractReleaseTerritories> ContractReleaseTerritories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractReportingRegions> ContractReportingRegions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyTerritories> ContractRoyaltyTerritories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegionAskingPrices> RegionAskingPrices { get; set; }
        public virtual SystemUndeletableIds SystemUndeletableIds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerritoryAskingPrices> TerritoryAskingPrices { get; set; }
    }
}