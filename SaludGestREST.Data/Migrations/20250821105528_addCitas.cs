using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaludGestREST.Data.Migrations
{
    /// <inheritdoc />
    public partial class addCitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    CitaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    MedicoId = table.Column<int>(type: "int", nullable: false),
                    CentroMedicoId = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuracionMinutos = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HighSystem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.CitaId);
                    table.ForeignKey(
                        name: "FK_Citas_CentrosMedicos_CentroMedicoId",
                        column: x => x.CentroMedicoId,
                        principalTable: "CentrosMedicos",
                        principalColumn: "CentroMedicoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medicos",
                        principalColumn: "MedicoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0635dab3-9ef1-4ce6-856a-f409d51dcbb1", null, "Medico", "Medico" },
                    { "84ddcb1b-fdef-4fa8-9f3a-d78a8c81046b", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4a34456d-d07b-4a50-97e4-18ceb5c5854f", 0, "c19ccdd2-4db4-4cfa-bdf8-765e0815598c", "medico@test.com", true, false, null, "MEDICO@TEST.COM", "MEDICO@TEST.COM", "AQAAAAIAAYagAAAAEIMjT7kjGNZ84d2e/U1b+KrOZIMlTLNFQq3u6Y4T5PHve7xKNNIq62f+o70/TC5qDQ==", null, false, "1a00be60-a81a-4fd6-a0d2-b94bdedc0425", false, "medico@test.com" },
                    { "9b1247e0-097e-4e8a-bf06-e75eeb34774d", 0, "a47ffbe6-2420-4544-8b59-ea4d47641650", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEDnlnM6PqhTKlhZk0UqcY3L1vvjVWFScbs5W58F8k/1TQ5JUsSuo0mtMWKxIjBrphg==", null, false, "01678402-bf49-41bd-a5c9-f0d14e5838fc", false, "admin@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "CitaId", "CentroMedicoId", "DuracionMinutos", "FechaHora", "HighSystem", "IsActive", "IsDeleted", "MedicoId", "Motivo", "PacienteId" },
                values: new object[,]
                {
                    { 1, 1, 30.00m, new DateTime(2025, 8, 22, 14, 55, 26, 944, DateTimeKind.Local).AddTicks(9653), new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(9647), true, false, 1, "Consulta general", 1 },
                    { 2, 1, 45.50m, new DateTime(2025, 8, 23, 19, 55, 26, 944, DateTimeKind.Local).AddTicks(9663), new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(9662), true, false, 2, "Revisión de análisis clínicos", 2 },
                    { 3, 2, 60.00m, new DateTime(2025, 8, 24, 13, 55, 26, 944, DateTimeKind.Local).AddTicks(9666), new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(9665), true, false, 3, "Consulta especializada", 3 }
                });

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(1989, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4046), new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2003, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4057), new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2001, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4060), new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0635dab3-9ef1-4ce6-856a-f409d51dcbb1", "4a34456d-d07b-4a50-97e4-18ceb5c5854f" },
                    { "84ddcb1b-fdef-4fa8-9f3a-d78a8c81046b", "9b1247e0-097e-4e8a-bf06-e75eeb34774d" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_CentroMedicoId",
                table: "Citas",
                column: "CentroMedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_MedicoId",
                table: "Citas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_PacienteId",
                table: "Citas",
                column: "PacienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0635dab3-9ef1-4ce6-856a-f409d51dcbb1", "4a34456d-d07b-4a50-97e4-18ceb5c5854f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84ddcb1b-fdef-4fa8-9f3a-d78a8c81046b", "9b1247e0-097e-4e8a-bf06-e75eeb34774d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0635dab3-9ef1-4ce6-856a-f409d51dcbb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84ddcb1b-fdef-4fa8-9f3a-d78a8c81046b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a34456d-d07b-4a50-97e4-18ceb5c5854f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1247e0-097e-4e8a-bf06-e75eeb34774d");

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

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 4, 21, 47, 34, DateTimeKind.Local).AddTicks(14));

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
    }
}
