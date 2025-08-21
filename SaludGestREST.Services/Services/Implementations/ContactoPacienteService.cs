using Microsoft.EntityFrameworkCore;
using SaludGestREST.Data;
using SaludGestREST.Data.Models;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs.ContactoPaciente;
using SaludGestREST.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Implementations
{
    public class ContactoPacienteService : IContactoPacienteService
    {

        private readonly ApplicationDbContext _context;

        public ContactoPacienteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(ContactoPacienteCreateDTO dto)
        {
            var contactoPaciente = new ContactoPaciente
            {
                PacienteId = dto.PacienteId,
                TipoContacto = dto.TipoContacto,
                Calle = dto.Calle,
                Ciudad = dto.Ciudad,
                Estado = dto.Estado,
                CodigoPostal = dto.CodigoPostal,
                Telefono = dto.Telefono,
            };

            await _context.ContactosPacientes.AddAsync(contactoPaciente);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var contacto = await _context.ContactosPacientes.FindAsync(id);
            if (contacto == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.ContactoPacienteNotFoundWithId, id));

            contacto.IsDeleted = true;
            contacto.IsActive = false;
            _context.ContactosPacientes.Update(contacto);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ContactoPacienteReadDTO>> GetAllAsync()
        {
            var contactos = await _context.ContactosPacientes
                .Where(c => !c.IsDeleted)
                .Select(c => new ContactoPacienteReadDTO
                {
                    ContactoPacienteId= c.ContactoPacienteId,
                    PacienteId = c.PacienteId,
                    NombrePaciente = c.Paciente.Nombre,
                    Telefono = c.Telefono,
                    TipoContacto = c.TipoContacto,
                    Calle = c.Calle,
                    Ciudad = c.Ciudad,
                    Estado = c.Estado,
                    CodigoPostal = c.CodigoPostal,
                    IsActive = c.IsActive,
                    HighSystem = c.HighSystem,
                }).ToListAsync();
            return contactos;
        }

        public async Task<ContactoPacienteReadDTO> GetByIdAsync(int id)
        {
            var contacto = await _context.ContactosPacientes
                .Where(c => c.ContactoPacienteId == id && !c.IsDeleted)
                .Select(c => new ContactoPacienteReadDTO
                {
                    ContactoPacienteId = c.ContactoPacienteId,
                    PacienteId = c.PacienteId,
                    NombrePaciente = c.Paciente.Nombre,
                    Telefono = c.Telefono,
                    TipoContacto = c.TipoContacto,
                    Calle = c.Calle,
                    Ciudad = c.Ciudad,
                    Estado = c.Estado,
                    CodigoPostal = c.CodigoPostal,
                    IsActive = c.IsActive,
                    HighSystem = c.HighSystem,
                }).FirstOrDefaultAsync();
            if (contacto == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.ContactoPacienteNotFoundWithId, id));
            return contacto;
        }

        public async Task UpdateAsync(int id, ContactoPacienteUpdateDTO dto)
        {
            var contacto = await _context.ContactosPacientes.FindAsync(id);
            if (contacto == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.ContactoPacienteNotFoundWithId, id));

            contacto.TipoContacto = dto.TipoContacto;
            contacto.Calle = dto.Calle;
            contacto.Ciudad = dto.Ciudad;
            contacto.Estado = dto.Estado;
            contacto.CodigoPostal = dto.CodigoPostal;
            contacto.Telefono = dto.Telefono;

            _context.ContactosPacientes.Update(contacto);
            await _context.SaveChangesAsync();

        }
    }
}
