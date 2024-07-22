using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello Professor");
        }
    }
}
