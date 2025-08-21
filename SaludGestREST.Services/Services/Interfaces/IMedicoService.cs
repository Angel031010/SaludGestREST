using SaludGestREST.Services.DTOs.Medico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Interfaces
{
    public interface IMedicoService :IGenericService<MedicoCreateDTO, MedicoReadDTO,  MedicoUpdateDTO>
    {
        
    }
}
