using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oxiyopal.DataAccess.Migrations
{
    public partial class addDataStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 451, DateTimeKind.Local).AddTicks(5871), new DateTime(2019, 11, 10, 16, 29, 34, 451, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(1376), new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(1456), new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 450, DateTimeKind.Local).AddTicks(8318), new DateTime(2019, 11, 10, 16, 29, 34, 450, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 451, DateTimeKind.Local).AddTicks(2665), new DateTime(2019, 11, 10, 16, 29, 34, 451, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 445, DateTimeKind.Local).AddTicks(4860), new DateTime(2019, 11, 10, 16, 29, 34, 448, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 449, DateTimeKind.Local).AddTicks(6379), new DateTime(2019, 11, 10, 16, 29, 34, 449, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "ColorDeEstado", "CreatedOn", "NombreDeEstado", "UpdatedOn" },
                values: new object[,]
                {
                    { 4, "#17202A", new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(7136), "Dañado", new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(7138) },
                    { 3, "#FFFF00", new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(7126), "En mantenimiento", new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(7129) },
                    { 2, "#FF3300", new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(7054), "Vacio", new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(7066) },
                    { 1, "#00FF00", new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(3524), "Lleno", new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(3534) }
                });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(4992), new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(9919), new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(9957), new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(9966), new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(9971), new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(9976), new DateTime(2019, 11, 10, 16, 29, 34, 452, DateTimeKind.Local).AddTicks(9978) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(3699), new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(4794), new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(4805), new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(2155), new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(2983), new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 405, DateTimeKind.Local).AddTicks(1562), new DateTime(2019, 11, 10, 13, 11, 9, 405, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(184), new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(5457), new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6173), new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6180), new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6182), new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6183), new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6185), new DateTime(2019, 11, 10, 13, 11, 9, 406, DateTimeKind.Local).AddTicks(6185) });
        }
    }
}
