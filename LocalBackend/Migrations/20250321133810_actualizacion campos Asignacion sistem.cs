using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class actualizacioncamposAsignacionsistem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdAsignacionSitema",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "IdAtributoSistema",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "IdElemento",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "IdUnidadMedida",
                table: "Evento");

            migrationBuilder.AlterColumn<Guid>(
                name: "TipoEventoId",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "AsignacionSitemaId",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ElementoId",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PropiedadesSistemaId",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UnidadMedidaId",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "asignacionSistemaIdAsignacionSistema",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evento_asignacionSistemaIdAsignacionSistema",
                table: "Evento",
                column: "asignacionSistemaIdAsignacionSistema");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_PropiedadesSistemaId",
                table: "Evento",
                column: "PropiedadesSistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_UnidadMedidaId",
                table: "Evento",
                column: "UnidadMedidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_AsignacionSistema_asignacionSistemaIdAsignacionSistema",
                table: "Evento",
                column: "asignacionSistemaIdAsignacionSistema",
                principalTable: "AsignacionSistema",
                principalColumn: "IdAsignacionSistema",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_PropiedadesSistema_PropiedadesSistemaId",
                table: "Evento",
                column: "PropiedadesSistemaId",
                principalTable: "PropiedadesSistema",
                principalColumn: "IdPropiedadSistema",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_UnidadMedida_UnidadMedidaId",
                table: "Evento",
                column: "UnidadMedidaId",
                principalTable: "UnidadMedida",
                principalColumn: "IdUnidadMedida",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_AsignacionSistema_asignacionSistemaIdAsignacionSistema",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_PropiedadesSistema_PropiedadesSistemaId",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_UnidadMedida_UnidadMedidaId",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_asignacionSistemaIdAsignacionSistema",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_PropiedadesSistemaId",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_UnidadMedidaId",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "AsignacionSitemaId",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ElementoId",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "PropiedadesSistemaId",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "UnidadMedidaId",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "asignacionSistemaIdAsignacionSistema",
                table: "Evento");

            migrationBuilder.AlterColumn<Guid>(
                name: "TipoEventoId",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdAsignacionSitema",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdAtributoSistema",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdElemento",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUnidadMedida",
                table: "Evento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
