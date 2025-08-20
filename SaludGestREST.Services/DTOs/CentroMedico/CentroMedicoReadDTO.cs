using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.DTOs.CentroMedico
{
    public class CentroMedicoReadDTO : RegistryDTO
    {
        public int CentroMedicoId { get; set; }

        [Display(Name = "Nombre del Centro Médico")]
        public string Nombre { get; set; }

        [Display(Name = "Código del Centro Médico")]
        public string Codigo { get; set; }

        [Display(Name = "Dirección del Centro Médico")]
        public string Direccion { get; set; }

        [Display(Name = "Teléfono del Centro Médico")]
        public string Telefono { get; set; }

        [Display(Name = "Email del Centro Médico")]
        public string Email { get; set; }

        [Display(Name = "Imagen del Centro Médico")]
        public string ImagenUrl { get; set; }
    }
}
