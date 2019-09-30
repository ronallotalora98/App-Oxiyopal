using Microsoft.EntityFrameworkCore;
using Oxiyopal.Models;
using Oxiyopal.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.DataAccess
{
    public class OxiyopalDbContext : DbContext
    {
        public DbSet<Cilindro> Cilindros { get; set; }
        public DbSet<HistorialCilindro> HistorialCilindros { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Bodega> Bodegas { get; set; }
        public DbSet<TipoDeProducto> TipoDeProductos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<HistorialDeFactura> HistorialDeFacturas { get; set; }

        public OxiyopalDbContext(DbContextOptions<OxiyopalDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();
            Seed.SeedData(modelBuilder);
        }
    }
}
