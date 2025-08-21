using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaludGestREST.Data.Migrations
{
    /// <inheritdoc />
    public partial class ContactoPaciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ContactosPacientes",
                columns: table => new
                {
                    ContactoPacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    TipoContacto = table.Column<int>(type: "int", nullable: false),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HighSystem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactosPacientes", x => x.ContactoPacienteId);
                    table.ForeignKey(
                        name: "FK_ContactosPacientes_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4000a239-9b28-4753-8236-a8f053a7e425", null, "Medico", "Medico" },
                    { "5206fef4-1e84-48f2-8aca-b65bb2057de5", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f0cae46-c224-4309-b4b3-06104f3fca40", 0, "01181c55-301f-49ef-a0e5-2c830a6c4ae3", "medico@test.com", true, false, null, "MEDICO@TEST.COM", "MEDICO@TEST.COM", "AQAAAAIAAYagAAAAEJUeUhsOtrIkwxF/zknOjj5QbkqKwfJpT8OEAOSgQdhC9g9957hOxFDq2Q+wMfk8wA==", null, false, "86105cae-27fb-4541-b1f7-85ae583e5e8c", false, "medico@test.com" },
                    { "79bed73c-7246-4780-be24-6ffef8a4b6cb", 0, "d574dc4c-0258-46ec-a1a8-81adc6b63dbd", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEPvxW7IftYxgp09PSf9jgw1Zc7bG4wMoKNsJ6ZauOI8F6sE9x7/vSZ9AyH6heNIX1w==", null, false, "3ac0afe2-62e3-46bb-8dbc-c4acbdfd7a34", false, "admin@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.InsertData(
                table: "ContactosPacientes",
                columns: new[] { "ContactoPacienteId", "Calle", "Ciudad", "CodigoPostal", "Estado", "HighSystem", "IsActive", "IsDeleted", "PacienteId", "Telefono", "TipoContacto" },
                values: new object[,]
                {
                    { 1, "Av. Reforma 123", "CDMX", "06000", "CDMX", new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4677), true, false, 1, "557511785", 0 },
                    { 2, "Calle Juárez 456", "Puebla", "72000", "Puebla", new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4684), true, false, 2, "557486785", 1 },
                    { 3, "Calle Hidalgo 789", "Toluca", "50000", "Edo. México", new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4688), true, false, 3, "5632111785", 2 }
                });

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(1989, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4596), new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2003, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4611), new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2001, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4618), new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4000a239-9b28-4753-8236-a8f053a7e425", "0f0cae46-c224-4309-b4b3-06104f3fca40" },
                    { "5206fef4-1e84-48f2-8aca-b65bb2057de5", "79bed73c-7246-4780-be24-6ffef8a4b6cb" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactosPacientes_PacienteId",
                table: "ContactosPacientes",
                column: "PacienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactosPacientes");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4000a239-9b28-4753-8236-a8f053a7e425", "0f0cae46-c224-4309-b4b3-06104f3fca40" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5206fef4-1e84-48f2-8aca-b65bb2057de5", "79bed73c-7246-4780-be24-6ffef8a4b6cb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4000a239-9b28-4753-8236-a8f053a7e425");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5206fef4-1e84-48f2-8aca-b65bb2057de5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f0cae46-c224-4309-b4b3-06104f3fca40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79bed73c-7246-4780-be24-6ffef8a4b6cb");

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "75d60431-14e6-4d36-b24c-8d5c91652d08", "3b13e67a-5705-4625-9837-349b883ac758" },
                    { "356a4c35-f2b5-448a-aa6a-c33b4f1a00b5", "6196403b-dd03-4f13-aa06-e1038cff89f5" }
                });
        }
    }
}
