using SaludGestREST.Services.DTOs.Especialidad;
using SaludGestREST.Services.DTOs.ProveedorMedicamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Interfaces
{
    public interface IProveedorMedicamentoService : IGenericService<ProveedorMedicamentoCreateDTO, ProveedorMedicamentoReadDTO, ProveedorMedicamentoUpdateDTO>
    {

    }
}
