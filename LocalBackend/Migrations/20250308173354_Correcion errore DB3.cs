using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class CorrecionerroreDB3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicione_Dispositivo_DispositivoId",
                table: "Medicione");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicione_UnidadMedida_UnidadMedidaId",
                table: "Medicione");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicione",
                table: "Medicione");

            migrationBuilder.RenameTable(
                name: "Medicione",
                newName: "Medicion");

            migrationBuilder.RenameIndex(
                name: "IX_Medicione_UnidadMedidaId",
                table: "Medicion",
                newName: "IX_Medicion_UnidadMedidaId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicione_DispositivoId",
                table: "Medicion",
                newName: "IX_Medicion_DispositivoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicion",
                table: "Medicion",
                column: "IdMedicion");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicion_Dispositivo_DispositivoId",
                table: "Medicion",
                column: "DispositivoId",
                principalTable: "Dispositivo",
                principalColumn: "IdDispisitivo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicion_UnidadMedida_UnidadMedidaId",
                table: "Medicion",
                column: "UnidadMedidaId",
                principalTable: "UnidadMedida",
                principalColumn: "IdUnidadMedida",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicion_Dispositivo_DispositivoId",
                table: "Medicion");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicion_UnidadMedida_UnidadMedidaId",
                table: "Medicion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicion",
                table: "Medicion");

            migrationBuilder.RenameTable(
                name: "Medicion",
                newName: "Medicione");

            migrationBuilder.RenameIndex(
                name: "IX_Medicion_UnidadMedidaId",
                table: "Medicione",
                newName: "IX_Medicione_UnidadMedidaId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicion_DispositivoId",
                table: "Medicione",
                newName: "IX_Medicione_DispositivoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicione",
                table: "Medicione",
                column: "IdMedicion");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicione_Dispositivo_DispositivoId",
                table: "Medicione",
                column: "DispositivoId",
                principalTable: "Dispositivo",
                principalColumn: "IdDispisitivo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicione_UnidadMedida_UnidadMedidaId",
                table: "Medicione",
                column: "UnidadMedidaId",
                principalTable: "UnidadMedida",
                principalColumn: "IdUnidadMedida",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
