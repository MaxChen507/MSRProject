﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSR
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MSR_Max_V2Entities : DbContext
    {
        public MSR_Max_V2Entities()
            : base("name=MSR_Max_V2Entities")
        {
            //TODO: Change this later to more secure
            this.Database.Connection.ConnectionString = @"Data Source=BPAL-MCHEN;Initial Catalog=MSR_Max_V2;User ID=sa;Password=Bankers1!";
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActivityCode> ActivityCodes { get; set; }
        public virtual DbSet<BudgetInfo> BudgetInfoes { get; set; }
        public virtual DbSet<BudgetPool> BudgetPools { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<FormItem> FormItems { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<MSR> MSRs { get; set; }
        public virtual DbSet<StockItem> StockItems { get; set; }
        public virtual DbSet<Usr> Usrs { get; set; }
    }
}
