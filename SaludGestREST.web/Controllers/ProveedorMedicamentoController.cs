using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs.CentroMedico;
using SaludGestREST.Services.DTOs.ProveedorMedicamento;
using SaludGestREST.Services.Services.Interfaces;

namespace SaludGestREST.web.Controllers
{
    [Route("api/v1/centrosMedicos")]
    [ApiController]
    public class ProveedorMedicamentoController : ControllerBase
    {
        private readonly IProveedorMedicamentoService _serviceProveedor;
    
            public ProveedorMedicamentoController(IProveedorMedicamentoService service)
            {
                _serviceProveedor = service;
            }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var proveedormedicamento = await _serviceProveedor.GetAllAsync();
            return Ok(proveedormedicamento);
        }

        // GET api/<CentroMedicoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var proveedormedicamento = await _serviceProveedor.GetByIdAsync(id);
                return Ok(proveedormedicamento);
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.CentroMedicoNotFoundWithId });
            }
        }

        // POST api/<CentroMedicoController>
        [HttpPost]
        public async Task<IActionResult> CreateProveedorMedicina([FromForm] ProveedorMedicamentoCreateDTO proveedorMedicamentoCreateDTO)
        {
            try
            {
                await _serviceProveedor.AddAsync(proveedorMedicamentoCreateDTO);
                return NoContent();
            }
            catch
            {
                return BadRequest(new { mesage = Messages.Error.CentroMedicoCreateError });
            }
        }

        // PUT api/<CentroMedicoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditProveedorMedicina(int id, [FromForm] ProveedorMedicamentoUpdateDTO proveedorMedicamentoUpdateDTO)
        {

            var centroMedico = await _serviceProveedor.GetByIdAsync(id);
            if (centroMedico == null)
            {
                return NotFound(new { message = Messages.Error.CentroMedicoNotFoundWithId });
            }

            try
            {
                await _serviceProveedor.UpdateAsync(id, proveedorMedicamentoUpdateDTO);
                return NoContent();
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.CentroMedicoUpdateError });
            }
        }

        // DELETE api/<CentroMedicoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteP(int id)
        {
            try
            {
                await _serviceProveedor.DeleteAsync(id);
                return Ok();
            }
            catch
            {
                return BadRequest(new { mesage = Messages.Error.CentroMedicoDeleteError });
            }
        }

    }

}
