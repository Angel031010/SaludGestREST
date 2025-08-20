using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SaludGestREST.web.Uploads
{
    [Route("api/[controller]")]
    [ApiController]
    public class CentroMedicoController : ControllerBase
    {
        // GET: api/<CentroMedicoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CentroMedicoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CentroMedicoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CentroMedicoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CentroMedicoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
