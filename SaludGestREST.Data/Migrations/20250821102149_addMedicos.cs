using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaludGestREST.Data.Migrations
{
    /// <inheritdoc />
    public partial class addMedicos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "45af6993-fd6b-4c7f-8639-8b45c42c6439", null, "Medico", "Medico" },
                    { "82312eca-6eb0-4020-80a3-9401218b88da", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "12e8f696-0505-4860-9945-e83258048a17", 0, "94a9c601-5d4f-4a68-b81d-c915f75cf955", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEBxu1yc7sY1oGDJ+GklL8lboqVJm+0+Vk3Zs80/bQNmJTxJM/uaNQA1TbyQxiFrzcg==", null, false, "22fc8948-2ca3-407d-8985-791900e20094", false, "admin@test.com" },
                    { "cc4b2d1d-586a-4662-a141-63eaf3269803", 0, "b40cd87e-a375-4d36-a662-d21240aaccbc", "medico@test.com", true, false, null, "MEDICO@TEST.COM", "MEDICO@TEST.COM", "AQAAAAIAAYagAAAAEO7DuYbak7GqQuxD7BfHEJyzR0LR50mnYT5joQRthNXpaTNnuUYB5SXWDlAqyqgLIA==", null, false, "8733623e-a384-4a13-944b-4fc8710d4074", false, "medico@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 33, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 33, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 33, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "MedicoId", "ApMaterno", "ApPaterno", "CentroMedicoId", "Email", "EspecialidadId", "HighSystem", "IsActive", "IsDeleted", "Matricula", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Ramírez", "González", 1, "laura.gonzalez@hospital.com", 1, new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(5), true, false, "MED001", "Laura", "5551002000" },
                    { 2, "López", "Martínez", 1, "carlos.martinez@hospital.com", 2, new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(10), true, false, "MED002", "Carlos", "5552003000" },
                    { 3, "Torres", "Hernández", 2, "ana.hernandez@hospital.com", 3, new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(14), true, false, "MED003", "Ana", "5553004000" }
                });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(1989, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(155), new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2003, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(169), new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2001, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(174), new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "82312eca-6eb0-4020-80a3-9401218b88da", "12e8f696-0505-4860-9945-e83258048a17" },
                    { "45af6993-fd6b-4c7f-8639-8b45c42c6439", "cc4b2d1d-586a-4662-a141-63eaf3269803" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "82312eca-6eb0-4020-80a3-9401218b88da", "12e8f696-0505-4860-9945-e83258048a17" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "45af6993-fd6b-4c7f-8639-8b45c42c6439", "cc4b2d1d-586a-4662-a141-63eaf3269803" });

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45af6993-fd6b-4c7f-8639-8b45c42c6439");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82312eca-6eb0-4020-80a3-9401218b88da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12e8f696-0505-4860-9945-e83258048a17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc4b2d1d-586a-4662-a141-63eaf3269803");

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

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 1, 8, 25, 410, DateTimeKind.Local).AddTicks(4688));

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
        }
    }
}
