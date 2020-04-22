using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oxiyopal.DataAccess.Migrations
{
    public partial class shangeSizeForCantidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tamaño",
                table: "Cilindro",
                newName: "Cantidad");

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(3222), new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(5207), new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "Bodega",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(5227), new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(412), new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Ciudad",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(1894), new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 305, DateTimeKind.Local).AddTicks(4030), new DateTime(2020, 4, 21, 15, 33, 34, 306, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 306, DateTimeKind.Local).AddTicks(7091), new DateTime(2020, 4, 21, 15, 33, 34, 306, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(8957), new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 308, DateTimeKind.Local).AddTicks(255), new DateTime(2020, 4, 21, 15, 33, 34, 308, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 308, DateTimeKind.Local).AddTicks(271), new DateTime(2020, 4, 21, 15, 33, 34, 308, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 308, DateTimeKind.Local).AddTicks(273), new DateTime(2020, 4, 21, 15, 33, 34, 308, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(6344), new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(7825), new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(7839), new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(7842), new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(7845), new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "TipoDeProducto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(7847), new DateTime(2020, 4, 21, 15, 33, 34, 307, DateTimeKind.Local).AddTicks(7848) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "Cilindro",
                newName: "Tamaño");

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
    }
}
