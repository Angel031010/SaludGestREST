using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaludGestREST.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CentrosMedicos",
                columns: table => new
                {
                    CentroMedicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagenUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HighSystem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentrosMedicos", x => x.CentroMedicoId);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    EspecialidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HighSystem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.EspecialidadId);
                });

            migrationBuilder.CreateTable(
                name: "Medicamentos",
                columns: table => new
                {
                    MedicamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sustancia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HighSystem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamentos", x => x.MedicamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApPaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApMaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UrlFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HighSystem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteId);
                });

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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        principalColumn: "EspecialidadId",
                        onDelete: ReferentialAction.Cascade);
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
                    { "2d415af0-7e1e-4610-99bc-bc3ecf609a93", null, "Admin", "ADMIN" },
                    { "39fa7488-27b6-48a3-99b3-f775304ac78a", null, "Medico", "Medico" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "912868c9-2aee-4eb4-94db-8ad57ab53bb2", 0, "5bb4daec-7047-4aa6-b3a6-4573ae3a9665", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAENp0YttXEAQR8ILhh1DNH4hjPhhRuZqHRPxrB2BP45Riba9EIMqhtNi0d30N4XrwHg==", null, false, "efd12b25-260d-4232-82df-0f5c3a5aea80", false, "admin@test.com" },
                    { "bb3618ef-5e5c-4e69-943c-befd56351dd9", 0, "89cdf372-e574-40e4-9b83-7781aa6c047e", "medico@test.com", true, false, null, "MEDICO@TEST.COM", "MEDICO@TEST.COM", "AQAAAAIAAYagAAAAEI+A1xDc9D9af74ktUfQZgxjN2LHKRLPJNXrvitaEq+pz4taJ1etiCUGcLdm8IHaIw==", null, false, "508b222b-1c8e-4a8f-bc53-6489086aedcd", false, "medico@test.com" }
                });

            migrationBuilder.InsertData(
                table: "CentrosMedicos",
                columns: new[] { "CentroMedicoId", "Codigo", "Direccion", "Email", "HighSystem", "ImagenUrl", "IsActive", "IsDeleted", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "CMP001", "Av. Reforma 123, Puebla, PUE", "contacto@cmpuebla.com", new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(1828), "/Uploads/centroMedico.jpg", true, false, "Centro Médico Puebla", "222-123-4567" },
                    { 2, "CM002", "Calle Juárez 456, CDMX", "info@clinicametropolitana.com", new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(1832), "/Uploads/hospitalAngelopolitano.jpg", true, false, "Clínica Metropolitana", "55-9876-5432" },
                    { 3, "HV003", "Av. Universidad 789, Guadalajara, JAL", "hospital@delvalle.com", new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(1836), "/Uploads/Valle.jpg", true, false, "Hospital del Valle", "33-4567-8910" }
                });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "EspecialidadId", "Descripcion", "HighSystem", "IsActive", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, "Cardiología: Corazón y sistema circulatorio. Endocrinología: Enfermedades hormonales y del metabolismo (ej. diabetes, tiroides). Gastroenterología: Sistema digestivo (estómago, intestinos, hígado). Neumología: Pulmones y sistema respiratorio. Nefrología: Riñones. Reumatología: Enfermedades del sistema musculoesquelético y autoinmunes (ej. artritis).", new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2574), true, false, "Medicina Interna" },
                    { 2, "Cuidado de la salud de bebés, niños y adolescentes.", new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2577), true, false, "Pediatria" },
                    { 3, "Ofrece atención médica integral y continua para personas de todas las edades. Son el primer punto de contacto del sistema de salud.", new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2580), true, false, "Medicina Familiar y General" },
                    { 4, "Cuidado de la salud en personas de la tercera edad.", new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2582), true, false, "Geriatría" }
                });

            migrationBuilder.InsertData(
                table: "Medicamentos",
                columns: new[] { "MedicamentoId", "Codigo", "HighSystem", "IsActive", "IsDeleted", "Lote", "Nombre", "Sustancia" },
                values: new object[,]
                {
                    { 1, "234r324", new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2363), true, false, "1234457", "Rosel", "Paracetamol" },
                    { 2, "23324", new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2367), true, false, "12344", "Neomelubrina", "Parace" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteId", "ApMaterno", "ApPaterno", "Email", "FechaNacimiento", "HighSystem", "IsActive", "IsDeleted", "Nombre", "Telefono", "UrlFoto" },
                values: new object[,]
                {
                    { 1, "Velasco", "Hernandez", "ejemplo@test.com", new DateTime(1989, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2413), new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2408), true, false, "Sergio", 557511785m, "/default.jpg" },
                    { 2, "Sanchez", "Ildefonso", "ejemplo@test.com", new DateTime(2003, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2425), new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2423), true, false, "Angel", 557486785m, "/default.jpg" },
                    { 3, "Castillo", "Sapiens", "ejemplo@test.com", new DateTime(2001, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2429), new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2426), true, false, "Roberto", 5632111785m, "/default.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2d415af0-7e1e-4610-99bc-bc3ecf609a93", "912868c9-2aee-4eb4-94db-8ad57ab53bb2" },
                    { "39fa7488-27b6-48a3-99b3-f775304ac78a", "bb3618ef-5e5c-4e69-943c-befd56351dd9" }
                });

            migrationBuilder.InsertData(
                table: "ContactosPacientes",
                columns: new[] { "ContactoPacienteId", "Calle", "Ciudad", "CodigoPostal", "Estado", "HighSystem", "IsActive", "IsDeleted", "PacienteId", "Telefono", "TipoContacto" },
                values: new object[,]
                {
                    { 1, "Av. Reforma 123", "CDMX", "06000", "CDMX", new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2477), true, false, 1, "557511785", 0 },
                    { 2, "Calle Juárez 456", "Puebla", "72000", "Puebla", new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2484), true, false, 2, "557486785", 1 },
                    { 3, "Calle Hidalgo 789", "Toluca", "50000", "Edo. México", new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2487), true, false, 3, "5632111785", 2 }
                });

            migrationBuilder.InsertData(
                table: "InventarioMedico",
                columns: new[] { "InventarioMedId", "Cantidad", "CentroId", "HighSystem", "IsActive", "IsDeleted", "MedicamentoId", "Minimo" },
                values: new object[,]
                {
                    { 1, 10, 1, new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2531), true, false, 1, 5 },
                    { 2, 10, 2, new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2534), true, false, 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "MedicoId", "ApMaterno", "ApPaterno", "CentroMedicoId", "Email", "EspecialidadId", "HighSystem", "IsActive", "IsDeleted", "Matricula", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Ramírez", "González", 1, "laura.gonzalez@hospital.com", 1, new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2311), true, false, "MED001", "Laura", "5551002000" },
                    { 2, "López", "Martínez", 1, "carlos.martinez@hospital.com", 2, new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2318), true, false, "MED002", "Carlos", "5552003000" },
                    { 3, "Torres", "Hernández", 2, "ana.hernandez@hospital.com", 3, new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(2322), true, false, "MED003", "Ana", "5553004000" }
                });

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "CitaId", "CentroMedicoId", "DuracionMinutos", "FechaHora", "HighSystem", "IsActive", "IsDeleted", "MedicoId", "Motivo", "PacienteId" },
                values: new object[,]
                {
                    { 1, 1, 30.00m, new DateTime(2025, 8, 22, 19, 24, 56, 836, DateTimeKind.Local).AddTicks(9837), new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(9832), true, false, 1, "Consulta general", 1 },
                    { 2, 1, 45.50m, new DateTime(2025, 8, 24, 0, 24, 56, 836, DateTimeKind.Local).AddTicks(9848), new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(9847), true, false, 2, "Revisión de análisis clínicos", 2 },
                    { 3, 2, 60.00m, new DateTime(2025, 8, 24, 18, 24, 56, 836, DateTimeKind.Local).AddTicks(9852), new DateTime(2025, 8, 21, 9, 24, 56, 836, DateTimeKind.Local).AddTicks(9850), true, false, 3, "Consulta especializada", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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

            migrationBuilder.CreateIndex(
                name: "IX_ContactosPacientes_PacienteId",
                table: "ContactosPacientes",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_InventarioMedico_CentroId",
                table: "InventarioMedico",
                column: "CentroId");

            migrationBuilder.CreateIndex(
                name: "IX_InventarioMedico_MedicamentoId",
                table: "InventarioMedico",
                column: "MedicamentoId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "ContactosPacientes");

            migrationBuilder.DropTable(
                name: "InventarioMedico");

            migrationBuilder.DropTable(
                name: "ProveedorMedicamentos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Medicamentos");

            migrationBuilder.DropTable(
                name: "CentrosMedicos");

            migrationBuilder.DropTable(
                name: "Especialidades");
        }
    }
}
