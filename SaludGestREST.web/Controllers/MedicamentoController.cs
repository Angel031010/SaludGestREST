using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaludGestREST.Data;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs;
using SaludGestREST.Services.Services.Interfaces;

namespace SaludGestREST.web.Controllers
{
    [Route("medicamento")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class MedicamentoController : ControllerBase
    {

        private readonly IMedicamentoService _serviceMedicamento;
        public MedicamentoController(IMedicamentoService service)
        {
            _serviceMedicamento = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var medicamentos = await _serviceMedicamento.GetAllAsync();
                return Ok(medicamentos);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = Messages.Error.MedicamentoNotFound });
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var medicamento = await _serviceMedicamento.GetByIdAsync(id);
                return Ok(medicamento);
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.MedicamentoNotFoundWithId });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] MedicamentoDTO medicamentoDTO)
        {
            try
            {
                await _serviceMedicamento.AddAsync(medicamentoDTO);
                return Ok();
            }
            catch
            {
                return BadRequest(new { mesage = Messages.Error.MedicamentoCreateError });
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] MedicamentoDTO medicamentoDTO)
        {
            try
            {
                await _serviceMedicamento.UpdateAsync(id, medicamentoDTO);
                return Ok();
            }
            catch
            {
                return BadRequest(new { mesage = Messages.Error.MedicamentoUpdateError });
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            try
            {
                await _serviceMedicamento.DeleteAsync(id);
                return Ok();
            }
            catch
            {
                return BadRequest(new { mesage = Messages.Error.MedicamentoDeleteError });
            }
        }
    }
}
