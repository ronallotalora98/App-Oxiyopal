using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oxiyopal.DataAccess.Migrations
{
    public partial class AddDateMove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaDeTraslado",
                table: "Cilindro");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDeTraslado",
                table: "Ubicacion",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(1804), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(2865), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(2876), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(263), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(1064), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 337, DateTimeKind.Local).AddTicks(522), new DateTime(2019, 11, 10, 19, 43, 38, 337, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 337, DateTimeKind.Local).AddTicks(7608), new DateTime(2019, 11, 10, 19, 43, 38, 337, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(4802), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(5476), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(5483), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(5485), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(3498), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(4194), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(4201), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(4204), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(4205), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(4207), new DateTime(2019, 11, 10, 19, 43, 38, 338, DateTimeKind.Local).AddTicks(4207) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaDeTraslado",
                table: "Ubicacion");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDeTraslado",
                table: "Cilindro",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(3524), new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(7054), new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(7126), new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(7136), new DateTime(2019, 11, 10, 16, 29, 34, 453, DateTimeKind.Local).AddTicks(7138) });

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
    }
}
