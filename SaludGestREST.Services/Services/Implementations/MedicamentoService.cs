using SaludGestREST.Services.DTOs;
using SaludGestREST.Services.Services.Interfaces;
using SaludGestREST.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaludGestREST.Data.Models;
using SaludGestREST.Services.Constants;

namespace SaludGestREST.Services.Services.Implementations
{
    public class MedicamentoService : IMedicamentoService
    {
        private readonly ApplicationDbContext _context;
        public MedicamentoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(MedicamentoDTO dto)
        {
            var medicamento = new Medicamento
            {
                Nombre = dto.Nombre,
                Sustancia = dto.Sustancia,
                Lote = dto.Lote,
                Codigo = dto.Codigo
            };
            await _context.AddAsync(medicamento);
            await _context.SaveChangesAsync();
            dto.MedicamentoId = medicamento.MedicamentoId;
        }

        public async Task DeleteAsync(int id)
        {
            var medicamento = await _context.Medicamentos.FindAsync(id);
            if (medicamento == null)
                throw new KeyNotFoundException(nameof(id));
            medicamento.IsDeleted = true;
            medicamento.IsActive = false;
            _context.Medicamentos.Update(medicamento);
            await _context.SaveChangesAsync();
        }

        public async Task<List<MedicamentoDTO>> GetAllAsync()
        {
            var medicamneto = await _context.Medicamentos
                .Where(x => !x.IsDeleted)
                .Select(x => new MedicamentoDTO
                {
                    MedicamentoId = x.MedicamentoId,
                    Nombre = x.Nombre,
                    Sustancia = x.Sustancia,
                    Lote = x.Lote,
                    Codigo = x.Codigo
                })
                .ToListAsync();
            return medicamneto;
        }

        public async Task<MedicamentoDTO> GetByIdAsync(int id)
        {
            var medicamneto = await _context.Medicamentos
                .Where(x => !x.IsDeleted && x.MedicamentoId == id)
                .Select(x => new MedicamentoDTO
                {
                    MedicamentoId = x.MedicamentoId,
                    Nombre = x.Nombre,
                    Sustancia = x.Sustancia,
                    Lote = x.Lote,
                    Codigo = x.Codigo
                })
                .FirstOrDefaultAsync();
            return medicamneto;
        }

        public Task<MedicamentoDTO> GetDetailsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(int id, MedicamentoDTO dto)
        {
            if (id != dto.MedicamentoId)
                throw new ArgumentException("El id es incorrecto");
            var medicamento = await _context.Medicamentos.SingleAsync(x => x.MedicamentoId == id);
            if (medicamento == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.MedicamentoNotFoundWithId, id));
            medicamento.Nombre = dto.Nombre;
            medicamento.Sustancia = dto.Sustancia;
            medicamento.Lote = dto.Lote;
            medicamento.Codigo = dto.Codigo;
            _context.Medicamentos.Update(medicamento);
            await _context.SaveChangesAsync();
        }
    }
}
