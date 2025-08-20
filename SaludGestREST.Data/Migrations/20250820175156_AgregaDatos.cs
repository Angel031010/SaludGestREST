using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaludGestREST.Data.Migrations
{
    /// <inheritdoc />
    public partial class AgregaDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    IdEspecialidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HighSystem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.IdEspecialidad);
                });

            migrationBuilder.CreateTable(
                name: "InventarioMedico",
                columns: table => new
                {
                    InventarioMedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Minimo = table.Column<int>(type: "int", nullable: false),
                    MedicamentoId = table.Column<int>(type: "int", nullable: false),
                    CentroId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HighSystem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarioMedico", x => x.InventarioMedId);
                    table.ForeignKey(
                        name: "FK_InventarioMedico_CentrosMedicos_CentroId",
                        column: x => x.CentroId,
                        principalTable: "CentrosMedicos",
                        principalColumn: "CentroMedicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventarioMedico_Medicamentos_MedicamentoId",
                        column: x => x.MedicamentoId,
                        principalTable: "Medicamentos",
                        principalColumn: "MedicamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.InsertData(
                table: "Medicamentos",
                columns: new[] { "MedicamentoId", "Codigo", "HighSystem", "IsActive", "IsDeleted", "Lote", "Nombre", "Sustancia" },
                values: new object[,]
                {
                    { 1, "234r324", new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(662), true, false, "1234457", "Rosel", "Paracetamol" },
                    { 2, "23324", new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(666), true, false, "12344", "Neomelubrina", "Parace" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteId", "ApMaterno", "ApPaterno", "Email", "FechaNacimiento", "HighSystem", "IsActive", "IsDeleted", "Nombre", "Telefono", "UrlFoto" },
                values: new object[,]
                {
                    { 1, "Velasco", "Hernandez", "ejemplo@test.com", new DateTime(1989, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(700), new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(695), true, false, "Sergio", 557511785m, "/default.jpg" },
                    { 2, "Sanchez", "Ildefonso", "ejemplo@test.com", new DateTime(2003, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(709), new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(707), true, false, "Angel", 557486785m, "/default.jpg" },
                    { 3, "Castillo", "Sapiens", "ejemplo@test.com", new DateTime(2001, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(712), new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(711), true, false, "Roberto", 5632111785m, "/default.jpg" }
                });

            migrationBuilder.InsertData(
                table: "InventarioMedico",
                columns: new[] { "InventarioMedId", "Cantidad", "CentroId", "HighSystem", "IsActive", "IsDeleted", "MedicamentoId", "Minimo" },
                values: new object[,]
                {
                    { 1, 10, 1, new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(741), true, false, 1, 5 },
                    { 2, 10, 2, new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(743), true, false, 2, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventarioMedico_CentroId",
                table: "InventarioMedico",
                column: "CentroId");

            migrationBuilder.CreateIndex(
                name: "IX_InventarioMedico_MedicamentoId",
                table: "InventarioMedico",
                column: "MedicamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "InventarioMedico");

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 1, 39, 8, 982, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 1, 39, 8, 982, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 1, 39, 8, 982, DateTimeKind.Local).AddTicks(9255));
        }
    }
}
