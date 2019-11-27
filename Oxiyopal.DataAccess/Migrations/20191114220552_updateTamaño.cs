using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oxiyopal.DataAccess.Migrations
{
    public partial class updateTamaño : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tamaño",
                table: "Cilindro",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(1687), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(2823), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(2834), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(189), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(994), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 538, DateTimeKind.Local).AddTicks(671), new DateTime(2019, 11, 14, 17, 5, 52, 538, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 538, DateTimeKind.Local).AddTicks(8203), new DateTime(2019, 11, 14, 17, 5, 52, 538, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4830), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(5529), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(5537), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(5538), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(3466), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4185), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4194), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4195), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4197), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4198), new DateTime(2019, 11, 14, 17, 5, 52, 539, DateTimeKind.Local).AddTicks(4198) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Tamaño",
                table: "Cilindro",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
