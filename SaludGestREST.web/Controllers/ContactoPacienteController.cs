using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaludGestREST.Services.Constants;
using SaludGestREST.Services.DTOs.ContactoPaciente;
using SaludGestREST.Services.Services.Interfaces;

namespace SaludGestREST.web.Controllers
{
    [Route("api/v1/contactosPacientes")]
    [ApiController]
    public class ContactoPacienteController : ControllerBase
    {
        private readonly IContactoPacienteService _serviceContactoPaciente;

        public ContactoPacienteController(IContactoPacienteService service)
        {
            _serviceContactoPaciente = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contactosPacientes = await _serviceContactoPaciente.GetAllAsync();
            return Ok(contactosPacientes);
        }

        // GET api/<ContactoPacienteController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var contactoPaciente = await _serviceContactoPaciente.GetByIdAsync(id);
                return Ok(contactoPaciente);
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.ContactoPacienteNotFoundWithId });
            }
        }

        // POST api/<ContactoPacienteController>
        [HttpPost]
        public async Task<IActionResult> CreateContactoPaciente([FromBody] ContactoPacienteCreateDTO contactoPacienteCreateDTO)
        {
            try
            {
                await _serviceContactoPaciente.AddAsync(contactoPacienteCreateDTO);
                return NoContent();
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.ContactoPacienteCreateError });
            }
        }

        // PUT api/<ContactoPacienteController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContactoPaciente(int id, [FromBody] ContactoPacienteUpdateDTO contactoPacienteUpdateDTO)
        {
            var contactoPaciente = await _serviceContactoPaciente.GetByIdAsync(id);
            if (contactoPaciente == null)
            {
                return NotFound(new { message = Messages.Error.ContactoPacienteNotFoundWithId });
            }
            try
            {
                await _serviceContactoPaciente.UpdateAsync(id, contactoPacienteUpdateDTO);
                return NoContent();
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.ContactoPacienteUpdateError });
            }
        }

        // DELETE api/<ContactoPacienteController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactoPaciente(int id)
        {
            try
            {
                await _serviceContactoPaciente.DeleteAsync(id);
                return NoContent();
            }
            catch
            {
                return BadRequest(new { message = Messages.Error.ContactoPacienteDeleteError });
            }
        }
    }
}
