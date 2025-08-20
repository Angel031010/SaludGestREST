using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SaludGestREST.Controllers
{
    [Route("/")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("SaludGest REST API is running.");
        }
    }
}
