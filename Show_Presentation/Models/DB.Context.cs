﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Show_Presentation.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sistema_facturacion1Entities1 : DbContext
    {
        public sistema_facturacion1Entities1()
            : base("name=sistema_facturacion1Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<factura> factura { get; set; }
        public virtual DbSet<inventario> inventario { get; set; }
        public virtual DbSet<productos> productos { get; set; }
        public virtual DbSet<proveedores> proveedores { get; set; }
    }
}
