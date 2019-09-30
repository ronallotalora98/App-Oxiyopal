using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oxiyopal.DataAccess.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    NombreDepartamento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    NombreDeEstado = table.Column<string>(nullable: true),
                    ColorDeEstado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDeProducto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    NombreTipoProducto = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDeProducto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    NombreCiudad = table.Column<string>(nullable: true),
                    DepartamentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciudad_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cilindro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    Serial = table.Column<string>(nullable: true),
                    Tamaño = table.Column<decimal>(nullable: false),
                    FechaDeTraslado = table.Column<DateTime>(nullable: false),
                    TipoDeProductoId = table.Column<int>(nullable: false),
                    EstadoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cilindro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cilindro_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cilindro_TipoDeProducto_TipoDeProductoId",
                        column: x => x.TipoDeProductoId,
                        principalTable: "TipoDeProducto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bodega",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    NombreBodega = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    CiudadId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodega", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bodega_Ciudad_CiudadId",
                        column: x => x.CiudadId,
                        principalTable: "Ciudad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Documento = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    EsEmpresa = table.Column<bool>(nullable: false),
                    CiudadId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Ciudad_CiudadId",
                        column: x => x.CiudadId,
                        principalTable: "Ciudad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<int>(nullable: false),
                    Serial = table.Column<int>(nullable: false),
                    FechaDeVenta = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factura_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    estaEnBodega = table.Column<bool>(nullable: false),
                    ClienteId = table.Column<int>(nullable: true),
                    BodegaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ubicacion_Bodega_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "Bodega",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ubicacion_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistorialDeFactura",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    CilindroId = table.Column<int>(nullable: false),
                    FacturaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialDeFactura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialDeFactura_Cilindro_CilindroId",
                        column: x => x.CilindroId,
                        principalTable: "Cilindro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistorialDeFactura_Factura_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Factura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistorialCilindro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    CilindroId = table.Column<int>(nullable: false),
                    UbicacionId = table.Column<int>(nullable: false),
                    EsUbucacionActual = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialCilindro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialCilindro_Cilindro_CilindroId",
                        column: x => x.CilindroId,
                        principalTable: "Cilindro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistorialCilindro_Ubicacion_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "Ubicacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bodega_CiudadId",
                table: "Bodega",
                column: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Cilindro_EstadoId",
                table: "Cilindro",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cilindro_TipoDeProductoId",
                table: "Cilindro",
                column: "TipoDeProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_DepartamentoId",
                table: "Ciudad",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CiudadId",
                table: "Cliente",
                column: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_ClienteId",
                table: "Factura",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialCilindro_CilindroId",
                table: "HistorialCilindro",
                column: "CilindroId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialCilindro_UbicacionId",
                table: "HistorialCilindro",
                column: "UbicacionId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialDeFactura_CilindroId",
                table: "HistorialDeFactura",
                column: "CilindroId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialDeFactura_FacturaId",
                table: "HistorialDeFactura",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacion_BodegaId",
                table: "Ubicacion",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacion_ClienteId",
                table: "Ubicacion",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorialCilindro");

            migrationBuilder.DropTable(
                name: "HistorialDeFactura");

            migrationBuilder.DropTable(
                name: "Ubicacion");

            migrationBuilder.DropTable(
                name: "Cilindro");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Bodega");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "TipoDeProducto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "Departamento");
        }
    }
}
