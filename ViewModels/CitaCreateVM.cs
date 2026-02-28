using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Sistema_de_Gestion_de_Citas_Medicas.ViewModels
{
    public class CitaCreateVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El paciente es obligatorio")]
        [Display(Name = "Paciente")]
        public int PacienteId { get; set; }

        [Required(ErrorMessage = "El doctor es obligatorio")]
        [Display(Name = "Doctor")]
        public int DoctorId { get; set; }

        [Required(ErrorMessage = "La especialidad es obligatoria")]
        [Display(Name = "Especialidad")]
        public int EspecialidadId { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La hora es obligatoria")]
        [DataType(DataType.Time)]
        public TimeSpan Hora { get; set; }

        [Required(ErrorMessage = "El motivo es obligatorio")]
        [StringLength(250)]
        public string Motivo { get; set; }

        public bool Activa { get; set; } = true;

        public List<SelectListItem> Pacientes { get; set; } = new();
        public List<SelectListItem> Doctores { get; set; } = new();
        public List<SelectListItem> Especialidades { get; set; } = new();
    }
}