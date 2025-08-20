using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.DTOs
{
    public class PacienteReadDTO : RegistryDTO
    {
        public int PacienteId { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Telefono { get; set; }
        public string UrlFoto { get; set; }
        public string Email { get; set; }
    }
}
