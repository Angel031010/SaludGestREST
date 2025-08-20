using SaludGestREST.Services.DTOs.CentroMedico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Interfaces
{
    public interface ICentroMedicoService : IGenericService<CentroMedicoCreateDTO, CentroMedicoReadDTO, CentroMedicoUpdateDTO, CentroMedicoReadDTO>
    {
    }
}
