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
    
    public partial class RoyaltyIngestStatementLines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoyaltyIngestStatementLines()
        {
            this.RoyaltyIngestStatementLineErrors = new HashSet<RoyaltyIngestStatementLineErrors>();
            this.RoyaltyIngestStatementLineValues = new HashSet<RoyaltyIngestStatementLineValues>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid RoyaltyIngestStatementId { get; set; }
        public int LineNum { get; set; }
        public string ProjectIdentifier1 { get; set; }
        public string ProjectIdentifier2 { get; set; }
        public Nullable<System.Guid> ProjectId { get; set; }
        public string TerritoryIdentifier1 { get; set; }
        public string TerritoryIdentifier2 { get; set; }
        public Nullable<System.Guid> TerritoryId { get; set; }
        public string RightIdentifier1 { get; set; }
        public string RightIdentifier2 { get; set; }
        public Nullable<System.Guid> RightId { get; set; }
        public string LanguageIdentifier1 { get; set; }
        public string LanguageIdentifier2 { get; set; }
        public string LanguageCode { get; set; }
        public string ChannelIdentifier1 { get; set; }
        public string ChannelIdentifier2 { get; set; }
        public Nullable<System.Guid> ChannelId { get; set; }
        public string SKUNumber { get; set; }
        public Nullable<System.Guid> SKUId { get; set; }
        public string Attribute1Identifier { get; set; }
        public Nullable<System.Guid> Attribute1Id { get; set; }
        public string Attribute2Identifier { get; set; }
        public Nullable<System.Guid> Attribute2Id { get; set; }
        public Nullable<System.Guid> ContractId { get; set; }
        public string ContractCode { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public Nullable<System.Guid> ProjectCategoryId { get; set; }
        public string ProjectCategoryIdentifier { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
    
        public virtual Channels Channels { get; set; }
        public virtual Languages Languages { get; set; }
        public virtual ProjectCategories ProjectCategories { get; set; }
        public virtual Rights Rights { get; set; }
        public virtual RoyaltyAttributes RoyaltyAttributes { get; set; }
        public virtual RoyaltyAttributes RoyaltyAttributes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyIngestStatementLineErrors> RoyaltyIngestStatementLineErrors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoyaltyIngestStatementLineValues> RoyaltyIngestStatementLineValues { get; set; }
        public virtual Contracts Contracts { get; set; }
        public virtual RoyaltyIngestStatements RoyaltyIngestStatements { get; set; }
        public virtual Territories Territories { get; set; }
    }
}
