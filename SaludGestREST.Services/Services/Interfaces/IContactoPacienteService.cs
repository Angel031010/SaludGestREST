using SaludGestREST.Services.DTOs.ContactoPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Interfaces
{
    public interface IContactoPacienteService : IGenericService<ContactoPacienteCreateDTO, ContactoPacienteReadDTO, ContactoPacienteUpdateDTO>
    {
    }
}
