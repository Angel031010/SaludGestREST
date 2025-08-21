using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaludGestREST.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixMedico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApPaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApMaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EspecialidadId = table.Column<int>(type: "int", nullable: false),
                    CentroMedicoId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HighSystem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.MedicoId);
                    table.ForeignKey(
                        name: "FK_Medicos_CentrosMedicos_CentroMedicoId",
                        column: x => x.CentroMedicoId,
                        principalTable: "CentrosMedicos",
                        principalColumn: "CentroMedicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicos_Especialidades_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "Especialidades",
                        principalColumn: "IdEspecialidad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(1989, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(451), new DateTime(2025, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2003, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(459), new DateTime(2025, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2001, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(464), new DateTime(2025, 8, 20, 18, 24, 5, 886, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_CentroMedicoId",
                table: "Medicos",
                column: "CentroMedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_EspecialidadId",
                table: "Medicos",
                column: "EspecialidadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicos");

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

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(1989, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(700), new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2003, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(709), new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2001, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(712), new DateTime(2025, 8, 20, 11, 51, 54, 463, DateTimeKind.Local).AddTicks(711) });
        }
    }
}
