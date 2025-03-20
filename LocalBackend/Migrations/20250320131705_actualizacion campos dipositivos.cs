using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class actualizacioncamposdipositivos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdTipoDispositivo",
                table: "Dispositivo",
                newName: "TipoDispositivoId");

            migrationBuilder.RenameColumn(
                name: "IdMarca",
                table: "Dispositivo",
                newName: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivo_MarcaId",
                table: "Dispositivo",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivo_TipoDispositivoId",
                table: "Dispositivo",
                column: "TipoDispositivoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dispositivo_Marca_MarcaId",
                table: "Dispositivo",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "IdMarca",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dispositivo_TipoDispositivo_TipoDispositivoId",
                table: "Dispositivo",
                column: "TipoDispositivoId",
                principalTable: "TipoDispositivo",
                principalColumn: "IdTipoDispositivo",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dispositivo_Marca_MarcaId",
                table: "Dispositivo");

            migrationBuilder.DropForeignKey(
                name: "FK_Dispositivo_TipoDispositivo_TipoDispositivoId",
                table: "Dispositivo");

            migrationBuilder.DropIndex(
                name: "IX_Dispositivo_MarcaId",
                table: "Dispositivo");

            migrationBuilder.DropIndex(
                name: "IX_Dispositivo_TipoDispositivoId",
                table: "Dispositivo");

            migrationBuilder.RenameColumn(
                name: "TipoDispositivoId",
                table: "Dispositivo",
                newName: "IdTipoDispositivo");

            migrationBuilder.RenameColumn(
                name: "MarcaId",
                table: "Dispositivo",
                newName: "IdMarca");
        }
    }
}
