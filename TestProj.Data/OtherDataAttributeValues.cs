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
    
    public partial class OtherDataAttributeValues
    {
        public System.Guid Id { get; set; }
        public System.Guid EntityId { get; set; }
        public System.Guid OtherDataAttributeId { get; set; }
        public Nullable<decimal> NumberValue { get; set; }
        public string StringValue { get; set; }
        public Nullable<System.DateTime> DateValue { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual Contracts Contracts { get; set; }
        public virtual OtherDataAttributes OtherDataAttributes { get; set; }
    }
}
