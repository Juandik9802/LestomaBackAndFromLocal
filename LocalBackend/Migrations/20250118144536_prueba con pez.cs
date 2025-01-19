using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class pruebaconpez : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PltDtUtmModificacion",
                table: "Plantas");

            migrationBuilder.DropColumn(
                name: "PltUsrId",
                table: "Plantas");

            migrationBuilder.CreateTable(
                name: "Pez",
                columns: table => new
                {
                    PezId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PezNombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PezStdId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pez", x => x.PezId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pez_PezNombre",
                table: "Pez",
                column: "PezNombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pez");

            migrationBuilder.AddColumn<DateTime>(
                name: "PltDtUtmModificacion",
                table: "Plantas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PltUsrId",
                table: "Plantas",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
