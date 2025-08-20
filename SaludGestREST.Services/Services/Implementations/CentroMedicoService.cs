using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SaludGestREST.Data;
using SaludGestREST.Data.Models;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs.CentroMedico;
using SaludGestREST.Services.Services.Interfaces;
using SaludGestREST.Services.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SaludGestREST.Services.Services.Implementations
{
    public class CentroMedicoService : ICentroMedicoService
    {

        private readonly ApplicationDbContext _context;
        private readonly UploadSettings _uploadSettings;
        private readonly IWebHostEnvironment _env;

        public CentroMedicoService (ApplicationDbContext context, IOptions<UploadSettings> uploadSettings, IWebHostEnvironment env)
        {
            _context = context;
            _uploadSettings = uploadSettings.Value;
            _env = env;
        }

        public async Task AddAsync(CentroMedicoCreateDTO dto)
        {
            var imagen = await UploadImage(dto.File);

            var centroMedico = new CentroMedico
            {
                Nombre = dto.Nombre,
                Codigo = dto.Codigo,
                Direccion = dto.Direccion,
                Telefono = dto.Telefono,
                Email = dto.Email,
                ImagenUrl = imagen ?? "/uploads/HDefault.jpg"
            };

            await _context.CentrosMedicos.AddAsync(centroMedico);
            await _context.SaveChangesAsync();
            //En caso de que falle el guardado, añadir linea como brandCreateDTO.Id = brand.Id;
        }

        public async Task DeleteAsync(int id)
        {
            var centroMedico = await _context.CentrosMedicos.FindAsync(id);
            if (centroMedico == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.CentroMedicoNotFoundWithId, id));
            centroMedico.IsDeleted = true;
            centroMedico.IsActive = false;
            _context.CentrosMedicos.Update(centroMedico);
            await _context.SaveChangesAsync();
        }

        public async Task<List<CentroMedicoReadDTO>> GetAllAsync()
        {
            var centrosMedicos = await _context.CentrosMedicos
                .Where(x => !x.IsDeleted)
                .Select(x => new CentroMedicoReadDTO
                {
                    CentroMedicoId = x.CentroMedicoId,
                    Nombre = x.Nombre,
                    Codigo = x.Codigo,
                    Direccion = x.Direccion,
                    Telefono = x.Telefono,
                    Email = x.Email,
                    ImagenUrl = x.ImagenUrl
                })
                .ToListAsync();

            return centrosMedicos;
        }

        public async Task<CentroMedicoReadDTO> GetByIdAsync(int id)
        {
            var centroMedico = await _context.CentrosMedicos
                .Where(x => x.CentroMedicoId == id && !x.IsDeleted)
                .Select(x => new CentroMedicoReadDTO
                {
                    CentroMedicoId = x.CentroMedicoId,
                    Nombre = x.Nombre,
                    Codigo = x.Codigo,
                    Direccion = x.Direccion,
                    Telefono = x.Telefono,
                    Email = x.Email,
                    ImagenUrl = x.ImagenUrl
                })
                .FirstOrDefaultAsync();
            if (centroMedico == null)
                throw new KeyNotFoundException(string.Format(Messages.Error.CentroMedicoNotFoundWithId, id));

            return centroMedico;
        }

        public async Task UpdateAsync(int id, CentroMedicoUpdateDTO dto)
        {

            var centroMedico = await _context.CentrosMedicos.FindAsync(id);

            if (centroMedico == null)
            {
                throw new KeyNotFoundException(string.Format(Messages.Error.CentroMedicoNotFoundWithId, id));
            }

            centroMedico.Nombre = dto.Nombre;
            centroMedico.Direccion = dto.Direccion;
            centroMedico.Telefono = dto.Telefono;
            centroMedico.Email = dto.Email;

            if (dto.File != null)
            {
                var imagen = await UploadImage(dto.File);
                centroMedico.ImagenUrl = imagen;
            }

            _context.CentrosMedicos.Update(centroMedico);
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
