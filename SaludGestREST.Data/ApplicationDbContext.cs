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
        }
    }
}
