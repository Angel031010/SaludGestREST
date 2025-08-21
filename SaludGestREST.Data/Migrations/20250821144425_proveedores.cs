using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaludGestREST.Data.Migrations
{
    /// <inheritdoc />
    public partial class proveedores : Migration
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
                    { "32d85af7-2267-4dd8-ad85-c08e871905ea", null, "Admin", "ADMIN" },
                    { "cb52b53a-b19d-4092-b177-14ee6369ccdb", null, "Medico", "Medico" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "13acd341-7c45-4b9a-949b-6a3e0775a66e", 0, "b866ecf5-10c3-432f-aee1-5aad63fd5432", "medico@test.com", true, false, null, "MEDICO@TEST.COM", "MEDICO@TEST.COM", "AQAAAAIAAYagAAAAECKGJs5aPG8iwJqsRoml3E7Orj53firhqXrwhUZ3rlwQbifMtmuAO9ia1R2khPwzIg==", null, false, "394ec471-7225-442b-b6f2-8abf35182f88", false, "medico@test.com" },
                    { "fa4b15a9-88d0-4629-a154-d69eb7928896", 0, "b1a589bc-e451-4923-957f-bcc437a48312", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEHKIT6hnH2jN16K294gM7cRUkHdNlEWsjKNWgO57xcEvs05+Zgstlppaw3pOwwxslg==", null, false, "ff083084-27af-453d-8f46-672e693080c4", false, "admin@test.com" }
                });

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "CentrosMedicos",
                keyColumn: "CentroMedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                columns: new[] { "FechaHora", "HighSystem" },
                values: new object[] { new DateTime(2025, 8, 22, 18, 44, 23, 316, DateTimeKind.Local).AddTicks(29), new DateTime(2025, 8, 21, 8, 44, 23, 316, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                columns: new[] { "FechaHora", "HighSystem" },
                values: new object[] { new DateTime(2025, 8, 23, 23, 44, 23, 316, DateTimeKind.Local).AddTicks(40), new DateTime(2025, 8, 21, 8, 44, 23, 316, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                columns: new[] { "FechaHora", "HighSystem" },
                values: new object[] { new DateTime(2025, 8, 24, 17, 44, 23, 316, DateTimeKind.Local).AddTicks(43), new DateTime(2025, 8, 21, 8, 44, 23, 316, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "ContactosPacientes",
                keyColumn: "ContactoPacienteId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "InventarioMedico",
                keyColumn: "InventarioMedId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 1,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 2,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 3,
                column: "HighSystem",
                value: new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(1989, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3505), new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2003, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3519), new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                columns: new[] { "FechaNacimiento", "HighSystem" },
                values: new object[] { new DateTime(2001, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3523), new DateTime(2025, 8, 21, 8, 44, 23, 315, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cb52b53a-b19d-4092-b177-14ee6369ccdb", "13acd341-7c45-4b9a-949b-6a3e0775a66e" },
                    { "32d85af7-2267-4dd8-ad85-c08e871905ea", "fa4b15a9-88d0-4629-a154-d69eb7928896" }
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
                keyValues: new object[] { "cb52b53a-b19d-4092-b177-14ee6369ccdb", "13acd341-7c45-4b9a-949b-6a3e0775a66e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32d85af7-2267-4dd8-ad85-c08e871905ea", "fa4b15a9-88d0-4629-a154-d69eb7928896" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32d85af7-2267-4dd8-ad85-c08e871905ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb52b53a-b19d-4092-b177-14ee6369ccdb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13acd341-7c45-4b9a-949b-6a3e0775a66e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa4b15a9-88d0-4629-a154-d69eb7928896");

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
