﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mobile_Shop.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Mobile_ShopEntities : DbContext
    {
        public Mobile_ShopEntities()
            : base("name=Mobile_ShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Purchase_Detail> Purchase_Detail { get; set; }
        public virtual DbSet<Purchase_Master> Purchase_Master { get; set; }
        public virtual DbSet<Sales_Details> Sales_Details { get; set; }
        public virtual DbSet<Sales_Master> Sales_Master { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
    }
}