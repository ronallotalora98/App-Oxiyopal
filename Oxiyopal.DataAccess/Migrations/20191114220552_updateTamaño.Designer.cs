﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oxiyopal.DataAccess;

namespace Oxiyopal.DataAccess.Migrations
{
    [DbContext(typeof(OxiyopalDbContext))]
    [Migration("20191114220552_updateTamaño")]
    partial class updateTamaño
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Oxiyopal.Models.Bodega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CiudadId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Direccion");

                    b.Property<string>("NombreBodega");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.ToTable("Bodega");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CiudadId = 1,
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(1687),
                            Direccion = "",
                            NombreBodega = "Bodega LLenas",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(1689)
                        },
                        new
                        {
                            Id = 2,
                            CiudadId = 1,
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(2823),
                            Direccion = "",
                            NombreBodega = "Bodega Vacias",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(2824)
                        },
                        new
                        {
                            Id = 3,
                            CiudadId = 2,
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(2834),
                            Direccion = "",
                            NombreBodega = "Planta de LLenado",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(2834)
                        });
                });

            modelBuilder.Entity("Oxiyopal.Models.Cilindro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("EstadoId");

                    b.Property<string>("Serial");

                    b.Property<string>("Tamaño");

                    b.Property<int>("TipoDeProductoId");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.HasIndex("TipoDeProductoId");

                    b.ToTable("Cilindro");
                });

            modelBuilder.Entity("Oxiyopal.Models.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("NombreCiudad");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Ciudad");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(189),
                            DepartamentoId = 1,
                            NombreCiudad = "Yopal",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(191)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(994),
                            DepartamentoId = 2,
                            NombreCiudad = "Bogota",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(996)
                        });
                });

            modelBuilder.Entity("Oxiyopal.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<int>("CiudadId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Direccion");

                    b.Property<string>("Documento");

                    b.Property<bool>("EsEmpresa");

                    b.Property<string>("Nombre");

                    b.Property<string>("Telefono");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Oxiyopal.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("NombreDepartamento");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Departamento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 538, DateTimeKind.Local).AddTicks(671),
                            NombreDepartamento = "Casanare",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 538, DateTimeKind.Local).AddTicks(6789)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 538, DateTimeKind.Local).AddTicks(8203),
                            NombreDepartamento = "Cundinamarca",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 538, DateTimeKind.Local).AddTicks(8208)
                        });
                });

            modelBuilder.Entity("Oxiyopal.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorDeEstado");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("NombreDeEstado");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Estado");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColorDeEstado = "#00FF00",
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4830),
                            NombreDeEstado = "Lleno",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4831)
                        },
                        new
                        {
                            Id = 2,
                            ColorDeEstado = "#FF3300",
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(5529),
                            NombreDeEstado = "Vacio",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(5531)
                        },
                        new
                        {
                            Id = 3,
                            ColorDeEstado = "#FFFF00",
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(5537),
                            NombreDeEstado = "En mantenimiento",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(5537)
                        },
                        new
                        {
                            Id = 4,
                            ColorDeEstado = "#17202A",
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(5538),
                            NombreDeEstado = "Dañado",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(5539)
                        });
                });

            modelBuilder.Entity("Oxiyopal.Models.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("FechaDeVenta");

                    b.Property<int>("Serial");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<int>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("Oxiyopal.Models.TipoDeProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("NombreTipoProducto");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("TipoDeProducto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "#2ce69b",
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(3466),
                            NombreTipoProducto = "Oxigeno",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(3467)
                        },
                        new
                        {
                            Id = 2,
                            Color = "#ff708d",
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4185),
                            NombreTipoProducto = "Acetileno",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4187)
                        },
                        new
                        {
                            Id = 3,
                            Color = "#444343",
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4194),
                            NombreTipoProducto = "Nitrogeno",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4194)
                        },
                        new
                        {
                            Id = 4,
                            Color = "#ffc107",
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4195),
                            NombreTipoProducto = "Mezcla",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4196)
                        },
                        new
                        {
                            Id = 5,
                            Color = "#A6ACAF",
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4197),
                            NombreTipoProducto = "Argon",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4197)
                        },
                        new
                        {
                            Id = 6,
                            Color = "#42aaff",
                            CreatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4198),
                            NombreTipoProducto = "Dioxido de carbono",
                            UpdatedOn = new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4198)
                        });
                });

            modelBuilder.Entity("Oxiyopal.Models.Ubicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BodegaId");

                    b.Property<int?>("ClienteId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("FechaDeTraslado");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<bool>("estaEnBodega");

                    b.HasKey("Id");

                    b.HasIndex("BodegaId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Ubicacion");
                });

            modelBuilder.Entity("Oxiyopal.Models.ViewModels.HistorialCilindro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CilindroId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("EsUbucacionActual");

                    b.Property<int>("UbicacionId");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CilindroId");

                    b.HasIndex("UbicacionId");

                    b.ToTable("HistorialCilindro");
                });

            modelBuilder.Entity("Oxiyopal.Models.ViewModels.HistorialDeFactura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CilindroId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("FacturaId");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CilindroId");

                    b.HasIndex("FacturaId");

                    b.ToTable("HistorialDeFactura");
                });

            modelBuilder.Entity("Oxiyopal.Models.Bodega", b =>
                {
                    b.HasOne("Oxiyopal.Models.Ciudad", "Ciudad")
                        .WithMany("Bodegas")
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Oxiyopal.Models.Cilindro", b =>
                {
                    b.HasOne("Oxiyopal.Models.Estado", "Estado")
                        .WithMany("Cilindros")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Oxiyopal.Models.TipoDeProducto", "TipoDeProducto")
                        .WithMany("Cilindros")
                        .HasForeignKey("TipoDeProductoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Oxiyopal.Models.Ciudad", b =>
                {
                    b.HasOne("Oxiyopal.Models.Departamento", "Departamento")
                        .WithMany("Ciudades")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Oxiyopal.Models.Cliente", b =>
                {
                    b.HasOne("Oxiyopal.Models.Ciudad", "Ciudad")
                        .WithMany("Clientes")
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Oxiyopal.Models.Factura", b =>
                {
                    b.HasOne("Oxiyopal.Models.Cliente", "Cliente")
                        .WithMany("Facturas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Oxiyopal.Models.Ubicacion", b =>
                {
                    b.HasOne("Oxiyopal.Models.Bodega", "Bodega")
                        .WithMany("Ubicaciones")
                        .HasForeignKey("BodegaId");

                    b.HasOne("Oxiyopal.Models.Cliente", "Cliente")
                        .WithMany("Ubicaciones")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("Oxiyopal.Models.ViewModels.HistorialCilindro", b =>
                {
                    b.HasOne("Oxiyopal.Models.Cilindro", "Cilindro")
                        .WithMany("HistorialCilindros")
                        .HasForeignKey("CilindroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Oxiyopal.Models.Ubicacion", "Ubicacion")
                        .WithMany("HistorialCilindros")
                        .HasForeignKey("UbicacionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Oxiyopal.Models.ViewModels.HistorialDeFactura", b =>
                {
                    b.HasOne("Oxiyopal.Models.Cilindro", "Cilindro")
                        .WithMany("HistorialDeFacturas")
                        .HasForeignKey("CilindroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Oxiyopal.Models.Factura", "Factura")
                        .WithMany("HistorialDeFacturas")
                        .HasForeignKey("FacturaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
