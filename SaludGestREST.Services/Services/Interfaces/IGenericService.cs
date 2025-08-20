using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Interfaces
{
    public interface IGenericService<TCreateDTO, TReadDTO, TUpdateDTO, TDetails>
        where TCreateDTO : class
        where TReadDTO : class
        where TUpdateDTO : class
        where TDetails : class
    {
        Task<List<TReadDTO>> GetAllAsync();
        Task<TReadDTO> GetByIdAsync(int id);
        Task<TDetails> GetDetailsByIdAsync(int id);
        Task AddAsync(TCreateDTO dto);
        Task UpdateAsync(int id, TUpdateDTO dto);
        Task DeleteAsync(int id);
    }
}
