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
    
    public partial class ContractMaterials
    {
        public System.Guid Id { get; set; }
        public System.Guid ContractId { get; set; }
        public System.Guid ProjectId { get; set; }
        public System.Guid MaterialId { get; set; }
        public System.Guid DeliveryStatusId { get; set; }
        public Nullable<System.DateTime> DeliveredDate { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public string LanguageName { get; set; }
        public string VersionName { get; set; }
        public Nullable<System.Guid> AspectRatioId { get; set; }
    
        public virtual AspectRatios AspectRatios { get; set; }
        public virtual ContractMaterialDeliveryStatuses ContractMaterialDeliveryStatuses { get; set; }
        public virtual Materials Materials { get; set; }
        public virtual Contracts Contracts { get; set; }
    }
}
