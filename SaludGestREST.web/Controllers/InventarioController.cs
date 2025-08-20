using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs;
using SaludGestREST.Services.Services.Interfaces;

namespace SaludGestREST.web.Controllers
{
    [Route("inventario")]
    [ApiController]
    [Authorize(Roles = "Medico")]
    public class InventarioController : ControllerBase
    {
        private readonly IInventarioService _inventarioService;
        public InventarioController(IInventarioService service)
        {
            _inventarioService = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var medicamentos = await _inventarioService.GetAllAsync();
                return Ok(medicamentos);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = Messages.Error.InventariosNotFound });
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var medicamento = await _inventarioService.GetByIdAsync(id);
                return Ok(medicamento);
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.InventarioNotFoundWithId });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] InventarioDTO medicamentoDTO)
        {
            try
            {
                await _inventarioService.AddAsync(medicamentoDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mesage = Messages.Error.InventarioCreateError });
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] InventarioDTO medicamentoDTO)
        {
            try
            {
                await _inventarioService.UpdateAsync(id, medicamentoDTO);
                return Ok();
            }
            catch
            {
                return BadRequest(new { mesage = Messages.Error.InventarioUpdateError });
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            try
            {
                await _inventarioService.DeleteAsync(id);
                return Ok();
            }
            catch
            {
                return BadRequest(new { mesage = Messages.Error.InventarioDeleteError });
            }
        }
    }
}
