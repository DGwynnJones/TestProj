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
    
    public partial class ContractShipmentMaterials
    {
        public System.Guid Id { get; set; }
        public System.Guid ShipmentId { get; set; }
        public System.Guid ProjectId { get; set; }
        public string Description { get; set; }
        public System.Guid MaterialTypeId { get; set; }
        public string Note { get; set; }
        public string BarCode { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
        public string LanguageCode { get; set; }
        public bool IsLoaned { get; set; }
        public Nullable<System.Guid> MaterialId { get; set; }
    
        public virtual ContractShipmentMaterialTypes ContractShipmentMaterialTypes { get; set; }
        public virtual ContractShipments ContractShipments { get; set; }
        public virtual Languages Languages { get; set; }
        public virtual Materials Materials { get; set; }
    }
}
