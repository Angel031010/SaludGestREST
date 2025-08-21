using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs;
using SaludGestREST.Services.Services.Implementations;
using SaludGestREST.Services.Services.Interfaces;

namespace SaludGestREST.web.Controllers
{
    [Route("api/v1/pacientes")]
    [ApiController]
    //[Authorize]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteService _servicePaciente;
        public PacienteController(IPacienteService service)
        {
            _servicePaciente = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var pacientes = await _servicePaciente.GetAllAsync();
                return Ok(pacientes);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = Messages.Error.PacienteNotFound });
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var paciente = await _servicePaciente.GetByIdAsync(id);
                return Ok(paciente);
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.PacienteNotFoundWithId });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Crear([FromForm] PacienteCreateDTO createDTO)
        {
            try
            {
                await _servicePaciente.AddAsync(createDTO);
                return Ok();
            }
            catch
            {
                return BadRequest(new { mesage = Messages.Error.PcienteCreateError });
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromForm] PacienteCreateDTO createDTO)
        {
            try
            {
                await _servicePaciente.UpdateAsync(id, createDTO);
                return Ok();
            }
            catch
            {
                return BadRequest(new { mesage = Messages.Error.PacienteUpdateError });
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Actualizar(int id)
        {
            try
            {
                await _servicePaciente.DeleteAsync(id);
                return Ok();
            }
            catch
            {
                return BadRequest(new { mesage = Messages.Error.PacienteDeleteError });
            }
        }
    }
}
