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

        // GET: /Especialidades/Create
        public IActionResult Create()
        {
            return View(new EspecialidadCreateVM());
        }

        // POST: /Especialidades/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EspecialidadCreateVM vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            return RedirectToAction(nameof(Index));
        }

        // GET: /Especialidades/Edit/1
        public IActionResult Edit(int id = 1)
        {
            var mock = new EspecialidadCreateVM
            {
                Id = id,
                Nombre = "Neumología",
                Descripcion = "Enfermedades respiratorias.",
                Activa = true
            };

            return View(mock);
        }

        // POST: /Especialidades/Edit/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, EspecialidadCreateVM vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            return RedirectToAction(nameof(Index));
        }

        // GET: /Especialidades/Details/1
        public IActionResult Details(int id = 1)
        {
            var mock = new EspecialidadCreateVM
            {
                Id = id,
                Nombre = "Medicina General",
                Descripcion = "Atención primaria y control general.",
                Activa = true
            };

            return View(mock);
        }

        // GET: /Especialidades/Delete/1
        public IActionResult Delete(int id = 1)
        {
            var mock = new EspecialidadCreateVM
            {
                Id = id,
                Nombre = "Medicina General",
                Descripcion = "Atención primaria, control general y seguimiento de pacientes.",
                Activa = true
            };

            return View(mock);
        }

        // POST: /Especialidades/DeleteConfirmed/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            // mock: luego será API/BD (o desactivar Activa)
            return RedirectToAction(nameof(Index));
        }
    }
}