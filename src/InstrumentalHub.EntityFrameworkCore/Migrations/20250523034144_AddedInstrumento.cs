using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstrumentalHub.Migrations
{
    /// <inheritdoc />
    public partial class AddedInstrumento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instrumentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    CategoriaId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrumentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instrumentos_InstrumentoCategorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "InstrumentoCategorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instrumentos_CategoriaId",
                table: "Instrumentos",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instrumentos");
        }
    }
}
