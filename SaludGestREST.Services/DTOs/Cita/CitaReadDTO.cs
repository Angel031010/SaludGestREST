using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.DTOs.Cita
{
    public class CitaReadDTO : RegistryDTO
    {
        public int CitaId { get; set; }

        public int PacienteId { get; set; }
        public string PacienteNombre { get; set; }

        public int MedicoId { get; set; }
        public string MedicoNombre { get; set; }

        public int CentroMedicoId { get; set; }
        public string CentroMedicoNombre { get; set; }

        public DateTime FechaHora { get; set; }
        public decimal DuracionMinutos { get; set; }
        public string Motivo { get; set; }
    }
}
