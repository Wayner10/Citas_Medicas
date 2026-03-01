using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema_de_Gestion_de_Citas_Medicas.ViewModels;

namespace Sistema_de_Gestion_de_Citas_Medicas.Controllers
{
    public class CitasController : Controller
    {
        // GET: /Citas
        public IActionResult Index()
        {

            var citas = new List<CitaCreateVM>
            {
                new CitaCreateVM
                {
                    Id = 1,
                    PacienteId = 1,
                    DoctorId = 2,
                    EspecialidadId = 3,
                    Fecha = DateTime.Today.AddDays(1),
                    Hora = new TimeSpan(9, 30, 0),
                    Motivo = "Control general",
                    Activa = true
                },
                new CitaCreateVM
                {
                    Id = 2,
                    PacienteId = 2,
                    DoctorId = 1,
                    EspecialidadId = 2,
                    Fecha = DateTime.Today.AddDays(2),
                    Hora = new TimeSpan(14, 0, 0),
                    Motivo = "Dolor de garganta",
                    Activa = true
                }
            };

            return View(citas);
        }

        // GET: /Citas/Create
        public IActionResult Create()
        {
            var vm = BuildMockCombos(new CitaCreateVM
            {
                Fecha = DateTime.Today,
                Hora = new TimeSpan(8, 0, 0),
                Activa = true
            });

            return View(vm);
        }

        // POST: /Citas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CitaCreateVM vm)
        {
            if (!ModelState.IsValid)
            {

                vm = BuildMockCombos(vm);
                return View(vm);
            }


            return RedirectToAction(nameof(Index));
        }

        // GET: /Citas/Edit/1
        public IActionResult Edit(int id = 1)
        {
            var mock = new CitaCreateVM
            {
                Id = id,
                PacienteId = 1,
                DoctorId = 2,
                EspecialidadId = 3,
                Fecha = DateTime.Today.AddDays(1),
                Hora = new TimeSpan(10, 15, 0),
                Motivo = "Seguimiento",
                Activa = true
            };

            mock = BuildMockCombos(mock);
            return View(mock);
        }

        // POST: /Citas/Edit/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, CitaCreateVM vm)
        {
            if (!ModelState.IsValid)
            {
                vm = BuildMockCombos(vm);
                return View(vm);
            }


            return RedirectToAction(nameof(Index));
        }

        // GET: /Citas/Details/1
        public IActionResult Details(int id = 1)
        {
            var mock = new CitaCreateVM
            {
                Id = id,
                PacienteId = 1,
                DoctorId = 2,
                EspecialidadId = 3,
                Fecha = DateTime.Today.AddDays(1),
                Hora = new TimeSpan(9, 0, 0),
                Motivo = "Chequeo",
                Activa = true
            };

            mock = BuildMockCombos(mock);
            return View(mock);
        }


        private CitaCreateVM BuildMockCombos(CitaCreateVM vm)
        {
            vm.Pacientes = new List<SelectListItem>
            {
                new SelectListItem("Seleccione...", "", true, true) { Disabled = true },
                new SelectListItem("Juan Pérez", "1"),
                new SelectListItem("María Rodríguez", "2")
            };

            vm.Doctores = new List<SelectListItem>
            {
                new SelectListItem("Seleccione...", "", true, true) { Disabled = true },
                new SelectListItem("Dra. Ana Mora", "1"),
                new SelectListItem("Dr. Carlos Vargas", "2")
            };

            vm.Especialidades = new List<SelectListItem>
            {
                new SelectListItem("Seleccione...", "", true, true) { Disabled = true },
                new SelectListItem("Medicina General", "1"),
                new SelectListItem("Neumología", "2"),
                new SelectListItem("Cardiología", "3")
            };

            return vm;
        }

        // GET: /Citas/Delete/1
        public IActionResult Delete(int id = 1)
        {
            var mock = new CitaCreateVM
            {
                Id = id,
                PacienteId = 1,
                DoctorId = 2,
                EspecialidadId = 3,
                Fecha = DateTime.Today.AddDays(2),
                Hora = new TimeSpan(10, 30, 0),
                Motivo = "Consulta general de control",
                Activa = true,

                // Opcional (por si la vista usa los combos)
                Pacientes = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Juan Pérez" }
        },

                Doctores = new List<SelectListItem>
        {
            new SelectListItem { Value = "2", Text = "Dr. Carlos Ramírez" }
        },

                Especialidades = new List<SelectListItem>
        {
            new SelectListItem { Value = "3", Text = "Medicina General" }
        }
            };

            return View(mock);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            // mock: luego será llamada a API/BD
            return RedirectToAction(nameof(Index));
        }
    }
} 