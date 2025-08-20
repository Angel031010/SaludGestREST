using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.DTOs.CentroMedico
{
    public class CentroMedicoCreateDTO : RegistryDTO
    {

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El código es requerido")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "La dirección es requerido")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El telefono es requerido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El correo electronico es requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La imagen es requerida")]
        public IFormFile File { get; set; }
    }
}
