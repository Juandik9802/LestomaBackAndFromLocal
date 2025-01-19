using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class Pez : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cultivos",
                columns: table => new
                {
                    TipCltId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipCltNombre = table.Column<string>(type: "varchar(30)", nullable: false),
                    TipCltDescripcion = table.Column<string>(type: "varchar(50)", nullable: true),
                    TipCltUsrId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TipCltDtUtmModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipCltStdCultivo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cultivos", x => x.TipCltId);
                });

            migrationBuilder.CreateTable(
                name: "Plantas",
                columns: table => new
                {
                    PltId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PltNombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PltUsrId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PltStdId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PltDtUtmModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantas", x => x.PltId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cultivos_TipCltNombre",
                table: "Cultivos",
                column: "TipCltNombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plantas_PltNombre",
                table: "Plantas",
                column: "PltNombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cultivos");

            migrationBuilder.DropTable(
                name: "Plantas");
        }
    }
}
