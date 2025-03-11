using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class CorrecionerroreDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoEventos",
                table: "TipoEventos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoElementos",
                table: "TipoElementos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoDispositivos",
                table: "TipoDispositivos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sistemas",
                table: "Sistemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mediciones",
                table: "Mediciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LogsEstados",
                table: "LogsEstados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Impactos",
                table: "Impactos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Eventos",
                table: "Eventos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosDispositivos",
                table: "EstadosDispositivos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Elementos",
                table: "Elementos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dispositivos",
                table: "Dispositivos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CantidadElementos",
                table: "CantidadElementos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AsignacionMedios",
                table: "AsignacionMedios");

            migrationBuilder.RenameTable(
                name: "TipoEventos",
                newName: "TipoEvento");

            migrationBuilder.RenameTable(
                name: "TipoElementos",
                newName: "TipoElemento");

            migrationBuilder.RenameTable(
                name: "TipoDispositivos",
                newName: "TipoDispositivo");

            migrationBuilder.RenameTable(
                name: "Sistemas",
                newName: "Sistema");

            migrationBuilder.RenameTable(
                name: "Mediciones",
                newName: "Medicione");

            migrationBuilder.RenameTable(
                name: "LogsEstados",
                newName: "LogsEstado");

            migrationBuilder.RenameTable(
                name: "Impactos",
                newName: "Impacto");

            migrationBuilder.RenameTable(
                name: "Eventos",
                newName: "Evento");

            migrationBuilder.RenameTable(
                name: "EstadosDispositivos",
                newName: "EstadosDispositivo");

            migrationBuilder.RenameTable(
                name: "Elementos",
                newName: "Elemento");

            migrationBuilder.RenameTable(
                name: "Dispositivos",
                newName: "Dispositivo");

            migrationBuilder.RenameTable(
                name: "CantidadElementos",
                newName: "CantidadElemento");

            migrationBuilder.RenameTable(
                name: "AsignacionMedios",
                newName: "AsignacionMedio");

            migrationBuilder.RenameIndex(
                name: "IX_TipoEventos_Nombre",
                table: "TipoEvento",
                newName: "IX_TipoEvento_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_TipoElementos_Nombre",
                table: "TipoElemento",
                newName: "IX_TipoElemento_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_TipoDispositivos_Nombre",
                table: "TipoDispositivo",
                newName: "IX_TipoDispositivo_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_Sistemas_Nombre",
                table: "Sistema",
                newName: "IX_Sistema_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_Mediciones_UnidadMedidaId",
                table: "Medicione",
                newName: "IX_Medicione_UnidadMedidaId");

            migrationBuilder.RenameIndex(
                name: "IX_Mediciones_DispositivoId",
                table: "Medicione",
                newName: "IX_Medicione_DispositivoId");

            migrationBuilder.RenameIndex(
                name: "IX_Impactos_Nombre",
                table: "Impacto",
                newName: "IX_Impacto_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_EstadosDispositivos_Nombre",
                table: "EstadosDispositivo",
                newName: "IX_EstadosDispositivo_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_Elementos_TipoElementosIdTipoElemento",
                table: "Elemento",
                newName: "IX_Elemento_TipoElementosIdTipoElemento");

            migrationBuilder.RenameIndex(
                name: "IX_Elementos_Nombre",
                table: "Elemento",
                newName: "IX_Elemento_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_Dispositivos_SN",
                table: "Dispositivo",
                newName: "IX_Dispositivo_SN");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoEvento",
                table: "TipoEvento",
                column: "IdTipoEvento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoElemento",
                table: "TipoElemento",
                column: "IdTipoElemento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoDispositivo",
                table: "TipoDispositivo",
                column: "IdTipoDispositivo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sistema",
                table: "Sistema",
                column: "IdSistema");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicione",
                table: "Medicione",
                column: "IdMedicion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogsEstado",
                table: "LogsEstado",
                column: "IdLogsEstados");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Impacto",
                table: "Impacto",
                column: "IdImpacto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Evento",
                table: "Evento",
                column: "IdEvento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosDispositivo",
                table: "EstadosDispositivo",
                column: "IdEstadoDispositivo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Elemento",
                table: "Elemento",
                column: "IdElemento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dispositivo",
                table: "Dispositivo",
                column: "IdDispisitivo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CantidadElemento",
                table: "CantidadElemento",
                column: "IdCatidadElemento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AsignacionMedio",
                table: "AsignacionMedio",
                column: "IdAsignacionMedio");

            migrationBuilder.AddForeignKey(
                name: "FK_Elemento_TipoElemento_TipoElementosIdTipoElemento",
                table: "Elemento",
                column: "TipoElementosIdTipoElemento",
                principalTable: "TipoElemento",
                principalColumn: "IdTipoElemento",
                onDelete: ReferentialAction.Restrict);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elemento_TipoElemento_TipoElementosIdTipoElemento",
                table: "Elemento");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicione_Dispositivo_DispositivoId",
                table: "Medicione");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicione_UnidadMedida_UnidadMedidaId",
                table: "Medicione");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoEvento",
                table: "TipoEvento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoElemento",
                table: "TipoElemento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoDispositivo",
                table: "TipoDispositivo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sistema",
                table: "Sistema");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicione",
                table: "Medicione");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LogsEstado",
                table: "LogsEstado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Impacto",
                table: "Impacto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Evento",
                table: "Evento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosDispositivo",
                table: "EstadosDispositivo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Elemento",
                table: "Elemento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dispositivo",
                table: "Dispositivo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CantidadElemento",
                table: "CantidadElemento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AsignacionMedio",
                table: "AsignacionMedio");

            migrationBuilder.RenameTable(
                name: "TipoEvento",
                newName: "TipoEventos");

            migrationBuilder.RenameTable(
                name: "TipoElemento",
                newName: "TipoElementos");

            migrationBuilder.RenameTable(
                name: "TipoDispositivo",
                newName: "TipoDispositivos");

            migrationBuilder.RenameTable(
                name: "Sistema",
                newName: "Sistemas");

            migrationBuilder.RenameTable(
                name: "Medicione",
                newName: "Mediciones");

            migrationBuilder.RenameTable(
                name: "LogsEstado",
                newName: "LogsEstados");

            migrationBuilder.RenameTable(
                name: "Impacto",
                newName: "Impactos");

            migrationBuilder.RenameTable(
                name: "Evento",
                newName: "Eventos");

            migrationBuilder.RenameTable(
                name: "EstadosDispositivo",
                newName: "EstadosDispositivos");

            migrationBuilder.RenameTable(
                name: "Elemento",
                newName: "Elementos");

            migrationBuilder.RenameTable(
                name: "Dispositivo",
                newName: "Dispositivos");

            migrationBuilder.RenameTable(
                name: "CantidadElemento",
                newName: "CantidadElementos");

            migrationBuilder.RenameTable(
                name: "AsignacionMedio",
                newName: "AsignacionMedios");

            migrationBuilder.RenameIndex(
                name: "IX_TipoEvento_Nombre",
                table: "TipoEventos",
                newName: "IX_TipoEventos_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_TipoElemento_Nombre",
                table: "TipoElementos",
                newName: "IX_TipoElementos_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_TipoDispositivo_Nombre",
                table: "TipoDispositivos",
                newName: "IX_TipoDispositivos_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_Sistema_Nombre",
                table: "Sistemas",
                newName: "IX_Sistemas_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_Medicione_UnidadMedidaId",
                table: "Mediciones",
                newName: "IX_Mediciones_UnidadMedidaId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicione_DispositivoId",
                table: "Mediciones",
                newName: "IX_Mediciones_DispositivoId");

            migrationBuilder.RenameIndex(
                name: "IX_Impacto_Nombre",
                table: "Impactos",
                newName: "IX_Impactos_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_EstadosDispositivo_Nombre",
                table: "EstadosDispositivos",
                newName: "IX_EstadosDispositivos_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_Elemento_TipoElementosIdTipoElemento",
                table: "Elementos",
                newName: "IX_Elementos_TipoElementosIdTipoElemento");

            migrationBuilder.RenameIndex(
                name: "IX_Elemento_Nombre",
                table: "Elementos",
                newName: "IX_Elementos_Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_Dispositivo_SN",
                table: "Dispositivos",
                newName: "IX_Dispositivos_SN");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoEventos",
                table: "TipoEventos",
                column: "IdTipoEvento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoElementos",
                table: "TipoElementos",
                column: "IdTipoElemento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoDispositivos",
                table: "TipoDispositivos",
                column: "IdTipoDispositivo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sistemas",
                table: "Sistemas",
                column: "IdSistema");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mediciones",
                table: "Mediciones",
                column: "IdMedicion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogsEstados",
                table: "LogsEstados",
                column: "IdLogsEstados");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Impactos",
                table: "Impactos",
                column: "IdImpacto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Eventos",
                table: "Eventos",
                column: "IdEvento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosDispositivos",
                table: "EstadosDispositivos",
                column: "IdEstadoDispositivo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Elementos",
                table: "Elementos",
                column: "IdElemento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dispositivos",
                table: "Dispositivos",
                column: "IdDispisitivo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CantidadElementos",
                table: "CantidadElementos",
                column: "IdCatidadElemento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AsignacionMedios",
                table: "AsignacionMedios",
                column: "IdAsignacionMedio");

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
        }
    }
}
