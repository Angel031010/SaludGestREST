using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Data.Models
{
    public class Medico : Registry
    {
        public int MedicoId {  get; set; }

        public string Nombre { get; set; }

        public string ApPaterno { get; set; }

        public string ApMaterno { get; set; }

        public string Matricula { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public int EspecialidadId { get; set; }

        public int CentroMedicoId { get; set; }

        public Especialidad Especialidad { get; set; }

        public CentroMedico CentroMedico { get; set; }
    }
}
