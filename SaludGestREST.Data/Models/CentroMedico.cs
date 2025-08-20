using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Data.Models
{
    public class CentroMedico : Registry
    {
        public int CentroMedicoId { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string ImagenUrl { get; set; }
    }
}
