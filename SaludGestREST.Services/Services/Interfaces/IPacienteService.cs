using SaludGestREST.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Interfaces
{
    public interface IPacienteService : IGenericService<PacienteCreateDTO, PacienteReadDTO, PacienteCreateDTO>
    {
    }
}
