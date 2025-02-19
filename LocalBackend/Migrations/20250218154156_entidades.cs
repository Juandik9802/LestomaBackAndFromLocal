using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class entidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LogsEstados_IdLogsEstados",
                table: "LogsEstados");

            migrationBuilder.CreateTable(
                name: "AsignacionMedios",
                columns: table => new
                {
                    IdAsignacionMedio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMedio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoElemento = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionMedios", x => x.IdAsignacionMedio);
                });

            migrationBuilder.CreateTable(
                name: "AsignacionSistema",
                columns: table => new
                {
                    IdAsignacionSistema = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUpa = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSistema = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionSistema", x => x.IdAsignacionSistema);
                });

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
                name: "CantidadElementos",
                columns: table => new
                {
                    IdCatidadElemento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdElemento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAsignacionSistema = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cantidad = table.Column<float>(type: "real", nullable: false),
                    IdUnidadMedida = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CantidadElementos", x => x.IdCatidadElemento);
                });

            migrationBuilder.CreateTable(
                name: "Elementos",
                columns: table => new
                {
                    IdElemento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoElemento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elementos", x => x.IdElemento);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    IdEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAsignacionSitema = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdElemento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAtributoSistema = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cantidad = table.Column<float>(type: "real", nullable: false),
                    IdUnidadMedida = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaEvento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.IdEvento);
                });

            migrationBuilder.CreateTable(
                name: "Impactos",
                columns: table => new
                {
                    IdImpacto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impactos", x => x.IdImpacto);
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
                name: "Mediciones",
                columns: table => new
                {
                    IdMedicion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDispositivos = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUnidadMedida = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mediciones", x => x.IdMedicion);
                });

            migrationBuilder.CreateTable(
                name: "MedioProduccion",
                columns: table => new
                {
                    IdMedioProduccion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedioProduccion", x => x.IdMedioProduccion);
                });

            migrationBuilder.CreateTable(
                name: "PropiedadesSistema",
                columns: table => new
                {
                    IdPropiedadSistema = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAsignacionSistema = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoAtributo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    IdUnidadMedida = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CantidadAtributo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropiedadesSistema", x => x.IdPropiedadSistema);
                });

            migrationBuilder.CreateTable(
                name: "PuntoOptimo",
                columns: table => new
                {
                    IdPuntoOPtimo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDispositivo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ValorOptimo = table.Column<float>(type: "real", nullable: false),
                    ValorMaximo = table.Column<float>(type: "real", nullable: false),
                    ValorMinimo = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntoOptimo", x => x.IdPuntoOPtimo);
                });

            migrationBuilder.CreateTable(
                name: "Sistemas",
                columns: table => new
                {
                    IdSistema = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sistemas", x => x.IdSistema);
                });

            migrationBuilder.CreateTable(
                name: "TipoElementos",
                columns: table => new
                {
                    IdTipoElemento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoElementos", x => x.IdTipoElemento);
                });

            migrationBuilder.CreateTable(
                name: "TipoEventos",
                columns: table => new
                {
                    IdTipoEvento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IdImpacto = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEventos", x => x.IdTipoEvento);
                });

            migrationBuilder.CreateTable(
                name: "TipoMedicion",
                columns: table => new
                {
                    IdTipoMedicion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMedicion", x => x.IdTipoMedicion);
                });

            migrationBuilder.CreateTable(
                name: "UnidadMedida",
                columns: table => new
                {
                    IdUnidadMedida = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TipoMedicio = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadMedida", x => x.IdUnidadMedida);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auditoria_Fecha",
                table: "Auditoria",
                column: "Fecha",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Elementos_Nombre",
                table: "Elementos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Impactos_Nombre",
                table: "Impactos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Marca_Nombre",
                table: "Marca",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedioProduccion_Nombre",
                table: "MedioProduccion",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sistemas_Nombre",
                table: "Sistemas",
                column: "Nombre",
                unique: true,
                filter: "[Nombre] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TipoElementos_Nombre",
                table: "TipoElementos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoEventos_Nombre",
                table: "TipoEventos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoMedicion_Nombre",
                table: "TipoMedicion",
                column: "Nombre",
                unique: true,
                filter: "[Nombre] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UnidadMedida_Nombre",
                table: "UnidadMedida",
                column: "Nombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsignacionMedios");

            migrationBuilder.DropTable(
                name: "AsignacionSistema");

            migrationBuilder.DropTable(
                name: "Auditoria");

            migrationBuilder.DropTable(
                name: "CantidadElementos");

            migrationBuilder.DropTable(
                name: "Elementos");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Impactos");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Mediciones");

            migrationBuilder.DropTable(
                name: "MedioProduccion");

            migrationBuilder.DropTable(
                name: "PropiedadesSistema");

            migrationBuilder.DropTable(
                name: "PuntoOptimo");

            migrationBuilder.DropTable(
                name: "Sistemas");

            migrationBuilder.DropTable(
                name: "TipoElementos");

            migrationBuilder.DropTable(
                name: "TipoEventos");

            migrationBuilder.DropTable(
                name: "TipoMedicion");

            migrationBuilder.DropTable(
                name: "UnidadMedida");

            migrationBuilder.CreateIndex(
                name: "IX_LogsEstados_IdLogsEstados",
                table: "LogsEstados",
                column: "IdLogsEstados",
                unique: true);
        }
    }
}
