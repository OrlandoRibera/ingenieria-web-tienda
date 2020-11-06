using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tienda.Soporte.Web.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    nombres = table.Column<string>(nullable: true),
                    apellidos = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("clienteId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Categoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecnico",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombres_Value = table.Column<string>(nullable: true),
                    Apellidos_Value = table.Column<string>(nullable: true),
                    Ci = table.Column<string>(nullable: false),
                    Profesion = table.Column<string>(nullable: false),
                    Telefono_Value = table.Column<string>(nullable: true),
                    Correo_Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("tecnicoId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soporte",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClienteId = table.Column<Guid>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    costo = table.Column<decimal>(nullable: false),
                    estado = table.Column<int>(nullable: false),
                    fechaCreacion = table.Column<DateTime>(nullable: false),
                    fechaCulminacion = table.Column<DateTime>(nullable: true),
                    fechaAnulacion = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("soporteId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Soporte_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cita",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SoporteId = table.Column<Guid>(nullable: true),
                    FechaPrevista = table.Column<DateTime>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("citaId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cita_Soporte_SoporteId",
                        column: x => x.SoporteId,
                        principalTable: "Soporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SoporteProducto",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SoporteId = table.Column<Guid>(nullable: true),
                    ProductoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("soporteProductoId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoporteProducto_Producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SoporteProducto_Soporte_SoporteId",
                        column: x => x.SoporteId,
                        principalTable: "Soporte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CitaTecnico",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CitaId = table.Column<Guid>(nullable: true),
                    TecnicoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("citatecnicoId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CitaTecnico_Cita_CitaId",
                        column: x => x.CitaId,
                        principalTable: "Cita",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CitaTecnico_Tecnico_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "Tecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormTrabajo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CitaId = table.Column<Guid>(nullable: true),
                    TrabajoRealizado = table.Column<string>(nullable: false),
                    FechaForm = table.Column<DateTime>(nullable: false),
                    ClienteConfirma = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("formTrabajoId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormTrabajo_Cita_CitaId",
                        column: x => x.CitaId,
                        principalTable: "Cita",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cita_SoporteId",
                table: "Cita",
                column: "SoporteId");

            migrationBuilder.CreateIndex(
                name: "IX_CitaTecnico_CitaId",
                table: "CitaTecnico",
                column: "CitaId");

            migrationBuilder.CreateIndex(
                name: "IX_CitaTecnico_TecnicoId",
                table: "CitaTecnico",
                column: "TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTrabajo_CitaId",
                table: "FormTrabajo",
                column: "CitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Soporte_ClienteId",
                table: "Soporte",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SoporteProducto_ProductoId",
                table: "SoporteProducto",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_SoporteProducto_SoporteId",
                table: "SoporteProducto",
                column: "SoporteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitaTecnico");

            migrationBuilder.DropTable(
                name: "FormTrabajo");

            migrationBuilder.DropTable(
                name: "SoporteProducto");

            migrationBuilder.DropTable(
                name: "Tecnico");

            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Soporte");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
