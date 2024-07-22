using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello Aluno");
        }
    }
}