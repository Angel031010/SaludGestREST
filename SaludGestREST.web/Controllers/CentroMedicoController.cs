using Microsoft.AspNetCore.Mvc;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs;
using SaludGestREST.Services.DTOs.CentroMedico;
using SaludGestREST.Services.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SaludGestREST.web.Uploads
{
    [Route("api/v1/centrosMedicos")]
    [ApiController]
    public class CentroMedicoController : ControllerBase
    {
        private readonly ICentroMedicoService _serviceCentroMedico;

        public CentroMedicoController(ICentroMedicoService service)
        {
            _serviceCentroMedico = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var centrosMedicos = await _serviceCentroMedico.GetAllAsync();
            return Ok(centrosMedicos);
        }

        // GET api/<CentroMedicoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var centrosMedico = await _serviceCentroMedico.GetByIdAsync(id);
                return Ok(centrosMedico);
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.MedicamentoNotFoundWithId });
            }
        }

        // POST api/<CentroMedicoController>
        [HttpPost]
        public async Task<IActionResult> CreateCentroMedico([FromForm] CentroMedicoCreateDTO centroMedicoCreateDTO)
        {
            try
            {
                await _serviceCentroMedico.AddAsync(centroMedicoCreateDTO);
                return NoContent();
            }
            catch
            {
                return BadRequest(new { mesage = Messages.Error.MedicamentoCreateError });
            }
        }

        // PUT api/<CentroMedicoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditCentroMedico(int id, [FromForm] CentroMedicoUpdateDTO centroMedicoUpdateDTO)
        {

            var centroMedico = await _serviceCentroMedico.GetByIdAsync(id);
            if (centroMedico == null)
            {
                return NotFound(new { message = Messages.Error.MedicamentoNotFoundWithId });
            }

            try
            {
                await _serviceCentroMedico.UpdateAsync(id, centroMedicoUpdateDTO);
                return NoContent();
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.MedicamentoUpdateError });
            }
        }

        // DELETE api/<CentroMedicoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCentroMedico(int id)
        {
            try
            {
                await _serviceCentroMedico.DeleteAsync(id);
                return Ok();
            }
            catch
            {
                return BadRequest(new { mesage = Messages.Error.MedicamentoDeleteError });
            }
        }
    }
}
