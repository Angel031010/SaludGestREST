using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaludGestREST.Data.Migrations
{
    /// <inheritdoc />
    public partial class KEys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "IdEspecialidad",
                table: "Especialidades",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "ProveedorMedicamentos",
                columns: table => new
                {
                    ProveedorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HighSystem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProveedorMedicamentos", x => x.ProveedorId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a1ea680f-d237-4bb4-b064-87571e2ffb2e", null, "Medico", "Medico" },
                    { "cca85c6b-fe81-49ed-899a-b380e12adeba", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "68bda713-835b-4bf5-a137-275ffb1f88d8", 0, "41cd5faa-f4bc-484b-8997-8e3ed459bac2", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEGe73DD52aHn3caqjm0YtgygQhfOUJ9+JiT8411h6Gc0taY0wcQTIkdlTDHrtpFQ3Q==", null, false, "f059a92f-4087-4ce7-be30-923d43fe449b", false, "admin@test.com" },
                    { "923f9ea3-c9ea-47a2-9800-8e5137991435", 0, "3de7165f-2ef0-4d84-934d-699827a617a8", "medico@test.com", true, false, null, "MEDICO@TEST.COM", "MEDICO@TEST.COM", "AQAAAAIAAYagAAAAEDIB7PYjgI9n9nrsNOrJbo3q3H19+MqUKVwfW/fOC1i07Q98qsCSrdbHCfhak+3JYA==", null, false, "dbce633d-f374-4696-827c-df1b35ddc93f", false, "medico@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                columns: new[] { "FechaHora", "HighSystem" },
                values: new object[] { new DateTime(2025, 8, 22, 18, 45, 16, 854, DateTimeKind.Local).AddTicks(6523), new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                columns: new[] { "FechaHora", "HighSystem" },
                values: new object[] { new DateTime(2025, 8, 23, 23, 45, 16, 854, DateTimeKind.Local).AddTicks(6535), new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                columns: new[] { "FechaHora", "HighSystem" },
                values: new object[] { new DateTime(2025, 8, 24, 17, 45, 16, 854, DateTimeKind.Local).AddTicks(6538), new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(1989, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(789), new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2003, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(798), new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2001, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(802), new DateTime(2025, 8, 21, 8, 45, 16, 854, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cca85c6b-fe81-49ed-899a-b380e12adeba", "68bda713-835b-4bf5-a137-275ffb1f88d8" },
                    { "a1ea680f-d237-4bb4-b064-87571e2ffb2e", "923f9ea3-c9ea-47a2-9800-8e5137991435" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProveedorMedicamentos");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cca85c6b-fe81-49ed-899a-b380e12adeba", "68bda713-835b-4bf5-a137-275ffb1f88d8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a1ea680f-d237-4bb4-b064-87571e2ffb2e", "923f9ea3-c9ea-47a2-9800-8e5137991435" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1ea680f-d237-4bb4-b064-87571e2ffb2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cca85c6b-fe81-49ed-899a-b380e12adeba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68bda713-835b-4bf5-a137-275ffb1f88d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "923f9ea3-c9ea-47a2-9800-8e5137991435");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Especialidades",
                newName: "IdEspecialidad");

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

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                columns: new[] { "FechaHora", "HighSystem" },
                values: new object[] { new DateTime(2025, 8, 22, 14, 55, 26, 944, DateTimeKind.Local).AddTicks(9653), new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                columns: new[] { "FechaHora", "HighSystem" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 55, 26, 944, DateTimeKind.Local).AddTicks(9663), new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                columns: new[] { "FechaHora", "HighSystem" },
                values: new object[] { new DateTime(2025, 8, 24, 13, 55, 26, 944, DateTimeKind.Local).AddTicks(9666), new DateTime(2025, 8, 21, 4, 55, 26, 944, DateTimeKind.Local).AddTicks(9665) });

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
        }
    }
}
