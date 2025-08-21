using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.DTOs.Especialidad
{
    public class EspecialidadCreateDTO : RegistryDTO
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El valor es requerido")]
        public string Nombre { get; set; }
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "El valor es requerido")]
        public string Descripcion { get; set; }
    }
}
