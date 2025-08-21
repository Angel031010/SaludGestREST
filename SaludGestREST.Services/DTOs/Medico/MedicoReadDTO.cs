using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.DTOs.Medico
{
    public class MedicoReadDTO : RegistryDTO
    {
        public int MedicoId {  get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string ApPaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        public string ApMaterno { get; set; }

        [Display(Name = "Matrícula")]
        public string Matricula { get; set; }

        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }
    }
}
