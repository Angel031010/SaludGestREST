using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SaludGestREST.Data.Commons.Enums;

namespace SaludGestREST.Data.Models
{
    public class ContactoPaciente : Registry
    {
        public int ContactoPacienteId { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public TipoContactoPaciente TipoContacto { get; set; }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }

    }
}
