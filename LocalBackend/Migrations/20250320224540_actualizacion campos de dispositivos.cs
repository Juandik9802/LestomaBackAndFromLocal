using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class actualizacioncamposdedispositivos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dispositivo_AsignacionMedio_AsignacionMedioIdAsignacionMedio",
                table: "Dispositivo");

            migrationBuilder.DropIndex(
                name: "IX_Dispositivo_AsignacionMedioIdAsignacionMedio",
                table: "Dispositivo");

            migrationBuilder.DropColumn(
                name: "AsignacionMedioIdAsignacionMedio",
                table: "Dispositivo");

            migrationBuilder.AlterColumn<Guid>(
                name: "UnidadMedidaId",
                table: "Medicion",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DispositivoId",
                table: "Medicion",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ClsMDispositivoIdDispisitivo",
                table: "LogsEstado",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "TipoDispositivoId",
                table: "Dispositivo",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AsignacionSistemaId",
                table: "Dispositivo",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_LogsEstado_ClsMDispositivoIdDispisitivo",
                table: "LogsEstado",
                column: "ClsMDispositivoIdDispisitivo");

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivo_AsignacionSistemaId",
                table: "Dispositivo",
                column: "AsignacionSistemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dispositivo_AsignacionSistema_AsignacionSistemaId",
                table: "Dispositivo",
                column: "AsignacionSistemaId",
                principalTable: "AsignacionSistema",
                principalColumn: "IdAsignacionSistema",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LogsEstado_Dispositivo_ClsMDispositivoIdDispisitivo",
                table: "LogsEstado",
                column: "ClsMDispositivoIdDispisitivo",
                principalTable: "Dispositivo",
                principalColumn: "IdDispisitivo",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dispositivo_AsignacionSistema_AsignacionSistemaId",
                table: "Dispositivo");

            migrationBuilder.DropForeignKey(
                name: "FK_LogsEstado_Dispositivo_ClsMDispositivoIdDispisitivo",
                table: "LogsEstado");

            migrationBuilder.DropIndex(
                name: "IX_LogsEstado_ClsMDispositivoIdDispisitivo",
                table: "LogsEstado");

            migrationBuilder.DropIndex(
                name: "IX_Dispositivo_AsignacionSistemaId",
                table: "Dispositivo");

            migrationBuilder.DropColumn(
                name: "ClsMDispositivoIdDispisitivo",
                table: "LogsEstado");

            migrationBuilder.AlterColumn<Guid>(
                name: "UnidadMedidaId",
                table: "Medicion",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DispositivoId",
                table: "Medicion",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "TipoDispositivoId",
                table: "Dispositivo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AsignacionSistemaId",
                table: "Dispositivo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AsignacionMedioIdAsignacionMedio",
                table: "Dispositivo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
    }
}
