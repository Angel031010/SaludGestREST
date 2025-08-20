using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SaludGestREST.Data.Models
{
    public class Paciente : Registry
    {
        public int PacienteId { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [Range(10,10)]
        public decimal Telefono { get; set; }
        public string UrlFoto { get; set; }
        public string Email { get; set; }
    }
}
