using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class campos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TipoMedicion_Nombre",
                table: "TipoMedicion");

            migrationBuilder.RenameColumn(
                name: "IdImpacto",
                table: "TipoEvento",
                newName: "ImpactoId");

            migrationBuilder.RenameColumn(
                name: "IdTipoEvento",
                table: "Evento",
                newName: "TipoEventoId");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "TipoMedicion",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClsMTipoEventoIdTipoEvento",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TipoElementoIdTipoElemento",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoMedicion_Nombre",
                table: "TipoMedicion",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoEvento_ImpactoId",
                table: "TipoEvento",
                column: "ImpactoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_ClsMTipoEventoIdTipoEvento",
                table: "Evento",
                column: "ClsMTipoEventoIdTipoEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_TipoElementoIdTipoElemento",
                table: "Evento",
                column: "TipoElementoIdTipoElemento");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_TipoElemento_TipoElementoIdTipoElemento",
                table: "Evento",
                column: "TipoElementoIdTipoElemento",
                principalTable: "TipoElemento",
                principalColumn: "IdTipoElemento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_TipoEvento_ClsMTipoEventoIdTipoEvento",
                table: "Evento",
                column: "ClsMTipoEventoIdTipoEvento",
                principalTable: "TipoEvento",
                principalColumn: "IdTipoEvento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoEvento_Impacto_ImpactoId",
                table: "TipoEvento",
                column: "ImpactoId",
                principalTable: "Impacto",
                principalColumn: "IdImpacto",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_TipoElemento_TipoElementoIdTipoElemento",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_TipoEvento_ClsMTipoEventoIdTipoEvento",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoEvento_Impacto_ImpactoId",
                table: "TipoEvento");

            migrationBuilder.DropIndex(
                name: "IX_TipoMedicion_Nombre",
                table: "TipoMedicion");

            migrationBuilder.DropIndex(
                name: "IX_TipoEvento_ImpactoId",
                table: "TipoEvento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_ClsMTipoEventoIdTipoEvento",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_TipoElementoIdTipoElemento",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ClsMTipoEventoIdTipoEvento",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "TipoElementoIdTipoElemento",
                table: "Evento");

            migrationBuilder.RenameColumn(
                name: "ImpactoId",
                table: "TipoEvento",
                newName: "IdImpacto");

            migrationBuilder.RenameColumn(
                name: "TipoEventoId",
                table: "Evento",
                newName: "IdTipoEvento");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "TipoMedicion",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_TipoMedicion_Nombre",
                table: "TipoMedicion",
                column: "Nombre",
                unique: true,
                filter: "[Nombre] IS NOT NULL");
        }
    }
}
