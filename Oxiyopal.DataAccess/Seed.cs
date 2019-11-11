using Microsoft.EntityFrameworkCore;
using Oxiyopal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxiyopal.DataAccess
{
    public static class Seed
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>().HasData(new Departamento
            {
                Id = 1,
                NombreDepartamento = "Casanare"
            },
            new Departamento
            {
                Id = 2,
                NombreDepartamento = "Cundinamarca"
            });
            modelBuilder.Entity<Ciudad>().HasData(new Ciudad
            {
                Id = 1,
                NombreCiudad = "Yopal",
                DepartamentoId = 1,
            },
            new Ciudad
            {
                Id = 2,
                NombreCiudad = "Bogota",
                DepartamentoId = 2,
            });
            modelBuilder.Entity<Bodega>().HasData(new Bodega
            {
                Id = 1,
                NombreBodega = "Bodega LLenas",
                Direccion = "",
                CiudadId = 1,
            },
            new Bodega
            {
                Id = 2,
                NombreBodega = "Bodega Vacias",
                Direccion = "",
                CiudadId = 1,
            },
            new Bodega
            {
                Id = 3,
                NombreBodega = "Planta de LLenado",
                Direccion = "",
                CiudadId = 2,
            });

            modelBuilder.Entity<TipoDeProducto>().HasData(new TipoDeProducto
            {
               Id = 1,
               NombreTipoProducto = "Oxigeno",
               Color = "#2ce69b"
            },
            new TipoDeProducto
            {
                Id = 2,
                NombreTipoProducto = "Acetileno",
                Color = "#ff708d"
            },
            new TipoDeProducto
            {
                Id = 3,
                NombreTipoProducto = "Nitrogeno",
                Color = "#444343"
            },
            new TipoDeProducto
            {
                Id = 4,
                NombreTipoProducto = "Mezcla",
                Color = "#ffc107"
            },
            new TipoDeProducto
            {
                Id = 5,
                NombreTipoProducto = "Argon",
                Color = "#A6ACAF"
            },
            new TipoDeProducto
            {
                Id = 6,
                NombreTipoProducto = "Dioxido de carbono",
                Color = "#42aaff"
            });

            modelBuilder.Entity<Estado>().HasData(new Estado
            {
                Id = 1,
                NombreDeEstado = "Lleno",
                ColorDeEstado = "#00FF00"
            },
            new Estado
            {
                Id = 2,
                NombreDeEstado = "Vacio",
                ColorDeEstado = "#FF3300"
            },
            new Estado
            {
                Id = 3,
                NombreDeEstado = "En mantenimiento",
                ColorDeEstado = "#FFFF00"
            },
            new Estado
            {
                Id = 4,
                NombreDeEstado = "Dañado",
                ColorDeEstado = "#17202A"
            });

        }
    }
}
