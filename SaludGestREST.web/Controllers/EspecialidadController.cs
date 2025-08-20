using Microsoft.AspNetCore.Mvc;
using SaludGestREST.Services.DTOs.Especialidad;
using SaludGestREST.Services.Services.Interfaces;

namespace SaludGestREST.web.Controllers
{
    [Route("api/v1/especialidades")]
    [ApiController]
    public class EspecialidadController : ControllerBase
    {
        private readonly IEspecialidadService _especialidadService;

        public EspecialidadController(IEspecialidadService especialidadService)
        {
            _especialidadService = especialidadService;
        }
        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var products = await _especialidadService.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("{IdEspecialidad}")]
        public async Task<IActionResult> GetById(int idEspecialidad)
        {
            var especialidad = await _especialidadService.GetByIdAsync(idEspecialidad);

            if (especialidad == null)
            {
                return NotFound(new { message = "El producto no existe" });     // Respuesta HTTP 404 Not Found con un mensaje
            }
            return Ok(especialidad);                                                 // Retorna 200 OK con el producto encontrado.
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EspecialidadCreateDTO especialidadDTO)
        {
            // Con [ApiController] se hace la validación de modelo de manera automática.
            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);  // Retorna 400

            try
            {
                await _especialidadService.AddAsync(especialidadDTO);

                return CreatedAtAction(nameof(GetById), new { id = especialidadDTO.IdEspecialidad }, especialidadDTO);    // Retorna 201 Created con la información del nuevo producto.
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Hubo un error al crear la especialidad: {ex.Message}" });   // Retorna 400 Bad Request con un mensaje de error.
            }
        }
        [HttpPut("{idEspecialidad}")]
        public async Task<IActionResult> Update(int idEspecialidad, [FromBody] EspecialidadUpdateDTO especialidadDTO)
        {
            if (idEspecialidad != especialidadDTO.IdEspecialidad)
            {
                return BadRequest(new { message = "El ID de la ruta no coincide con el ID de la especialidad" }); // Respuesta HTTP 400 Bad Request con un mensaje.
            }

            // Con [ApiController] se hace la validación de modelo de manera automática.
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);  // Retorna 400
            //}

            var existingProduct = await _especialidadService.GetByIdAsync(idEspecialidad);
            if (existingProduct == null)
            {
                return NotFound(new { message = "Producto no encontrado" });    // Respuesta HTTP 404 Not Found con un mensaje.
            }

            try
            {
                await _especialidadService.UpdateAsync(idEspecialidad, especialidadDTO);

                return NoContent();                                             // Retorna 204 No Content para indicar que la operación fue exitosa.
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Hubo un error al actualizar la especialidad: {ex.Message}" });  // Retorna 400 Bad Request con un mensaje de error.
            }
        }

        [HttpDelete("{idEspecialidad}")]
        public async Task<IActionResult> Delete(int idEspecialidad)
        {
            try
            {
                var existingEspecialidad = await _especialidadService.GetByIdAsync(idEspecialidad);
                if (existingEspecialidad == null)
                {
                    return NotFound(new { message = "Especialidad no encontrado" });    // Respuesta HTTP 404 Not Found con un mensaje.
                }

                await _especialidadService.DeleteAsync(idEspecialidad);

                return NoContent();                                                 // Retorna 204 No Content para indicar que la operación fue exitosa.
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        message = $"Error al eliminar la especialidad: {ex.Message}"
                    });   // Retorna 500 Internal Server Error con un mensaje de error.
            }
        }
    }
}
