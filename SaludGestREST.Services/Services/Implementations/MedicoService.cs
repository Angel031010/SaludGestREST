using Microsoft.EntityFrameworkCore;
using SaludGestREST.Data;
using SaludGestREST.Data.Models;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs.CentroMedico;
using SaludGestREST.Services.DTOs.Medico;
using SaludGestREST.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SaludGestREST.Services.Services.Implementations
{
    public class MedicoService : IMedicoService
    {
        private readonly ApplicationDbContext _context;

        public MedicoService (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync (MedicoCreateDTO medicoCreateDTO)
        {
            var medico = new Medico
            {
                Nombre = medicoCreateDTO.Nombre,
                ApPaterno = medicoCreateDTO.ApPaterno,
                ApMaterno = medicoCreateDTO.ApMaterno,
                Matricula = medicoCreateDTO.Matricula,
                Telefono = medicoCreateDTO.Telefono,
                Email = medicoCreateDTO.Email,
                EspecialidadId = medicoCreateDTO.EspecialidadId,
                CentroMedicoId = medicoCreateDTO.CentroMedicoId
            };
            await _context.Medicos.AddAsync(medico);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var medico = await _context.Medicos.FindAsync(id);
            if (medico == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.CentroMedicoNotFoundWithId, id));
            medico.IsActive = false;
            _context.Medicos.Update(medico);
            await _context.SaveChangesAsync();
        }

        public async Task<List<MedicoReadDTO>> GetAllAsync()
        {
            var medicos = await _context.Medicos
                .Where(m => !m.IsDeleted) // Asumiendo que tienes un borrado lógico
                .Select(m => new MedicoReadDTO
                {
                    MedicoId = m.MedicoId,
                    Nombre = m.Nombre,
                    ApPaterno = m.ApPaterno,
                    ApMaterno = m.ApMaterno,
                    Matricula = m.Matricula,
                    Telefono = m.Telefono,
                    Email = m.Email
                })
                .ToListAsync();

            return medicos;
        }

        public async Task<MedicoReadDTO> GetByIdAsync(int id)
        {
            var medico = await _context.Medicos
                .Where(m => m.MedicoId == id && !m.IsDeleted) 
                .Select(m => new MedicoReadDTO
                {
                    // Mapeamos las propiedades del modelo Medico
                    MedicoId = m.MedicoId,
                    Nombre = m.Nombre,
                    ApPaterno = m.ApPaterno,
                    ApMaterno = m.ApMaterno,
                    Matricula = m.Matricula,
                    Telefono = m.Telefono,
                    Email = m.Email
                })
                .FirstOrDefaultAsync();

            if (medico == null)
            {
                // Lanzamos una excepción específica para Medico
                throw new KeyNotFoundException($"Médico no encontrado con el Id {id}.");
            }

            return medico;
        }
        public async Task UpdateAsync(int id, MedicoUpdateDTO medicoUpdateDTO)
        {

            var medico = await _context.Medicos.FindAsync(id);

            if (medico == null)
            {
                throw new KeyNotFoundException(string.Format(Messages.Error.CentroMedicoNotFoundWithId, id));
            }
            medico.Nombre = medicoUpdateDTO.Nombre;
            medico.ApPaterno = medicoUpdateDTO.ApPaterno;
            medico.ApMaterno = medicoUpdateDTO.ApMaterno;
            medico.Matricula = medicoUpdateDTO.Matricula;
            medico.Telefono = medicoUpdateDTO.Telefono;
            medico.Email = medicoUpdateDTO.Email;

            _context.Medicos.Update(medico);
            await _context.SaveChangesAsync();
        }
    }
}
