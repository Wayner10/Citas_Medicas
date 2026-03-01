using Microsoft.AspNetCore.Mvc;
using Sistema_de_Gestion_de_Citas_Medicas.ViewModels;

namespace Sistema_de_Gestion_de_Citas_Medicas.Controllers
{
    public class EspecialidadesController : Controller
    {
        // GET: /Especialidades
        public IActionResult Index()
        {
            var list = new List<EspecialidadCreateVM>
            {
                new EspecialidadCreateVM { Id = 1, Nombre = "Medicina General", Descripcion = "Atención primaria y control general.", Activa = true },
                new EspecialidadCreateVM { Id = 2, Nombre = "Neumología", Descripcion = "Enfermedades respiratorias.", Activa = true },
                new EspecialidadCreateVM { Id = 3, Nombre = "Cardiología", Descripcion = "Sistema cardiovascular.", Activa = false },
                new EspecialidadCreateVM { Id = 4, Nombre = "Pediatría", Descripcion = "Atención médica infantil.", Activa = true }
            };

            return View(list);
        }
    }
}