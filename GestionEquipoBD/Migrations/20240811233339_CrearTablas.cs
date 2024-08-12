using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionEquipo.BD.Migrations
{
    /// <inheritdoc />
    public partial class CrearTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrenamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrenamientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Posicion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rival = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsistEntrenamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asistio = table.Column<bool>(type: "bit", nullable: false),
                    JugadorId = table.Column<int>(type: "int", nullable: false),
                    EntrenamientoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsistEntrenamientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsistEntrenamientos_Jugadores_EntrenamientoId",
                        column: x => x.EntrenamientoId,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AsistEntrenamientos_Jugadores_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstPartidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Goles = table.Column<int>(type: "int", nullable: false),
                    Asistencias = table.Column<int>(type: "int", nullable: false),
                    JugadorId = table.Column<int>(type: "int", nullable: false),
                    PartidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstPartidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstPartidos_Jugadores_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EstPartidos_Jugadores_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsistEntrenamientos_EntrenamientoId",
                table: "AsistEntrenamientos",
                column: "EntrenamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_AsistEntrenamientos_JugadorId",
                table: "AsistEntrenamientos",
                column: "JugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_EstPartidos_JugadorId",
                table: "EstPartidos",
                column: "JugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_EstPartidos_PartidoId",
                table: "EstPartidos",
                column: "PartidoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsistEntrenamientos");

            migrationBuilder.DropTable(
                name: "Entrenamientos");

            migrationBuilder.DropTable(
                name: "EstPartidos");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Jugadores");
        }
    }
}
