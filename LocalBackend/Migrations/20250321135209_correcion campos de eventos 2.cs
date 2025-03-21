using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class correcioncamposdeeventos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_AsignacionSistema_AsignacionSistemaIdAsignacionSistema",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_AsignacionSistemaIdAsignacionSistema",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "AsignacionSistemaIdAsignacionSistema",
                table: "Evento");

            migrationBuilder.RenameColumn(
                name: "AsignacionSitemaId",
                table: "Evento",
                newName: "AsignacionSistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_AsignacionSistemaId",
                table: "Evento",
                column: "AsignacionSistemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_AsignacionSistema_AsignacionSistemaId",
                table: "Evento",
                column: "AsignacionSistemaId",
                principalTable: "AsignacionSistema",
                principalColumn: "IdAsignacionSistema",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_AsignacionSistema_AsignacionSistemaId",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_AsignacionSistemaId",
                table: "Evento");

            migrationBuilder.RenameColumn(
                name: "AsignacionSistemaId",
                table: "Evento",
                newName: "AsignacionSitemaId");

            migrationBuilder.AddColumn<Guid>(
                name: "AsignacionSistemaIdAsignacionSistema",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evento_AsignacionSistemaIdAsignacionSistema",
                table: "Evento",
                column: "AsignacionSistemaIdAsignacionSistema");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_AsignacionSistema_AsignacionSistemaIdAsignacionSistema",
                table: "Evento",
                column: "AsignacionSistemaIdAsignacionSistema",
                principalTable: "AsignacionSistema",
                principalColumn: "IdAsignacionSistema",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
