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
    
    public partial class ContractRoyaltyDefinitions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractRoyaltyDefinitions()
        {
            this.ContractRoyaltyDefinitionAttributeSets = new HashSet<ContractRoyaltyDefinitionAttributeSets>();
            this.ContractRoyaltyDefinitionChannels = new HashSet<ContractRoyaltyDefinitionChannels>();
            this.ContractRoyaltyDefinitionLanguages = new HashSet<ContractRoyaltyDefinitionLanguages>();
            this.ContractRoyaltyDefinitionProjects = new HashSet<ContractRoyaltyDefinitionProjects>();
            this.ContractRoyaltyDefinitionReserves = new HashSet<ContractRoyaltyDefinitionReserves>();
            this.ContractRoyaltyDefinitionRights = new HashSet<ContractRoyaltyDefinitionRights>();
            this.ContractRoyaltyDefinitions1 = new HashSet<ContractRoyaltyDefinitions>();
            this.ContractRoyaltyDefinitionTerritories = new HashSet<ContractRoyaltyDefinitionTerritories>();
            this.ContractRoyaltyDefinitionTiers = new HashSet<ContractRoyaltyDefinitionTiers>();
            this.ParticipationsReportLines = new HashSet<ParticipationsReportLines>();
            this.ParticipationsReportLines1 = new HashSet<ParticipationsReportLines>();
            this.ParticipationsReportLineShares = new HashSet<ParticipationsReportLineShares>();
            this.RoyaltyReportLineShares = new HashSet<RoyaltyReportLineShares>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ContractId { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public Nullable<System.Guid> FixedFeeColumnTypeId { get; set; }
        public Nullable<System.Guid> CorridorFeeColumnTypeId { get; set; }
        public bool IsRightsCrossCollateralized { get; set; }
        public bool IsMGRecoupable { get; set; }
        public bool IsExpensesRecoupable { get; set; }
        public Nullable<int> RankOrder { get; set; }
        public Nullable<System.Guid> OriginalId { get; set; }
        public string StatementRevenueHeader { get; set; }
        public string StatementExpenseHeader { get; set; }
        public bool IsStatementReceiptsGroupedByTerritory { get; set; }
        public bool IsCorridorFeeRecoupable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDefinitionAttributeSets> ContractRoyaltyDefinitionAttributeSets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDefinitionChannels> ContractRoyaltyDefinitionChannels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDefinitionLanguages> ContractRoyaltyDefinitionLanguages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDefinitionProjects> ContractRoyaltyDefinitionProjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDefinitionReserves> ContractRoyaltyDefinitionReserves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDefinitionRights> ContractRoyaltyDefinitionRights { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDefinitions> ContractRoyaltyDefinitions1 { get; set; }
        public virtual ContractRoyaltyDefinitions ContractRoyaltyDefinitions2 { get; set; }
        public virtual ParticipationsReportingColumns ParticipationsReportingColumns { get; set; }
        public virtual Contracts Contracts { get; set; }
        public virtual ParticipationsReportingColumns ParticipationsReportingColumns1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDefinitionTerritories> ContractRoyaltyDefinitionTerritories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyDefinitionTiers> ContractRoyaltyDefinitionTiers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipationsReportLines> ParticipationsReportLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipationsReportLines> ParticipationsReportLines1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipationsReportLineShares> ParticipationsReportLineShares { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyReportLineShares> RoyaltyReportLineShares { get; set; }
    }
}
