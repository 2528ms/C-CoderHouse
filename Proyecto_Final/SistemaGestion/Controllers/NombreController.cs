using Microsoft.AspNetCore.Mvc;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NombreController : Controller
    {
        
        [HttpGet]
        public string obtenerNombreLocal()
        {
            return "Sosa Mariano";
        }
    }
}
