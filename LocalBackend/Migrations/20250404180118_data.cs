using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auditoria",
                columns: table => new
                {
                    IdAuditoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Accion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tabla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditoria", x => x.IdAuditoria);
                });

            migrationBuilder.CreateTable(
                name: "EstadosDispositivo",
                columns: table => new
                {
                    IdEstadoDispositivo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosDispositivo", x => x.IdEstadoDispositivo);
                });

            migrationBuilder.CreateTable(
                name: "Impacto",
                columns: table => new
                {
                    IdImpacto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impacto", x => x.IdImpacto);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    IdMarca = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.IdMarca);
                });

            migrationBuilder.CreateTable(
                name: "Medio",
                columns: table => new
                {
                    IdMedio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medio", x => x.IdMedio);
                });

            migrationBuilder.CreateTable(
                name: "Sistema",
                columns: table => new
                {
                    IdSistema = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sistema", x => x.IdSistema);
                });

            migrationBuilder.CreateTable(
                name: "TipoDispositivo",
                columns: table => new
                {
                    IdTipoDispositivo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDispositivo", x => x.IdTipoDispositivo);
                });

            migrationBuilder.CreateTable(
                name: "TipoElemento",
                columns: table => new
                {
                    IdTipoElemento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoElemento", x => x.IdTipoElemento);
                });

            migrationBuilder.CreateTable(
                name: "TipoMedicion",
                columns: table => new
                {
                    IdTipoMedicion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMedicion", x => x.IdTipoMedicion);
                });

            migrationBuilder.CreateTable(
                name: "TipoEvento",
                columns: table => new
                {
                    IdTipoEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImpactoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEvento", x => x.IdTipoEvento);
                    table.ForeignKey(
                        name: "FK_TipoEvento_Impacto_ImpactoId",
                        column: x => x.ImpactoId,
                        principalTable: "Impacto",
                        principalColumn: "IdImpacto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AsignacionSistema",
                columns: table => new
                {
                    IdAsignacionSistema = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUpa = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SistemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionSistema", x => x.IdAsignacionSistema);
                    table.ForeignKey(
                        name: "FK_AsignacionSistema_Sistema_SistemaId",
                        column: x => x.SistemaId,
                        principalTable: "Sistema",
                        principalColumn: "IdSistema",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AsignacionMedio",
                columns: table => new
                {
                    IdAsignacionMedio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TipoElementoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionMedio", x => x.IdAsignacionMedio);
                    table.ForeignKey(
                        name: "FK_AsignacionMedio_Medio_MedioId",
                        column: x => x.MedioId,
                        principalTable: "Medio",
                        principalColumn: "IdMedio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AsignacionMedio_TipoElemento_TipoElementoId",
                        column: x => x.TipoElementoId,
                        principalTable: "TipoElemento",
                        principalColumn: "IdTipoElemento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Elemento",
                columns: table => new
                {
                    IdElemento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoElementoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elemento", x => x.IdElemento);
                    table.ForeignKey(
                        name: "FK_Elemento_TipoElemento_TipoElementoId",
                        column: x => x.TipoElementoId,
                        principalTable: "TipoElemento",
                        principalColumn: "IdTipoElemento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnidadMedida",
                columns: table => new
                {
                    IdUnidadMedida = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoMedicionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Simbolo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadMedida", x => x.IdUnidadMedida);
                    table.ForeignKey(
                        name: "FK_UnidadMedida_TipoMedicion_TipoMedicionId",
                        column: x => x.TipoMedicionId,
                        principalTable: "TipoMedicion",
                        principalColumn: "IdTipoMedicion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dispositivo",
                columns: table => new
                {
                    IdDispositivo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AsignacionSistemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TipoDispositivoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MarcaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SN = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispositivo", x => x.IdDispositivo);
                    table.ForeignKey(
                        name: "FK_Dispositivo_AsignacionSistema_AsignacionSistemaId",
                        column: x => x.AsignacionSistemaId,
                        principalTable: "AsignacionSistema",
                        principalColumn: "IdAsignacionSistema",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dispositivo_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "IdMarca",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dispositivo_TipoDispositivo_TipoDispositivoId",
                        column: x => x.TipoDispositivoId,
                        principalTable: "TipoDispositivo",
                        principalColumn: "IdTipoDispositivo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CantidadElemento",
                columns: table => new
                {
                    IdCatidadElemento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ElementoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AsignacionSistemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Cantidad = table.Column<float>(type: "real", nullable: false),
                    UnidadMedidaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CantidadElemento", x => x.IdCatidadElemento);
                    table.ForeignKey(
                        name: "FK_CantidadElemento_AsignacionSistema_AsignacionSistemaId",
                        column: x => x.AsignacionSistemaId,
                        principalTable: "AsignacionSistema",
                        principalColumn: "IdAsignacionSistema",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CantidadElemento_Elemento_ElementoId",
                        column: x => x.ElementoId,
                        principalTable: "Elemento",
                        principalColumn: "IdElemento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CantidadElemento_UnidadMedida_UnidadMedidaId",
                        column: x => x.UnidadMedidaId,
                        principalTable: "UnidadMedida",
                        principalColumn: "IdUnidadMedida",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropiedadesSistema",
                columns: table => new
                {
                    IdPropiedadSistema = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AsignacionSistemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    UnidadMedidaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CantidadAtributo = table.Column<int>(type: "int", nullable: false),
                    asignacionMedioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropiedadesSistema", x => x.IdPropiedadSistema);
                    table.ForeignKey(
                        name: "FK_PropiedadesSistema_AsignacionMedio_asignacionMedioId",
                        column: x => x.asignacionMedioId,
                        principalTable: "AsignacionMedio",
                        principalColumn: "IdAsignacionMedio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropiedadesSistema_AsignacionSistema_AsignacionSistemaId",
                        column: x => x.AsignacionSistemaId,
                        principalTable: "AsignacionSistema",
                        principalColumn: "IdAsignacionSistema",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropiedadesSistema_UnidadMedida_UnidadMedidaId",
                        column: x => x.UnidadMedidaId,
                        principalTable: "UnidadMedida",
                        principalColumn: "IdUnidadMedida",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LogsEstado",
                columns: table => new
                {
                    IdLogsEstado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DispositivoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EstadoDipositivoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogsEstado", x => x.IdLogsEstado);
                    table.ForeignKey(
                        name: "FK_LogsEstado_Dispositivo_DispositivoId",
                        column: x => x.DispositivoId,
                        principalTable: "Dispositivo",
                        principalColumn: "IdDispositivo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LogsEstado_EstadosDispositivo_EstadoDipositivoId",
                        column: x => x.EstadoDipositivoId,
                        principalTable: "EstadosDispositivo",
                        principalColumn: "IdEstadoDispositivo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medicion",
                columns: table => new
                {
                    IdMedicion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DispositivoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnidadMedidaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    valor = table.Column<float>(type: "real", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicion", x => x.IdMedicion);
                    table.ForeignKey(
                        name: "FK_Medicion_Dispositivo_DispositivoId",
                        column: x => x.DispositivoId,
                        principalTable: "Dispositivo",
                        principalColumn: "IdDispositivo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Medicion_UnidadMedida_UnidadMedidaId",
                        column: x => x.UnidadMedidaId,
                        principalTable: "UnidadMedida",
                        principalColumn: "IdUnidadMedida",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PuntoOptimo",
                columns: table => new
                {
                    IdPuntoOPtimo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DispositivoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ValorOptimo = table.Column<float>(type: "real", nullable: false),
                    ValorMaximo = table.Column<float>(type: "real", nullable: false),
                    ValorMinimo = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntoOptimo", x => x.IdPuntoOPtimo);
                    table.ForeignKey(
                        name: "FK_PuntoOptimo_Dispositivo_DispositivoId",
                        column: x => x.DispositivoId,
                        principalTable: "Dispositivo",
                        principalColumn: "IdDispositivo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    IdEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AsignacionSistemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ElementoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PropiedadesSistemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TipoEventoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Cantidad = table.Column<float>(type: "real", nullable: false),
                    UnidadMedidaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FechaEvento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.IdEvento);
                    table.ForeignKey(
                        name: "FK_Evento_AsignacionSistema_AsignacionSistemaId",
                        column: x => x.AsignacionSistemaId,
                        principalTable: "AsignacionSistema",
                        principalColumn: "IdAsignacionSistema",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_Elemento_ElementoId",
                        column: x => x.ElementoId,
                        principalTable: "Elemento",
                        principalColumn: "IdElemento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_PropiedadesSistema_PropiedadesSistemaId",
                        column: x => x.PropiedadesSistemaId,
                        principalTable: "PropiedadesSistema",
                        principalColumn: "IdPropiedadSistema",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_TipoEvento_TipoEventoId",
                        column: x => x.TipoEventoId,
                        principalTable: "TipoEvento",
                        principalColumn: "IdTipoEvento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_UnidadMedida_UnidadMedidaId",
                        column: x => x.UnidadMedidaId,
                        principalTable: "UnidadMedida",
                        principalColumn: "IdUnidadMedida",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionMedio_MedioId",
                table: "AsignacionMedio",
                column: "MedioId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionMedio_TipoElementoId",
                table: "AsignacionMedio",
                column: "TipoElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionSistema_SistemaId",
                table: "AsignacionSistema",
                column: "SistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Auditoria_Fecha",
                table: "Auditoria",
                column: "Fecha",
                unique: true);

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
                name: "IX_Dispositivo_AsignacionSistemaId",
                table: "Dispositivo",
                column: "AsignacionSistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivo_MarcaId",
                table: "Dispositivo",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivo_SN",
                table: "Dispositivo",
                column: "SN",
                unique: true,
                filter: "[SN] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivo_TipoDispositivoId",
                table: "Dispositivo",
                column: "TipoDispositivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Elemento_Nombre",
                table: "Elemento",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Elemento_TipoElementoId",
                table: "Elemento",
                column: "TipoElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadosDispositivo_Nombre",
                table: "EstadosDispositivo",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evento_AsignacionSistemaId",
                table: "Evento",
                column: "AsignacionSistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_ElementoId",
                table: "Evento",
                column: "ElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_PropiedadesSistemaId",
                table: "Evento",
                column: "PropiedadesSistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_TipoEventoId",
                table: "Evento",
                column: "TipoEventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_UnidadMedidaId",
                table: "Evento",
                column: "UnidadMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Impacto_Nombre",
                table: "Impacto",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LogsEstado_DispositivoId",
                table: "LogsEstado",
                column: "DispositivoId");

            migrationBuilder.CreateIndex(
                name: "IX_LogsEstado_EstadoDipositivoId",
                table: "LogsEstado",
                column: "EstadoDipositivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Marca_Nombre",
                table: "Marca",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicion_DispositivoId",
                table: "Medicion",
                column: "DispositivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicion_UnidadMedidaId",
                table: "Medicion",
                column: "UnidadMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medio_Nombre",
                table: "Medio",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropiedadesSistema_asignacionMedioId",
                table: "PropiedadesSistema",
                column: "asignacionMedioId");

            migrationBuilder.CreateIndex(
                name: "IX_PropiedadesSistema_AsignacionSistemaId",
                table: "PropiedadesSistema",
                column: "AsignacionSistemaId");

            migrationBuilder.CreateIndex(
                name: "IX_PropiedadesSistema_UnidadMedidaId",
                table: "PropiedadesSistema",
                column: "UnidadMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_PuntoOptimo_DispositivoId",
                table: "PuntoOptimo",
                column: "DispositivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sistema_Nombre",
                table: "Sistema",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoDispositivo_Nombre",
                table: "TipoDispositivo",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoElemento_Nombre",
                table: "TipoElemento",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoEvento_ImpactoId",
                table: "TipoEvento",
                column: "ImpactoId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoEvento_Nombre",
                table: "TipoEvento",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoMedicion_Nombre",
                table: "TipoMedicion",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnidadMedida_Nombre",
                table: "UnidadMedida",
                column: "Nombre",
                unique: true,
                filter: "[Nombre] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UnidadMedida_TipoMedicionId",
                table: "UnidadMedida",
                column: "TipoMedicionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auditoria");

            migrationBuilder.DropTable(
                name: "CantidadElemento");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "LogsEstado");

            migrationBuilder.DropTable(
                name: "Medicion");

            migrationBuilder.DropTable(
                name: "PuntoOptimo");

            migrationBuilder.DropTable(
                name: "Elemento");

            migrationBuilder.DropTable(
                name: "PropiedadesSistema");

            migrationBuilder.DropTable(
                name: "TipoEvento");

            migrationBuilder.DropTable(
                name: "EstadosDispositivo");

            migrationBuilder.DropTable(
                name: "Dispositivo");

            migrationBuilder.DropTable(
                name: "AsignacionMedio");

            migrationBuilder.DropTable(
                name: "UnidadMedida");

            migrationBuilder.DropTable(
                name: "Impacto");

            migrationBuilder.DropTable(
                name: "AsignacionSistema");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "TipoDispositivo");

            migrationBuilder.DropTable(
                name: "Medio");

            migrationBuilder.DropTable(
                name: "TipoElemento");

            migrationBuilder.DropTable(
                name: "TipoMedicion");

            migrationBuilder.DropTable(
                name: "Sistema");
        }
    }
}
