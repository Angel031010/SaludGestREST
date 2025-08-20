using Humanizer;
using Microsoft.EntityFrameworkCore;
using SaludGestREST.Data;
using SaludGestREST.Data.Models;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs;
using SaludGestREST.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Implementations
{
    public class InventarioService : IInventarioService
    {
        private readonly ApplicationDbContext _context;
        public InventarioService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(InventarioDTO dto)
        {
            var inventario = new InventarioMedicamento
            {
                Cantidad = dto.Cantidad,
                CentroId = dto.CentroId,
                MedicamentoId = dto.MedicamentoId,
                Minimo = dto.Minimo
            };
            await _context.InventarioMedico.AddAsync(inventario);
            await _context.SaveChangesAsync();
            dto.MedicamentoId = inventario.MedicamentoId;
        }

        public async Task DeleteAsync(int id)
        {
            var inventario = await _context.InventarioMedico.FindAsync(id);
            if (inventario == null)
                throw new KeyNotFoundException(nameof(id));
            inventario.IsDeleted = true;
            inventario.IsActive = false;
            _context.InventarioMedico.Update(inventario);
            await _context.SaveChangesAsync();
        }

        public async Task<List<InventarioDTO>> GetAllAsync()
        {
            var inventario = await _context.InventarioMedico
                .Where(x => !x.IsDeleted)
                .Select(x => new InventarioDTO
                {
                    InventarioMedId = x.InventarioMedId,
                    Cantidad = x.Cantidad,
                    CentroId = x.CentroId,
                    MedicamentoId = x.MedicamentoId,
                    Minimo = x.Minimo,
                    HighSystem = x.HighSystem,
                    IsActive = x.IsActive
                })
                .ToListAsync();
            return inventario;
        }

        public async Task<InventarioDTO> GetByIdAsync(int id)
        {
            var inventario = await _context.InventarioMedico
                .Where(x => !x.IsDeleted && x.InventarioMedId == id)
                .Select(x => new InventarioDTO
                {
                    InventarioMedId = x.InventarioMedId,
                    Cantidad = x.Cantidad,
                    CentroId = x.Cantidad,
                    MedicamentoId = x.MedicamentoId,
                    Minimo = x.Minimo,
                    HighSystem = x.HighSystem,
                    IsActive = x.IsActive
                })
                .FirstOrDefaultAsync();
            return inventario;
        }

        public async Task UpdateAsync(int id, InventarioDTO dto)
        {
            if (id != dto.InventarioMedId)
                throw new ArgumentException("El id es incorrecto");
            var inventario = await _context.InventarioMedico.SingleAsync(x => x.InventarioMedId == id);
            if (inventario == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.MedicamentoNotFoundWithId, id));
            inventario.Cantidad = dto.Cantidad;
            inventario.CentroId = dto.CentroId;
            inventario.MedicamentoId = dto.MedicamentoId;
            inventario.Minimo = dto.Minimo;
            _context.InventarioMedico.Update(inventario);
            await _context.SaveChangesAsync();
        }
    }
}
