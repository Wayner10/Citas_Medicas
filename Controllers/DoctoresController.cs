using Microsoft.AspNetCore.Mvc;
using Sistema_de_Gestion_de_Citas_Medicas.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sistema_de_Gestion_de_Citas_Medicas.Controllers
{
    public class DoctoresController : Controller
    {
        private static List<DoctorCreateVM> MockDoctores() => new()
        {
            new DoctorCreateVM
            {
                DoctorId = 1,
                Nombre = "Karla",
                Apellido = "Méndez",
                CodigoMed = "Med-10293",
                Telefono = "8888-1111",
                Correo = "karla.mendez@clinica.com",
                Especialidad = "Medicina General",
                Consultorio = "A-3",
                Activo = true
            },
            new DoctorCreateVM
            {
                DoctorId = 2,
                Nombre = "José",
                Apellido = "Alvarado",
                CodigoMed = "Med-20911",
                Telefono = "8888-2222",
                Correo = "jose.alvarado@clinica.com",
                Especialidad = "Cardiología",
                Consultorio = "B-1",
                Activo = false
            }
        };

        public IActionResult Index()
        {
            var lista = MockDoctores();
            return View(lista);
        }

        public IActionResult Create()
        {
            return View(new DoctorCreateVM());
        }

        public IActionResult Details(int id = 1)
        {
            var doctor = MockDoctores().FirstOrDefault(x => x.DoctorId == id) ?? MockDoctores().First();
            return View(doctor);
        }

        public IActionResult Edit(int id = 1)
        {
            var doctor = MockDoctores().FirstOrDefault(x => x.DoctorId == id) ?? MockDoctores().First();
            return View(doctor);
        }

        // GET: /Doctor/Delete/1   (o /Doctors/Delete/1 según tu controller)
        public IActionResult Delete(int id = 1)
        {
            var mock = new DoctorCreateVM
            {
                DoctorId = id,
                Nombre = "Carlos",
                Apellido = "Ramírez",
                CodigoMed = "MED-1029",
                Telefono = "8888-8888",
                Correo = "carlos.ramirez@clinicacr.com",
                Especialidad = "Medicina General",
                Consultorio = "C-12",
                Activo = true
            };

            return View(mock);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            
            return RedirectToAction(nameof(Index));
        }
    }
}