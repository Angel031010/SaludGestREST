using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs.Cita;
using SaludGestREST.Services.Services.Interfaces;

namespace SaludGestREST.web.Controllers
{
    [Route("api/v1/citas")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly ICitaService _serviceCita;

        public CitaController(ICitaService service)
        {
            _serviceCita = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var citas = await _serviceCita.GetAllAsync();
            return Ok(citas);
        }

        // GET api/<CitaController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var cita = await _serviceCita.GetByIdAsync(id);
                return Ok(cita);
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.CitaNotFoundWithId });
            }
        }

        // POST api/<CitaController>
        [HttpPost]
        public async Task<IActionResult> CreateCita([FromBody] CitaCreateDTO citaCreateDTO)
        {
            try
            {
                await _serviceCita.AddAsync(citaCreateDTO);
                return NoContent();
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.CitaCreateError });
            }
        }

        // PUT api/<CitaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCita(int id, [FromBody] CitaUpdateDTO citaUpdateDTO)
        {
            var cita = await _serviceCita.GetByIdAsync(id);
            if (cita == null)
            {
                return NotFound(new { message = Messages.Error.CitaNotFoundWithId });
            }
            try
            {
                await _serviceCita.UpdateAsync(id, citaUpdateDTO);
                return NoContent();
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.CitaUpdateError });
            }
        }

        // DELETE api/<CitaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCita(int id)
        {
            try
            {
                await _serviceCita.DeleteAsync(id);
                return NoContent();
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.CitaNotFoundWithId });
            }
        }
    }
}
