using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.DTOs
{
    public class RegistryDTO
    {
        [Display(Name = "Estatus")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Alta")]
        public DateTime HighSystem { get; set; } = DateTime.Now;

    }
}
