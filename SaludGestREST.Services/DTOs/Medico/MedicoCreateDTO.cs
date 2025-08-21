using System.ComponentModel.DataAnnotations;

namespace SaludGestREST.Services.DTOs.Medico
{
    public class MedicoCreateDTO : RegistryDTO
    {

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        [Required(ErrorMessage = "El apellido paterno es requerido")]
        [StringLength(50)]
        public string ApPaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        [Required(ErrorMessage = "El apellido materno es requerido")]
        [StringLength(50)]
        public string ApMaterno { get; set; }

        [Display(Name = "Matrícula")]
        [Required(ErrorMessage = "La matrícula es requerida")]
        [StringLength(20)]
        public string Matricula { get; set; }

        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "El teléfono es requerido")]
        [Phone(ErrorMessage = "El formato del teléfono no es válido")]
        public string Telefono { get; set; }

        [Display(Name = "Correo Electrónico")]
        [Required(ErrorMessage = "El correo electrónico es requerido")]
        [EmailAddress(ErrorMessage = "El formato del correo no es válido")]
        public string Email { get; set; }

        [Required]
        public int EspecialidadId { get; set; }
        [Required]
        public int CentroMedicoId { get; set; }
    }
}
