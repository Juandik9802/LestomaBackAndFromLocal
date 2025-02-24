using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class correcion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedioProduccion");

            migrationBuilder.CreateTable(
                name: "Medio",
                columns: table => new
                {
                    IdMedio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medio", x => x.IdMedio);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medio_Nombre",
                table: "Medio",
                column: "Nombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medio");

            migrationBuilder.CreateTable(
                name: "MedioProduccion",
                columns: table => new
                {
                    IdMedioProduccion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedioProduccion", x => x.IdMedioProduccion);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedioProduccion_Nombre",
                table: "MedioProduccion",
                column: "Nombre",
                unique: true);
        }
    }
}
