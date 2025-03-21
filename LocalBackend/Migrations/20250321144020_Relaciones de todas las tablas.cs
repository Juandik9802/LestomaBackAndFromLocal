using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class Relacionesdetodaslastablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elemento_TipoElemento_TipoElementosIdTipoElemento",
                table: "Elemento");

            migrationBuilder.DropForeignKey(
                name: "FK_LogsEstado_Dispositivo_ClsMDispositivoIdDispisitivo",
                table: "LogsEstado");

            migrationBuilder.DropIndex(
                name: "IX_Sistema_Nombre",
                table: "Sistema");

            migrationBuilder.DropIndex(
                name: "IX_Elemento_TipoElementosIdTipoElemento",
                table: "Elemento");

            migrationBuilder.DropColumn(
                name: "IdDispositivo",
                table: "PuntoOptimo");

            migrationBuilder.DropColumn(
                name: "IdAsignacionSistema",
                table: "PropiedadesSistema");

            migrationBuilder.DropColumn(
                name: "IdTipoAtributo",
                table: "PropiedadesSistema");

            migrationBuilder.DropColumn(
                name: "IdDispositivo",
                table: "LogsEstado");

            migrationBuilder.DropColumn(
                name: "IdTipoElemento",
                table: "Elemento");

            migrationBuilder.DropColumn(
                name: "TipoElementosIdTipoElemento",
                table: "Elemento");

            migrationBuilder.DropColumn(
                name: "IdAsignacionSistema",
                table: "CantidadElemento");

            migrationBuilder.DropColumn(
                name: "IdElemento",
                table: "CantidadElemento");

            migrationBuilder.DropColumn(
                name: "IdUnidadMedida",
                table: "CantidadElemento");

            migrationBuilder.DropColumn(
                name: "IdSistema",
                table: "AsignacionSistema");

            migrationBuilder.DropColumn(
                name: "IdMedio",
                table: "AsignacionMedio");

            migrationBuilder.RenameColumn(
                name: "IdUnidadMedida",
                table: "PropiedadesSistema",
                newName: "UnidadMedidaId");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "LogsEstado",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "IdEstadoDsipositivo",
                table: "LogsEstado",
                newName: "EstadoDipositivoId");

            migrationBuilder.RenameColumn(
                name: "ClsMDispositivoIdDispisitivo",
                table: "LogsEstado",
                newName: "DispositivoId");

            migrationBuilder.RenameIndex(
                name: "IX_LogsEstado_ClsMDispositivoIdDispisitivo",
                table: "LogsEstado",
                newName: "IX_LogsEstado_DispositivoId");

            migrationBuilder.RenameColumn(
                name: "IdTipoElemento",
                table: "AsignacionMedio",
                newName: "TipoElementoId");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Sistema",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DispositivoId",
                table: "PuntoOptimo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AsignacionSistemaId",
                table: "PropiedadesSistema",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TipoElementoId",
                table: "Elemento",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AsignacionSistemaId",
                table: "CantidadElemento",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ElementoId",
                table: "CantidadElemento",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UnidadMedidaId",
                table: "CantidadElemento",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUpa",
                table: "AsignacionSistema",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "SistemaId",
                table: "AsignacionSistema",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MedioId",
                table: "AsignacionMedio",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sistema_Nombre",
                table: "Sistema",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PuntoOptimo_DispositivoId",
                table: "PuntoOptimo",
                column: "DispositivoId");

            migrationBuilder.CreateIndex(
                name: "IX_PropiedadesSistema_AsignacionSistemaId",
                table: "PropiedadesSistema",
                column: "AsignacionSistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_PropiedadesSistema_UnidadMedidaId",
                table: "PropiedadesSistema",
                column: "UnidadMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_LogsEstado_EstadoDipositivoId",
                table: "LogsEstado",
                column: "EstadoDipositivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Elemento_TipoElementoId",
                table: "Elemento",
                column: "TipoElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_CantidadElemento_AsignacionSistemaId",
                table: "CantidadElemento",
                column: "AsignacionSistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_CantidadElemento_ElementoId",
                table: "CantidadElemento",
                column: "ElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_CantidadElemento_UnidadMedidaId",
                table: "CantidadElemento",
                column: "UnidadMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionSistema_SistemaId",
                table: "AsignacionSistema",
                column: "SistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionMedio_MedioId",
                table: "AsignacionMedio",
                column: "MedioId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionMedio_TipoElementoId",
                table: "AsignacionMedio",
                column: "TipoElementoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AsignacionMedio_Medio_MedioId",
                table: "AsignacionMedio",
                column: "MedioId",
                principalTable: "Medio",
                principalColumn: "IdMedio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AsignacionMedio_TipoElemento_TipoElementoId",
                table: "AsignacionMedio",
                column: "TipoElementoId",
                principalTable: "TipoElemento",
                principalColumn: "IdTipoElemento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AsignacionSistema_Sistema_SistemaId",
                table: "AsignacionSistema",
                column: "SistemaId",
                principalTable: "Sistema",
                principalColumn: "IdSistema",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CantidadElemento_AsignacionSistema_AsignacionSistemaId",
                table: "CantidadElemento",
                column: "AsignacionSistemaId",
                principalTable: "AsignacionSistema",
                principalColumn: "IdAsignacionSistema",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CantidadElemento_Elemento_ElementoId",
                table: "CantidadElemento",
                column: "ElementoId",
                principalTable: "Elemento",
                principalColumn: "IdElemento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CantidadElemento_UnidadMedida_UnidadMedidaId",
                table: "CantidadElemento",
                column: "UnidadMedidaId",
                principalTable: "UnidadMedida",
                principalColumn: "IdUnidadMedida",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Elemento_TipoElemento_TipoElementoId",
                table: "Elemento",
                column: "TipoElementoId",
                principalTable: "TipoElemento",
                principalColumn: "IdTipoElemento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LogsEstado_Dispositivo_DispositivoId",
                table: "LogsEstado",
                column: "DispositivoId",
                principalTable: "Dispositivo",
                principalColumn: "IdDispisitivo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LogsEstado_EstadosDispositivo_EstadoDipositivoId",
                table: "LogsEstado",
                column: "EstadoDipositivoId",
                principalTable: "EstadosDispositivo",
                principalColumn: "IdEstadoDispositivo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropiedadesSistema_AsignacionSistema_AsignacionSistemaId",
                table: "PropiedadesSistema",
                column: "AsignacionSistemaId",
                principalTable: "AsignacionSistema",
                principalColumn: "IdAsignacionSistema",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropiedadesSistema_UnidadMedida_UnidadMedidaId",
                table: "PropiedadesSistema",
                column: "UnidadMedidaId",
                principalTable: "UnidadMedida",
                principalColumn: "IdUnidadMedida",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PuntoOptimo_Dispositivo_DispositivoId",
                table: "PuntoOptimo",
                column: "DispositivoId",
                principalTable: "Dispositivo",
                principalColumn: "IdDispisitivo",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsignacionMedio_Medio_MedioId",
                table: "AsignacionMedio");

            migrationBuilder.DropForeignKey(
                name: "FK_AsignacionMedio_TipoElemento_TipoElementoId",
                table: "AsignacionMedio");

            migrationBuilder.DropForeignKey(
                name: "FK_AsignacionSistema_Sistema_SistemaId",
                table: "AsignacionSistema");

            migrationBuilder.DropForeignKey(
                name: "FK_CantidadElemento_AsignacionSistema_AsignacionSistemaId",
                table: "CantidadElemento");

            migrationBuilder.DropForeignKey(
                name: "FK_CantidadElemento_Elemento_ElementoId",
                table: "CantidadElemento");

            migrationBuilder.DropForeignKey(
                name: "FK_CantidadElemento_UnidadMedida_UnidadMedidaId",
                table: "CantidadElemento");

            migrationBuilder.DropForeignKey(
                name: "FK_Elemento_TipoElemento_TipoElementoId",
                table: "Elemento");

            migrationBuilder.DropForeignKey(
                name: "FK_LogsEstado_Dispositivo_DispositivoId",
                table: "LogsEstado");

            migrationBuilder.DropForeignKey(
                name: "FK_LogsEstado_EstadosDispositivo_EstadoDipositivoId",
                table: "LogsEstado");

            migrationBuilder.DropForeignKey(
                name: "FK_PropiedadesSistema_AsignacionSistema_AsignacionSistemaId",
                table: "PropiedadesSistema");

            migrationBuilder.DropForeignKey(
                name: "FK_PropiedadesSistema_UnidadMedida_UnidadMedidaId",
                table: "PropiedadesSistema");

            migrationBuilder.DropForeignKey(
                name: "FK_PuntoOptimo_Dispositivo_DispositivoId",
                table: "PuntoOptimo");

            migrationBuilder.DropIndex(
                name: "IX_Sistema_Nombre",
                table: "Sistema");

            migrationBuilder.DropIndex(
                name: "IX_PuntoOptimo_DispositivoId",
                table: "PuntoOptimo");

            migrationBuilder.DropIndex(
                name: "IX_PropiedadesSistema_AsignacionSistemaId",
                table: "PropiedadesSistema");

            migrationBuilder.DropIndex(
                name: "IX_PropiedadesSistema_UnidadMedidaId",
                table: "PropiedadesSistema");

            migrationBuilder.DropIndex(
                name: "IX_LogsEstado_EstadoDipositivoId",
                table: "LogsEstado");

            migrationBuilder.DropIndex(
                name: "IX_Elemento_TipoElementoId",
                table: "Elemento");

            migrationBuilder.DropIndex(
                name: "IX_CantidadElemento_AsignacionSistemaId",
                table: "CantidadElemento");

            migrationBuilder.DropIndex(
                name: "IX_CantidadElemento_ElementoId",
                table: "CantidadElemento");

            migrationBuilder.DropIndex(
                name: "IX_CantidadElemento_UnidadMedidaId",
                table: "CantidadElemento");

            migrationBuilder.DropIndex(
                name: "IX_AsignacionSistema_SistemaId",
                table: "AsignacionSistema");

            migrationBuilder.DropIndex(
                name: "IX_AsignacionMedio_MedioId",
                table: "AsignacionMedio");

            migrationBuilder.DropIndex(
                name: "IX_AsignacionMedio_TipoElementoId",
                table: "AsignacionMedio");

            migrationBuilder.DropColumn(
                name: "DispositivoId",
                table: "PuntoOptimo");

            migrationBuilder.DropColumn(
                name: "AsignacionSistemaId",
                table: "PropiedadesSistema");

            migrationBuilder.DropColumn(
                name: "TipoElementoId",
                table: "Elemento");

            migrationBuilder.DropColumn(
                name: "AsignacionSistemaId",
                table: "CantidadElemento");

            migrationBuilder.DropColumn(
                name: "ElementoId",
                table: "CantidadElemento");

            migrationBuilder.DropColumn(
                name: "UnidadMedidaId",
                table: "CantidadElemento");

            migrationBuilder.DropColumn(
                name: "SistemaId",
                table: "AsignacionSistema");

            migrationBuilder.DropColumn(
                name: "MedioId",
                table: "AsignacionMedio");

            migrationBuilder.RenameColumn(
                name: "UnidadMedidaId",
                table: "PropiedadesSistema",
                newName: "IdUnidadMedida");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "LogsEstado",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "EstadoDipositivoId",
                table: "LogsEstado",
                newName: "IdEstadoDsipositivo");

            migrationBuilder.RenameColumn(
                name: "DispositivoId",
                table: "LogsEstado",
                newName: "ClsMDispositivoIdDispisitivo");

            migrationBuilder.RenameIndex(
                name: "IX_LogsEstado_DispositivoId",
                table: "LogsEstado",
                newName: "IX_LogsEstado_ClsMDispositivoIdDispisitivo");

            migrationBuilder.RenameColumn(
                name: "TipoElementoId",
                table: "AsignacionMedio",
                newName: "IdTipoElemento");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Sistema",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "IdDispositivo",
                table: "PuntoOptimo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdAsignacionSistema",
                table: "PropiedadesSistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdTipoAtributo",
                table: "PropiedadesSistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdDispositivo",
                table: "LogsEstado",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdTipoElemento",
                table: "Elemento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TipoElementosIdTipoElemento",
                table: "Elemento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdAsignacionSistema",
                table: "CantidadElemento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdElemento",
                table: "CantidadElemento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUnidadMedida",
                table: "CantidadElemento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUpa",
                table: "AsignacionSistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdSistema",
                table: "AsignacionSistema",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdMedio",
                table: "AsignacionMedio",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Sistema_Nombre",
                table: "Sistema",
                column: "Nombre",
                unique: true,
                filter: "[Nombre] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Elemento_TipoElementosIdTipoElemento",
                table: "Elemento",
                column: "TipoElementosIdTipoElemento");

            migrationBuilder.AddForeignKey(
                name: "FK_Elemento_TipoElemento_TipoElementosIdTipoElemento",
                table: "Elemento",
                column: "TipoElementosIdTipoElemento",
                principalTable: "TipoElemento",
                principalColumn: "IdTipoElemento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LogsEstado_Dispositivo_ClsMDispositivoIdDispisitivo",
                table: "LogsEstado",
                column: "ClsMDispositivoIdDispisitivo",
                principalTable: "Dispositivo",
                principalColumn: "IdDispisitivo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
