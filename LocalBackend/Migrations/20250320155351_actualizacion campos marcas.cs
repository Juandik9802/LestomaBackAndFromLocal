using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class actualizacioncamposmarcas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UnidadMedida_Nombre",
                table: "UnidadMedida");

            migrationBuilder.RenameColumn(
                name: "IdAsignacionSistema",
                table: "Dispositivo",
                newName: "AsignacionSistemaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "UnidadMedida",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "AsignacionMedioIdAsignacionMedio",
                table: "Dispositivo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_UnidadMedida_Nombre",
                table: "UnidadMedida",
                column: "Nombre",
                unique: true,
                filter: "[Nombre] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivo_AsignacionMedioIdAsignacionMedio",
                table: "Dispositivo",
                column: "AsignacionMedioIdAsignacionMedio");

            migrationBuilder.AddForeignKey(
                name: "FK_Dispositivo_AsignacionMedio_AsignacionMedioIdAsignacionMedio",
                table: "Dispositivo",
                column: "AsignacionMedioIdAsignacionMedio",
                principalTable: "AsignacionMedio",
                principalColumn: "IdAsignacionMedio",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dispositivo_AsignacionMedio_AsignacionMedioIdAsignacionMedio",
                table: "Dispositivo");

            migrationBuilder.DropIndex(
                name: "IX_UnidadMedida_Nombre",
                table: "UnidadMedida");

            migrationBuilder.DropIndex(
                name: "IX_Dispositivo_AsignacionMedioIdAsignacionMedio",
                table: "Dispositivo");

            migrationBuilder.DropColumn(
                name: "AsignacionMedioIdAsignacionMedio",
                table: "Dispositivo");

            migrationBuilder.RenameColumn(
                name: "AsignacionSistemaId",
                table: "Dispositivo",
                newName: "IdAsignacionSistema");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "UnidadMedida",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnidadMedida_Nombre",
                table: "UnidadMedida",
                column: "Nombre",
                unique: true);
        }
    }
}
