using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SaludGestREST.Data.Models
{
    public class Medicamento : Registry
    {
        public int MedicamentoId { get; set; }
        public string Nombre { get; set; }
        public string Sustancia { get; set; }
        public string Lote { get; set; }
        public string Codigo { get; set; }
    }
}
