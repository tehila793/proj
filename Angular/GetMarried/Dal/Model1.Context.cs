//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WeddingEntities : DbContext
    {
        public WeddingEntities()
            : base("name=WeddingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Halls> Halls { get; set; }
        public virtual DbSet<HallType> HallType { get; set; }
        public virtual DbSet<Img> Img { get; set; }
        public virtual DbSet<Opinion> Opinion { get; set; }
        public virtual DbSet<ProductsToCustomers> ProductsToCustomers { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
    }
}
