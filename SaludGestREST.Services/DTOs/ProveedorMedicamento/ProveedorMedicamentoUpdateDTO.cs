using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.DTOs.ProveedorMedicamento
{
    public class ProveedorMedicamentoUpdateDTO
    {
        public int? MedicamentoId { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Telefono")]

        public string Telefono { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "El valor es requerido")]
        public string Email { get; set; }
        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "El valor es requerido")]
        public string Direccion { get; set; }
    }
}
