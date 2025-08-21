using Microsoft.EntityFrameworkCore;
using SaludGestREST.Data;
using SaludGestREST.Data.Models;
using SaludGestREST.Services.DTOs;
using SaludGestREST.Services.DTOs.ProveedorMedicamento;
using SaludGestREST.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Implementations
{
    public class ProveedorMedicamentoService : IProveedorMedicamentoService
    {
        private readonly ApplicationDbContext _context;

        public ProveedorMedicamentoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(ProveedorMedicamentoCreateDTO dto)
        {
            var proveedormedicamento = new ProveedorMedicamento
            {
                Nombre = dto.Nombre,
                Telefono = dto.Telefono,
                Email = dto.Email,
                Direccion = dto.Direccion,

            };
            await _context.AddAsync(proveedormedicamento);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var proveedormedicamento = await _context.ProveedorMedicamentos.FindAsync(id);
            if (proveedormedicamento == null)
            {
                throw new KeyNotFoundException(nameof(id));
                proveedormedicamento.IsActive = false;
                
                _context.ProveedorMedicamentos.Update(proveedormedicamento);
                await _context.SaveChangesAsync();
            }

        }


        public async Task<List<ProveedorMedicamentoReadDTO>> GetAllAsync()
        {
            var provedormedicamento = await _context.ProveedorMedicamentos
                .Where(x => !x.IsDeleted)
                .Select(x => new ProveedorMedicamentoReadDTO
                {
                    MedicamentoId = x.ProveedorId,
                    Nombre = x.Nombre,
                    Telefono = x.Telefono,
                    Email = x.Email,
                    Direccion = x.Direccion
                })
                .ToListAsync();
            return provedormedicamento;
        }

        public async Task<ProveedorMedicamentoReadDTO> GetByIdAsync(int id)
        {
            var proveedormedicamento = await _context.ProveedorMedicamentos
                .Where(x => !x.IsDeleted && x.ProveedorId == id)
                .Select(x => new ProveedorMedicamentoReadDTO
                {
                    MedicamentoId = x.ProveedorId,
                    Nombre = x.Nombre,
                    Telefono = x.Telefono,
                    Email = x.Email,
                    Direccion = x.Direccion
                })
                .FirstOrDefaultAsync();
            return proveedormedicamento;
        }

        public async Task UpdateAsync(int id, ProveedorMedicamentoUpdateDTO medicamentoUpdateDTO)
        {
            var proveedormedicamento = await _context.ProveedorMedicamentos.FindAsync(id);

            proveedormedicamento.Nombre = medicamentoUpdateDTO.Nombre;
            proveedormedicamento.Telefono = medicamentoUpdateDTO.Telefono;
            proveedormedicamento.Email = medicamentoUpdateDTO.Email;
            proveedormedicamento.Direccion = medicamentoUpdateDTO.Direccion;
            _context.ProveedorMedicamentos.Update(proveedormedicamento);
            await _context.SaveChangesAsync();

        }

    }
}
