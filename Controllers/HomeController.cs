using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Gestion_de_Citas_Medicas.Models;

namespace Sistema_de_Gestion_de_Citas_Medicas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
