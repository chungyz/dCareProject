﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace dCareProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dCareEntities : DbContext
    {
        public dCareEntities()
            : base("name=dCareEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<看診紀錄表> 看診紀錄表 { get; set; }
        public virtual DbSet<看診點> 看診點 { get; set; }
        public virtual DbSet<病人> 病人 { get; set; }
        public virtual DbSet<醫生> 醫生 { get; set; }
        public virtual DbSet<預約表> 預約表 { get; set; }
    }
}
