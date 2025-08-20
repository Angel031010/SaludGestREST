using SaludGestREST.Services.DTOs.Especialidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Interfaces
{
    public interface IEspecialidadService : IGenericService<EspecialidadCreateDTO, EspecialidadReadDTO, EspecialidadUpdateDTO, EspecialidadReadDTO>
    {
    }
}
