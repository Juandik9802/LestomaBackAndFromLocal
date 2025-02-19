using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class nuevosistema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dispositivos",
                columns: table => new
                {
                    IdDispisitivo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdAsignacionSistema = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoDispositivo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMarca = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SN = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispositivos", x => x.IdDispisitivo);
                });

            migrationBuilder.CreateTable(
                name: "EstadosDispositivos",
                columns: table => new
                {
                    IdEstadoDispositivo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoDispositivo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosDispositivos", x => x.IdEstadoDispositivo);
                });

            migrationBuilder.CreateTable(
                name: "LogsEstados",
                columns: table => new
                {
                    IdLogsEstados = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDispositivo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEstadoDsipositivo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MyProperty = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogsEstados", x => x.IdLogsEstados);
                });

            migrationBuilder.CreateTable(
                name: "TipoDispositivos",
                columns: table => new
                {
                    IdTipoDispositivo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDispositivos", x => x.IdTipoDispositivo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivos_SN",
                table: "Dispositivos",
                column: "SN",
                unique: true,
                filter: "[SN] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EstadosDispositivos_Nombre",
                table: "EstadosDispositivos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LogsEstados_IdLogsEstados",
                table: "LogsEstados",
                column: "IdLogsEstados",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoDispositivos_Nombre",
                table: "TipoDispositivos",
                column: "Nombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dispositivos");

            migrationBuilder.DropTable(
                name: "EstadosDispositivos");

            migrationBuilder.DropTable(
                name: "LogsEstados");

            migrationBuilder.DropTable(
                name: "TipoDispositivos");
        }
    }
}
