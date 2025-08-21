using Microsoft.AspNetCore.Mvc;
using SaludGestREST.Data.Models;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs.Medico;
using SaludGestREST.Services.Services.Implementations;
using SaludGestREST.Services.Services.Interfaces;

namespace SaludGestREST.web.Controllers
{
    [Route("api/v1/medicos")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly IMedicoService _medicoService;

        public MedicoController(IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var medico = await
                _medicoService.GetAllAsync();
            return Ok(medico);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var medico = await
                    _medicoService.GetByIdAsync(id);
                    return Ok(medico);
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.CentroMedicoNotFound });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MedicoCreateDTO medicoCreateDTO)
        {
            try
            {
                await _medicoService.AddAsync(medicoCreateDTO);
                return NoContent();
            }
            catch (Exception ex) {
                return BadRequest(new { message = $"Hubo un error al crear la especialidad: {ex.Message}" });
            }
        }
        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(int id, [FromBody] MedicoUpdateDTO medicoUpdateDTO)
        {
            if (id != medicoUpdateDTO.MedicoId)
            {
                return BadRequest(new { message = "El ID de la ruta no coincide con el ID de la especialidad" }); // Respuesta HTTP 400 Bad Request con un mensaje.
            }

            // Con [ApiController] se hace la validación de modelo de manera automática.
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);  // Retorna 400
            //}

            var existingMedico = await _medicoService.GetByIdAsync(id);
            if (existingMedico == null)
            {
                return NotFound(new { message = "Medico no encontrado" });    // Respuesta HTTP 404 Not Found con un mensaje.
            }

            try
            {
                await _medicoService.UpdateAsync(id, medicoUpdateDTO);

                return NoContent();                                             // Retorna 204 No Content para indicar que la operación fue exitosa.
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Hubo un error al actualizar el medico: {ex.Message}" });  // Retorna 400 Bad Request con un mensaje de error.
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var existingMedico = await _medicoService.GetByIdAsync(id);
                if (existingMedico == null)
                {
                    return NotFound(new { message = "Medico no encontrado" });    // Respuesta HTTP 404 Not Found con un mensaje.
                }

                await _medicoService.DeleteAsync(id);

                return NoContent();  
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        message = $"Error al eliminar el medico: {ex.Message}"
                    });   // Retorna 500 Internal Server Error con un mensaje de error.
            }
        }
    }
}
