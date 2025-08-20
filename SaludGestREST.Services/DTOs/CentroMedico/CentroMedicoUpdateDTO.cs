using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.DTOs.CentroMedico
{
    public class CentroMedicoUpdateDTO: RegistryDTO
    {

        //public int CentroMedicoId { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Display(Name = "Dirección del Centro Médico")]
        [Required(ErrorMessage = "La dirección es requerido")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El telefono es requerido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El correo electronico es requerido")]
        public string Email { get; set; }

        [Display(Name = "Imagen del Centro Médico")]
        public IFormFile File { get; set; }
    }
}
