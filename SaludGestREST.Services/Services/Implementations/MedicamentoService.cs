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
using Microsoft.Extensions.Logging;

namespace SaludGestREST.Services.Services.Implementations
{
    public class MedicamentoService : IMedicamentoService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<MedicamentoService> _logger;
        public MedicamentoService(ApplicationDbContext context, ILogger<MedicamentoService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task AddAsync(MedicamentoDTO dto)
        {
            _logger.LogInformation("---Se inicia carga de medicamento---");
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
            _logger.LogInformation("---Se finaliza carga de medicamento---");
        }

        public async Task DeleteAsync(int id)
        {
            _logger.LogInformation("---Se inicia delete de medicamento---");
            var medicamento = await _context.Medicamentos.FindAsync(id);
            if (medicamento == null)
                throw new KeyNotFoundException(nameof(id));
            medicamento.IsDeleted = true;
            medicamento.IsActive = false;
            _context.Medicamentos.Update(medicamento);
            await _context.SaveChangesAsync();
            _logger.LogInformation("---Se finaliza carga de medicamento---");
        }

        public async Task<List<MedicamentoDTO>> GetAllAsync()
        {
            _logger.LogInformation("---Se inicia getall de medicamento---");
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
            _logger.LogInformation("---Se finaliza getall de medicamento---");
            return medicamneto;
        }

        public async Task<MedicamentoDTO> GetByIdAsync(int id)
        {
            _logger.LogInformation("---Se inicia getbyid de medicamento---");
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
            _logger.LogInformation("---Se finaliza getbyid de medicamento---");
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
