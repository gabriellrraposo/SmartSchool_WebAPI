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
            try
            {
                return Ok("Hello Aluno");
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}