using System.ComponentModel.DataAnnotations;
using static SaludGestREST.Data.Commons.Enums;

namespace SaludGestREST.Services.DTOs.ContactoPaciente
{
    public class ContactoPacienteCreateDTO : RegistryDTO
    {
        [Required (ErrorMessage = "Debe seleccionar un paciente")]
        public int PacienteId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un tipo de contacto")]
        public TipoContactoPaciente TipoContacto { get; set; }

        [Required(ErrorMessage = "La calle es obligatoria")]
        public string Calle { get; set; }

        [Required(ErrorMessage = "La ciudad es obligatoria")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "El código postal es obligatorio")]
        public string CodigoPostal { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        public string Telefono { get; set; }
    }
}
