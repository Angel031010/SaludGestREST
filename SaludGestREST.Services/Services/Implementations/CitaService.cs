using Microsoft.EntityFrameworkCore;
using SaludGestREST.Data;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs.Cita;
using SaludGestREST.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Implementations
{
    public class CitaService : ICitaService
    {

        private readonly ApplicationDbContext _context;

        public CitaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(CitaCreateDTO dto)
        {
            var cita = new Data.Models.Cita
            {
                PacienteId = dto.PacienteId,
                MedicoId = dto.MedicoId,
                CentroMedicoId = dto.CentroMedicoId,
                FechaHora = dto.FechaHora,
                DuracionMinutos = dto.DuracionMinutos,
                Motivo = dto.Motivo,
            };

            await _context.AddAsync(cita);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var cita = await _context.Citas.FindAsync(id);
            if (cita == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.CitaNotFoundWithId, id));

            cita.IsDeleted = true;
            cita.IsActive = false;
            _context.Citas.Update(cita);
            await _context.SaveChangesAsync();
        }

        public async Task<List<CitaReadDTO>> GetAllAsync()
        {
            var citas = await _context.Citas
                .Where(c => !c.IsDeleted)
                .Select(c => new CitaReadDTO
                {
                    CitaId = c.CitaId,
                    PacienteId = c.PacienteId,
                    PacienteNombre = c.Paciente.Nombre,
                    MedicoId = c.MedicoId,
                    MedicoNombre = c.Medico.Nombre,
                    CentroMedicoId = c.CentroMedicoId,
                    CentroMedicoNombre = c.CentroMedico.Nombre,
                    FechaHora = c.FechaHora,
                    DuracionMinutos = c.DuracionMinutos,
                    Motivo = c.Motivo
                })
                .ToListAsync();
            return citas;
        }

        public async Task<CitaReadDTO> GetByIdAsync(int id)
        {
            var cita = await _context.Citas
                .Where(c => c.CitaId == id && !c.IsDeleted)
                .Select(c => new CitaReadDTO
                {
                    CitaId = c.CitaId,
                    PacienteId = c.PacienteId,
                    PacienteNombre = c.Paciente.Nombre,
                    MedicoId = c.MedicoId,
                    MedicoNombre = c.Medico.Nombre,
                    CentroMedicoId = c.CentroMedicoId,
                    CentroMedicoNombre = c.CentroMedico.Nombre,
                    FechaHora = c.FechaHora,
                    DuracionMinutos = c.DuracionMinutos,
                    Motivo = c.Motivo
                })
                .FirstOrDefaultAsync();
            if (cita == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.CitaNotFoundWithId, id));
            return cita;
        }

        public async Task UpdateAsync(int id, CitaUpdateDTO dto)
        {
            var cita = await _context.Citas.FindAsync(id);
            if (cita == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.CitaNotFoundWithId, id));
            cita.PacienteId = dto.PacienteId;
            cita.MedicoId = dto.MedicoId;
            cita.CentroMedicoId = dto.CentroMedicoId;
            cita.FechaHora = dto.FechaHora;
            cita.DuracionMinutos = dto.DuracionMinutos;
            cita.Motivo = dto.Motivo;

            _context.Citas.Update(cita);
            await _context.SaveChangesAsync();
        }
    }
}
