using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaludGestREST.Data.Models
{
    public class Cita : Registry
    {
        public int CitaId { get; set; }

        [Required]
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        [Required]
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }

        [Required]
        public int CentroMedicoId { get; set; }
        public CentroMedico CentroMedico { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal DuracionMinutos { get; set; }

        [Required]
        public string Motivo { get; set; }
    }
}
