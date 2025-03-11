using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class CorrecionerroreDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoMedicion",
                table: "UnidadMedida",
                newName: "TipoMedicionId");

            migrationBuilder.RenameColumn(
                name: "IdUnidadMedida",
                table: "Mediciones",
                newName: "UnidadMedidaId");

            migrationBuilder.RenameColumn(
                name: "IdDispositivos",
                table: "Mediciones",
                newName: "DispositivoId");

            migrationBuilder.AddColumn<Guid>(
                name: "TipoElementosIdTipoElemento",
                table: "Elementos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_UnidadMedida_TipoMedicionId",
                table: "UnidadMedida",
                column: "TipoMedicionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mediciones_DispositivoId",
                table: "Mediciones",
                column: "DispositivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mediciones_UnidadMedidaId",
                table: "Mediciones",
                column: "UnidadMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Elementos_TipoElementosIdTipoElemento",
                table: "Elementos",
                column: "TipoElementosIdTipoElemento");

            migrationBuilder.AddForeignKey(
                name: "FK_Elementos_TipoElementos_TipoElementosIdTipoElemento",
                table: "Elementos",
                column: "TipoElementosIdTipoElemento",
                principalTable: "TipoElementos",
                principalColumn: "IdTipoElemento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mediciones_Dispositivos_DispositivoId",
                table: "Mediciones",
                column: "DispositivoId",
                principalTable: "Dispositivos",
                principalColumn: "IdDispisitivo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mediciones_UnidadMedida_UnidadMedidaId",
                table: "Mediciones",
                column: "UnidadMedidaId",
                principalTable: "UnidadMedida",
                principalColumn: "IdUnidadMedida",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadMedida_TipoMedicion_TipoMedicionId",
                table: "UnidadMedida",
                column: "TipoMedicionId",
                principalTable: "TipoMedicion",
                principalColumn: "IdTipoMedicion",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elementos_TipoElementos_TipoElementosIdTipoElemento",
                table: "Elementos");

            migrationBuilder.DropForeignKey(
                name: "FK_Mediciones_Dispositivos_DispositivoId",
                table: "Mediciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Mediciones_UnidadMedida_UnidadMedidaId",
                table: "Mediciones");

            migrationBuilder.DropForeignKey(
                name: "FK_UnidadMedida_TipoMedicion_TipoMedicionId",
                table: "UnidadMedida");

            migrationBuilder.DropIndex(
                name: "IX_UnidadMedida_TipoMedicionId",
                table: "UnidadMedida");

            migrationBuilder.DropIndex(
                name: "IX_Mediciones_DispositivoId",
                table: "Mediciones");

            migrationBuilder.DropIndex(
                name: "IX_Mediciones_UnidadMedidaId",
                table: "Mediciones");

            migrationBuilder.DropIndex(
                name: "IX_Elementos_TipoElementosIdTipoElemento",
                table: "Elementos");

            migrationBuilder.DropColumn(
                name: "TipoElementosIdTipoElemento",
                table: "Elementos");

            migrationBuilder.RenameColumn(
                name: "TipoMedicionId",
                table: "UnidadMedida",
                newName: "TipoMedicion");

            migrationBuilder.RenameColumn(
                name: "UnidadMedidaId",
                table: "Mediciones",
                newName: "IdUnidadMedida");

            migrationBuilder.RenameColumn(
                name: "DispositivoId",
                table: "Mediciones",
                newName: "IdDispositivos");
        }
    }
}
