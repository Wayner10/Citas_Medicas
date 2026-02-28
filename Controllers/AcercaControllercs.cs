using Microsoft.AspNetCore.Mvc;

namespace Sistema_de_Gestion_de_Citas_Medicas.Controllers
{
    public class AcercaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}