using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SaludGestREST.Data;
using SaludGestREST.Data.Models;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs;
using SaludGestREST.Services.Services.Interfaces;
using SaludGestREST.Services.Settings;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SaludGestREST.Services.Services.Implementations
{
    public class PacienteService : IPacienteService
    {
        private readonly UploadSettings _uploadSettings;
        private readonly ApplicationDbContext _context;
        public PacienteService(UploadSettings uploadSettings, ApplicationDbContext context)
        {
            _uploadSettings = uploadSettings;
            _context = context;
        }

        public async Task DeleteAsync(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente == null)
                throw new KeyNotFoundException(nameof(id));
            paciente.IsDeleted = true;
            paciente.IsActive = false;
            _context.Pacientes.Update(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PacienteReadDTO>> GetAllAsync()
        {
            var paciente = await _context.Pacientes
                .Where(x => !x.IsDeleted)
                .Select(x => new PacienteReadDTO
                {
                    PacienteId = x.PacienteId,
                    Nombre = x.Nombre,
                    ApPaterno = x.ApPaterno,
                    ApMaterno = x.ApMaterno,
                    FechaNacimiento = x.FechaNacimiento,
                    Telefono = x.Telefono,
                    UrlFoto = x.UrlFoto,
                    Email = x.Email,
                    Active = x.IsActive,
                    HighSystem = x.HighSystem
                })
                .ToListAsync();
            return paciente;
        }

        public async Task<PacienteReadDTO> GetByIdAsync(int id)
        {
            var paciente = await _context.Pacientes
                .Where(x => !x.IsDeleted && x.PacienteId == id)
                .Select(x => new PacienteReadDTO
                {
                    PacienteId = x.PacienteId,
                    Nombre = x.Nombre,
                    ApPaterno = x.ApPaterno,
                    ApMaterno = x.ApMaterno,
                    FechaNacimiento = x.FechaNacimiento,
                    Telefono = x.Telefono,
                    UrlFoto = x.UrlFoto,
                    Email = x.Email,
                    Active = x.IsActive,
                    HighSystem = x.HighSystem
                })
                .FirstOrDefaultAsync();
            return paciente;
        }

        public Task<PacienteReadDTO> GetDetailsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(PacienteCreateDTO dto)
        {
            var UrlString = await UploadImage(dto.File);
            var paciente = new Paciente
            {
                Nombre = dto.Nombre,
                ApPaterno = dto.ApPaterno,
                ApMaterno = dto.ApMaterno,
                FechaNacimiento = dto.FechaNacimiento,
                Telefono = dto.Telefono,
                UrlFoto = UrlString,
                Email = dto.Email,
            };
            await _context.AddAsync(paciente);
            await _context.SaveChangesAsync();
            dto.PacienteId = paciente.PacienteId;
        }

        public async Task UpdateAsync(int id, PacienteCreateDTO dto)
        {
            if (id != dto.PacienteId)
                throw new ArgumentException("El id es incorrecto");
            var paciente = await _context.Pacientes.SingleAsync(x => x.PacienteId == id);
            if (paciente == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.PacienteNotFoundWithId, id));
            string UrlString = await UploadImage(dto.File);
            paciente.Nombre = dto.Nombre;
            paciente.ApPaterno = dto.ApPaterno;
            paciente.ApMaterno = dto.ApMaterno;
            paciente.FechaNacimiento = dto.FechaNacimiento;
            paciente.Telefono = dto.Telefono;
            paciente.UrlFoto = UrlString;
            paciente.Email = dto.Email;
            _context.Pacientes.Update(paciente);
            await _context.SaveChangesAsync();
        }

        private async Task<string> UploadImage(IFormFile file)
        {
            ValidateFile(file);

            string _customPath = Path.Combine(Directory.GetCurrentDirectory(), _uploadSettings.UploadDirectory);
            //string _customPath = Path.Combine(_env.WebRootPath, _uploadSettings.UploadDirectory);

            if (!Directory.Exists(_customPath))   // Crear el directorio si no existe
            {
                Directory.CreateDirectory(_customPath);
            }

            // Generar el nombre único del archivo
            var fileName = Path.GetFileNameWithoutExtension(file.FileName)
                            + Guid.NewGuid().ToString()
                            + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(_customPath, fileName);

            // Guardar el archivo
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Retornar la ruta relativa o completa, según sea necesario
            return $"/{_uploadSettings.UploadDirectory}/{fileName}";
        }
        private void ValidateFile(IFormFile file)
        {
            var permittedExtensions = _uploadSettings.AllowedExtensions.Split(',');
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();

            if (!permittedExtensions.Contains(extension))
            {
                //throw new NotSupportedException("El tipo de archivo no es soportado.");
                throw new NotSupportedException(Messages.Validation.UnSupportedFileType);
            }
        }
    }
}
