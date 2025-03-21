using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class correcioncamposdeeventos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_AsignacionSistema_asignacionSistemaIdAsignacionSistema",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_TipoElemento_TipoElementoIdTipoElemento",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_TipoEvento_ClsMTipoEventoIdTipoEvento",
                table: "Evento");

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
                name: "asignacionSistemaIdAsignacionSistema",
                table: "Evento",
                newName: "AsignacionSistemaIdAsignacionSistema");

            migrationBuilder.RenameIndex(
                name: "IX_Evento_asignacionSistemaIdAsignacionSistema",
                table: "Evento",
                newName: "IX_Evento_AsignacionSistemaIdAsignacionSistema");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_ElementoId",
                table: "Evento",
                column: "ElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_TipoEventoId",
                table: "Evento",
                column: "TipoEventoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_AsignacionSistema_AsignacionSistemaIdAsignacionSistema",
                table: "Evento",
                column: "AsignacionSistemaIdAsignacionSistema",
                principalTable: "AsignacionSistema",
                principalColumn: "IdAsignacionSistema",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Elemento_ElementoId",
                table: "Evento",
                column: "ElementoId",
                principalTable: "Elemento",
                principalColumn: "IdElemento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_TipoEvento_TipoEventoId",
                table: "Evento",
                column: "TipoEventoId",
                principalTable: "TipoEvento",
                principalColumn: "IdTipoEvento",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_AsignacionSistema_AsignacionSistemaIdAsignacionSistema",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Elemento_ElementoId",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_TipoEvento_TipoEventoId",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_ElementoId",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_TipoEventoId",
                table: "Evento");

            migrationBuilder.RenameColumn(
                name: "AsignacionSistemaIdAsignacionSistema",
                table: "Evento",
                newName: "asignacionSistemaIdAsignacionSistema");

            migrationBuilder.RenameIndex(
                name: "IX_Evento_AsignacionSistemaIdAsignacionSistema",
                table: "Evento",
                newName: "IX_Evento_asignacionSistemaIdAsignacionSistema");

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
                name: "IX_Evento_ClsMTipoEventoIdTipoEvento",
                table: "Evento",
                column: "ClsMTipoEventoIdTipoEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_TipoElementoIdTipoElemento",
                table: "Evento",
                column: "TipoElementoIdTipoElemento");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_AsignacionSistema_asignacionSistemaIdAsignacionSistema",
                table: "Evento",
                column: "asignacionSistemaIdAsignacionSistema",
                principalTable: "AsignacionSistema",
                principalColumn: "IdAsignacionSistema",
                onDelete: ReferentialAction.Restrict);

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
        }
    }
}
