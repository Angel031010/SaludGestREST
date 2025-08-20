using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaludGestREST.Data.Migrations
{
    /// <inheritdoc />
    public partial class Especiaidades : Migration
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

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 11, 27, 54, 655, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 11, 27, 54, 655, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 11, 27, 54, 655, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "IdEspecialidad", "Descripcion", "HighSystem", "IsActive", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, "Cardiología: Corazón y sistema circulatorio. Endocrinología: Enfermedades hormonales y del metabolismo (ej. diabetes, tiroides). Gastroenterología: Sistema digestivo (estómago, intestinos, hígado). Neumología: Pulmones y sistema respiratorio. Nefrología: Riñones. Reumatología: Enfermedades del sistema musculoesquelético y autoinmunes (ej. artritis).", new DateTime(2025, 8, 20, 11, 27, 54, 655, DateTimeKind.Local).AddTicks(5747), true, false, "Medicina Interna" },
                    { 2, "Cuidado de la salud de bebés, niños y adolescentes.", new DateTime(2025, 8, 20, 11, 27, 54, 655, DateTimeKind.Local).AddTicks(5748), true, false, "Pediatria" },
                    { 3, "Ofrece atención médica integral y continua para personas de todas las edades. Son el primer punto de contacto del sistema de salud.", new DateTime(2025, 8, 20, 11, 27, 54, 655, DateTimeKind.Local).AddTicks(5750), true, false, "Medicina Familiar y General" },
                    { 4, "Cuidado de la salud en personas de la tercera edad.", new DateTime(2025, 8, 20, 11, 27, 54, 655, DateTimeKind.Local).AddTicks(5751), true, false, "Geriatría" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Especialidades");

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
