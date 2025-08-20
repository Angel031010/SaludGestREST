using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.DTOs
{
    public class MedicamentoDTO
    {
        public int? MedicamentoId { get; set; }
        public string Nombre { get; set; }
        public string Sustancia { get; set; }
        public string Lote { get; set; }
        public string Codigo { get; set; }
    }
}
