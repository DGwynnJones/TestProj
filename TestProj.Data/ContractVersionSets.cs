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
    
    public partial class ContractVersionSets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractVersionSets()
        {
            this.ContractFeeCalcIngestStatements = new HashSet<ContractFeeCalcIngestStatements>();
            this.ContractFeeCalcReportRevenue = new HashSet<ContractFeeCalcReportRevenue>();
            this.ContractHigherRankedParticipationsContracts = new HashSet<ContractHigherRankedParticipationsContracts>();
            this.ContractLedgerStatements = new HashSet<ContractLedgerStatements>();
            this.ContractRoyaltyConsumptionHistory = new HashSet<ContractRoyaltyConsumptionHistory>();
            this.ContractRoyaltyReportingSchedules = new HashSet<ContractRoyaltyReportingSchedules>();
            this.ContractShipments = new HashSet<ContractShipments>();
            this.ParticipationsReports = new HashSet<ParticipationsReports>();
            this.ParticipationsStatements = new HashSet<ParticipationsStatements>();
            this.RoyaltyReports = new HashSet<RoyaltyReports>();
            this.Contracts1 = new HashSet<Contracts>();
            this.Invoices = new HashSet<Invoices>();
            this.LedgerItems = new HashSet<LedgerItems>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> CurrentContractId { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public Nullable<System.Guid> CurrentPostedContractId { get; set; }
        public Nullable<bool> IsInRevision { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcIngestStatements> ContractFeeCalcIngestStatements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFeeCalcReportRevenue> ContractFeeCalcReportRevenue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractHigherRankedParticipationsContracts> ContractHigherRankedParticipationsContracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractLedgerStatements> ContractLedgerStatements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyConsumptionHistory> ContractRoyaltyConsumptionHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractRoyaltyReportingSchedules> ContractRoyaltyReportingSchedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractShipments> ContractShipments { get; set; }
        public virtual Contracts Contracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipationsReports> ParticipationsReports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipationsStatements> ParticipationsStatements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyReports> RoyaltyReports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contracts> Contracts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoices> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LedgerItems> LedgerItems { get; set; }
        public virtual Contracts Contracts2 { get; set; }
    }
}
