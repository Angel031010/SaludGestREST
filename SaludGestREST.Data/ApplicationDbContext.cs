using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaludGestREST.Data.Models;

namespace SaludGestREST.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CentroMedico> CentrosMedicos { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<ContactoPaciente> ContactosPacientes { get; set; }
        public DbSet<InventarioMedicamento> InventarioMedico { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CentroMedico>().HasData(
                new CentroMedico
                {
                    CentroMedicoId = 1,
                    Nombre = "Centro Médico Puebla",
                    Codigo = "CMP001",
                    Direccion = "Av. Reforma 123, Puebla, PUE",
                    Telefono = "222-123-4567",
                    Email = "contacto@cmpuebla.com",
                    ImagenUrl = "/Uploads/centroMedico.jpg",
                    IsActive = true,
                    IsDeleted = false,
                    HighSystem = DateTime.Now
                },
                new CentroMedico
                {
                    CentroMedicoId = 2,
                    Nombre = "Clínica Metropolitana",
                    Codigo = "CM002",
                    Direccion = "Calle Juárez 456, CDMX",
                    Telefono = "55-9876-5432",
                    Email = "info@clinicametropolitana.com",
                    ImagenUrl = "/Uploads/hospitalAngelopolitano.jpg",
                    IsActive = true,
                    IsDeleted = false,
                    HighSystem = DateTime.Now
                },
                new CentroMedico
                {
                    CentroMedicoId = 3,
                    Nombre = "Hospital del Valle",
                    Codigo = "HV003",
                    Direccion = "Av. Universidad 789, Guadalajara, JAL",
                    Telefono = "33-4567-8910",
                    Email = "hospital@delvalle.com",
                    ImagenUrl = "/Uploads/Valle.jpg",
                    IsActive = true,
                    IsDeleted = false,
                    HighSystem = DateTime.Now
                }
            );
            modelBuilder.Entity<Medicamento>().HasData(
                new Medicamento
                {
                    MedicamentoId = 1,
                    Nombre = "Rosel",
                    Lote = "1234457",
                    Codigo = "234r324",
                    Sustancia = "Paracetamol"
                },
                new Medicamento
                {
                    MedicamentoId = 2,
                    Nombre = "Neomelubrina",
                    Lote = "12344",
                    Codigo = "23324",
                    Sustancia = "Parace"
                }
                );
            modelBuilder.Entity<Paciente>().HasData(
                new Paciente
                {
                    PacienteId = 1,
                    Nombre = "Sergio",
                    ApPaterno = "Hernandez",
                    ApMaterno = "Velasco",
                    Telefono = 557511785,
                    UrlFoto = "/default.jpg",
                    Email = "ejemplo@test.com",
                    FechaNacimiento = DateTime.Now.AddYears(-36)
                },
                new Paciente
                {
                    PacienteId = 2,
                    Nombre = "Angel",
                    ApPaterno = "Ildefonso",
                    ApMaterno = "Sanchez",
                    Telefono = 557486785,
                    UrlFoto = "/default.jpg",
                    Email = "ejemplo@test.com",
                    FechaNacimiento = DateTime.Now.AddYears(-22)
                },
                new Paciente
                {
                    PacienteId = 3,
                    Nombre = "Roberto",
                    ApPaterno = "Sapiens",
                    ApMaterno = "Castillo",
                    Telefono = 5632111785,
                    UrlFoto = "/default.jpg",
                    Email = "ejemplo@test.com",
                    FechaNacimiento = DateTime.Now.AddYears(-24)
                }
                );
            modelBuilder.Entity<InventarioMedicamento>().HasData(
                new InventarioMedicamento
                {
                    InventarioMedId = 1,
                    CentroId = 1,
                    MedicamentoId = 1,
                    Cantidad = 10,
                    Minimo = 5
                },
                new InventarioMedicamento
                {
                    InventarioMedId = 2,
                    CentroId = 2,
                    MedicamentoId = 2,
                    Cantidad = 10,
                    Minimo = 5
                }
                );
        }
    }
}
