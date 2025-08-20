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
            modelBuilder.Entity<Especialidad>().HasData(
                new Especialidad
                {
                    IdEspecialidad = 1,
                    Nombre = "Medicina Interna",
                    Descripcion = "Cardiología: Corazón y sistema circulatorio. Endocrinología: Enfermedades hormonales y del metabolismo (ej. diabetes, tiroides). Gastroenterología: Sistema digestivo (estómago, intestinos, hígado). Neumología: Pulmones y sistema respiratorio. Nefrología: Riñones. Reumatología: Enfermedades del sistema musculoesquelético y autoinmunes (ej. artritis).",
                    IsActive = true,
                    HighSystem = DateTime.Now
                },
                new Especialidad
                {
                    IdEspecialidad = 2,
                    Nombre = "Pediatria",
                    Descripcion = "Cuidado de la salud de bebés, niños y adolescentes.",
                    IsActive = true,
                    HighSystem = DateTime.Now
                }, new Especialidad
                {
                    IdEspecialidad = 3,
                    Nombre = "Medicina Familiar y General",
                    Descripcion = "Ofrece atención médica integral y continua para personas de todas las edades. Son el primer punto de contacto del sistema de salud.",
                    IsActive = true,
                    HighSystem = DateTime.Now
                }, new Especialidad
                {
                    IdEspecialidad = 4,
                    Nombre = "Geriatría",
                    Descripcion = "Cuidado de la salud en personas de la tercera edad.",
                    IsActive = true,
                    HighSystem = DateTime.Now
                });
        }
    }
}
