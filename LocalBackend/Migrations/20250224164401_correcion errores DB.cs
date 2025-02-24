using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class correcionerroresDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoMedicio",
                table: "UnidadMedida",
                newName: "TipoMedicion");

            migrationBuilder.AddColumn<string>(
                name: "Simbolo",
                table: "UnidadMedida",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Simbolo",
                table: "UnidadMedida");

            migrationBuilder.RenameColumn(
                name: "TipoMedicion",
                table: "UnidadMedida",
                newName: "TipoMedicio");
        }
    }
}
