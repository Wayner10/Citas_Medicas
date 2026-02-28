using Microsoft.AspNetCore.Mvc;
using Sistema_de_Gestion_de_Citas_Medicas.ViewModels;

namespace Sistema_de_Gestion_de_Citas_Medicas.Controllers
{
    public class PacientesController : Controller
    {
        // GET: /Pacientes
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Pacientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Pacientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PacienteCreateVM vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            // Mock: aún no guardamos en BD (esto lo conectará el equipo luego)
            return RedirectToAction(nameof(Index));
        }

        // GET: /Pacientes/Edit/1
        public IActionResult Edit(int id = 1)
        {
            var mock = new PacienteCreateVM
            {
                Nombre = "Juan",
                Apellido = "Pérez",
                Cedula = "1-2345-6789",
                Telefono = "8888-8888",
                FechaNacimiento = new DateTime(1995, 5, 10),
                Activo = true
            };
            return View(mock);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(int id, PacienteCreateVM vm)
        {
            if (!ModelState.IsValid)
                return View(vm);
            // Mock: aún no guardamos en BD (esto lo conectará el equipo luego)
            return RedirectToAction(nameof(Index));
        }

        // GET: /Pacientes/Details/1
        public IActionResult Details(int id = 1)
        {
            var mock = new PacienteCreateVM
            {
                Nombre = "Juan",
                Apellido = "Pérez",
                Cedula = "1-2345-6789",
                Telefono = "8888-8888",
                FechaNacimiento = new DateTime(1995, 5, 10),
                Activo = true
            };

            return View(mock);
        }
    }
}