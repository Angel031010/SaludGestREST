using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaludGestREST.Data.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "356a4c35-f2b5-448a-aa6a-c33b4f1a00b5", null, "Admin", "ADMIN" },
                    { "75d60431-14e6-4d36-b24c-8d5c91652d08", null, "Medico", "Medico" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3b13e67a-5705-4625-9837-349b883ac758", 0, "0773fa89-7b0a-46c5-9c5f-c70ff8ed4707", "medico@test.com", true, false, null, "MEDICO@TEST.COM", "MEDICO@TEST.COM", "AQAAAAIAAYagAAAAEHDq+nsm9xsFl1hPg7+xqxEXfdkJOHdojAIk/7GtzDIfvurPuZjwAewxx0BzfSMe5w==", null, false, "ac14fe5b-c3fd-4dd2-ae41-846ce3165aba", false, "medico@test.com" },
                    { "6196403b-dd03-4f13-aa06-e1038cff89f5", 0, "c3174e91-a976-47a4-917b-8a7abf5b9b1d", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEJT4X8TedUeNq2a8gcEhsceBDxH9pSyMkBcO3ljTctWUM+xjdxk5E5lJEKJOGyCz8Q==", null, false, "e45ae143-f4cb-44af-a225-6e2963c7b450", false, "admin@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(1989, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8305), new DateTime(2025, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2003, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8314), new DateTime(2025, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2001, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8317), new DateTime(2025, 8, 20, 14, 49, 26, 198, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "75d60431-14e6-4d36-b24c-8d5c91652d08", "3b13e67a-5705-4625-9837-349b883ac758" },
                    { "356a4c35-f2b5-448a-aa6a-c33b4f1a00b5", "6196403b-dd03-4f13-aa06-e1038cff89f5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75d60431-14e6-4d36-b24c-8d5c91652d08", "3b13e67a-5705-4625-9837-349b883ac758" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "356a4c35-f2b5-448a-aa6a-c33b4f1a00b5", "6196403b-dd03-4f13-aa06-e1038cff89f5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "356a4c35-f2b5-448a-aa6a-c33b4f1a00b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75d60431-14e6-4d36-b24c-8d5c91652d08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b13e67a-5705-4625-9837-349b883ac758");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6196403b-dd03-4f13-aa06-e1038cff89f5");

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
