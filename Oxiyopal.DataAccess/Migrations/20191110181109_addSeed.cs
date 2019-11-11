using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oxiyopal.DataAccess.Migrations
{
    public partial class addSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departamento",
                columns: new[] { "Id", "CreatedOn", "NombreDepartamento", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 11, 10, 13, 11, 9, 405, DateTimeKind.Local).AddTicks(1562), "Casanare", new DateTime(2019, 11, 10, 13, 11, 9, 405, DateTimeKind.Local).AddTicks(8706) },
                    { 2, new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(184), "Cundinamarca", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(189) }
                });

            migrationBuilder.InsertData(
                table: "TipoDeProducto",
                columns: new[] { "Id", "Color", "CreatedOn", "NombreTipoProducto", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "#2ce69b", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(5457), "Oxigeno", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(5459) },
                    { 2, "#ff708d", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6173), "Acetileno", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6174) },
                    { 3, "#444343", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6180), "Nitrogeno", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6181) },
                    { 4, "#ffc107", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6182), "Mezcla", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6182) },
                    { 5, "#A6ACAF", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6183), "Argon", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6184) },
                    { 6, "#42aaff", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6185), "Dioxido de carbono", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6185) }
                });

            migrationBuilder.InsertData(
                table: "Ciudad",
                columns: new[] { "Id", "CreatedOn", "DepartamentoId", "NombreCiudad", "UpdatedOn" },
                values: new object[] { 1, new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(2155), 1, "Yopal", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.InsertData(
                table: "Ciudad",
                columns: new[] { "Id", "CreatedOn", "DepartamentoId", "NombreCiudad", "UpdatedOn" },
                values: new object[] { 2, new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(2983), 2, "Bogota", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.InsertData(
                table: "Bodega",
                columns: new[] { "Id", "CiudadId", "CreatedOn", "Direccion", "NombreBodega", "UpdatedOn" },
                values: new object[] { 1, 1, new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(3699), "", "Bodega LLenas", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.InsertData(
                table: "Bodega",
                columns: new[] { "Id", "CiudadId", "CreatedOn", "Direccion", "NombreBodega", "UpdatedOn" },
                values: new object[] { 2, 1, new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(4794), "", "Bodega Vacias", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.InsertData(
                table: "Bodega",
                columns: new[] { "Id", "CiudadId", "CreatedOn", "Direccion", "NombreBodega", "UpdatedOn" },
                values: new object[] { 3, 2, new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(4805), "", "Planta de LLenado", new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(4806) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
