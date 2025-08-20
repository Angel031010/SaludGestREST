using SaludGestREST.Services.DTOs;
using SaludGestREST.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Implementations
{
    internal class MedicamentoService : IMedicamentoService
    {
        /*private readonly ApplicationDbContext _context;
        public MedicamentoService(ApplicationDbContext context)
        {
            _context = context;
        }*/

        public Task AddAsync(MedicamentoDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MedicamentoDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MedicamentoDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MedicamentoDTO> GetDetailsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, MedicamentoDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
