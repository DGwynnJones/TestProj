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
    
    public partial class vault_Files
    {
        public System.Guid Id { get; set; }
        public System.Guid ApplicationId { get; set; }
        public System.Guid CategoryId { get; set; }
        public System.Guid ParentId { get; set; }
        public string ContentType { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string Description { get; set; }
        public string FileExtension { get; set; }
        public long FileSize { get; set; }
        public string FriendlyFileName { get; set; }
        public string SavedFileName { get; set; }
        public string VaultFilePath { get; set; }
        public string UserName { get; set; }
        public string ImageInfo { get; set; }
        public string FileNotes { get; set; }
        public Nullable<System.DateTime> DBAUpdateDate { get; set; }
        public string DBAUpdateNote { get; set; }
    
        public virtual vault_Applications vault_Applications { get; set; }
        public virtual vault_Categories vault_Categories { get; set; }
    }
}
