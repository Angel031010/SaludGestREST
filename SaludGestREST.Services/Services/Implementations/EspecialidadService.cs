using Humanizer;
using Microsoft.EntityFrameworkCore;
using SaludGestREST.Data;
using SaludGestREST.Data.Models;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs.Especialidad;
using SaludGestREST.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Services.Implementations
{
    public class EspecialidadService : IEspecialidadService
    {
        private readonly ApplicationDbContext _context;

        public EspecialidadService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<EspecialidadReadDTO>> GetAllAsync()
        {
            var especialidades = await _context.Especialidades
                .Where(e => e.IsActive == true)
                .Select(e => new EspecialidadReadDTO
                {
                    IdEspecialidad = e.IdEspecialidad,
                    Nombre = e.Nombre,
                    Descripcion = e.Descripcion,
                    IsActive = e.IsActive,
                    HighSystem = e.HighSystem
                })
            .ToListAsync();
            return especialidades;
        }

        public async Task AddAsync(EspecialidadCreateDTO especialidadCreateDTO)
        {
            var especialidad = new Especialidad
            {
                Nombre = especialidadCreateDTO.Nombre,
                Descripcion = especialidadCreateDTO.Descripcion,

            };

            await _context.Especialidades.AddAsync(especialidad);
            await _context.SaveChangesAsync();
        }

        public async Task<EspecialidadReadDTO> GetByIdAsync(int id)
        {
            var especialidad = await _context.Especialidades
                .Where(e => e.IdEspecialidad == id)
                .Select(e => new EspecialidadReadDTO
                {
                    IdEspecialidad = e.IdEspecialidad,
                    Nombre = e.Nombre,
                    Descripcion = e.Descripcion,
                    IsActive = e.IsActive,
                    HighSystem = e.HighSystem
                })
            .FirstOrDefaultAsync();
            return especialidad;

        }

        public async Task UpdateAsync(int idEspecialidad, EspecialidadUpdateDTO especialidad)
        {
            if (idEspecialidad != especialidad.IdEspecialidad)
                throw new ApplicationException("El id es incorrecto");
            var especialidades = await _context.Especialidades
                .FindAsync(especialidad.IdEspecialidad);

            if (especialidades == null)
                throw new KeyNotFoundException(string.Format
                    (Messages.Error.EspecialidadError
                    , idEspecialidad));
            especialidades.Nombre = especialidad.Nombre;
            especialidades.Descripcion = especialidad.Descripcion;
            especialidades.IsActive = especialidad.IsActive;
            _context.Especialidades.Update(especialidades);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int idEspecialidad)
        {
            var especialidad = await _context.Especialidades.FindAsync(idEspecialidad);
            if (especialidad == null)
            {
                throw new KeyNotFoundException(string.Format(Messages.Error.ProductNotFoundWithId, idEspecialidad));

            }
            especialidad.IsActive = false;
            _context.Especialidades.Update(especialidad);
            await _context.SaveChangesAsync();
        }

    }
}
