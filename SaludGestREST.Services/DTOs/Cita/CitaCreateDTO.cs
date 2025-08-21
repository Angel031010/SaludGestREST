using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.DTOs.Cita
{
    public class CitaCreateDTO : RegistryDTO
    {
        [Required(ErrorMessage = "Debe seleccionar un paciente")]
        public int PacienteId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un médico")]
        public int MedicoId { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un centro médico")]
        public int CentroMedicoId { get; set; }

        [Required(ErrorMessage = "La fecha y hora es obligatoria")]
        public DateTime FechaHora { get; set; }

        [Required(ErrorMessage = "La duración en minutos es obligatoria")]
        [Range(1, 1440, ErrorMessage = "La duración debe estar entre 1 y 1440 minutos")]
        public decimal DuracionMinutos { get; set; }

        [Required(ErrorMessage = "El motivo es obligatorio")]
        public string Motivo { get; set; }
    }
}
