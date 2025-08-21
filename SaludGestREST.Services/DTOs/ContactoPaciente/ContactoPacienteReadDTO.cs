using SaludGestREST.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SaludGestREST.Data.Commons.Enums;

namespace SaludGestREST.Services.DTOs.ContactoPaciente
{
    public class ContactoPacienteReadDTO : RegistryDTO
    {
        public int ContactoPacienteId { get; set; }
        [Display(Name = "Paciente")]
        public int PacienteId { get; set; }
        public string NombrePaciente { get; set; }
        [Display(Name = "Tipo de Contacto")]
        public TipoContactoPaciente TipoContacto { get; set; }
        [Display(Name = "Calle")]
        public string Calle { get; set; }
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }
        [Display(Name = "Estado")]
        public string Estado { get; set; }
        [Display(Name = "Código Postal")]
        public string CodigoPostal { get; set; }
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }
    }
}
