using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Gestion_de_Citas_Medicas.Models
{
    public class DoctorCreateVM
    {
        public int DoctorId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(60, ErrorMessage = "Máximo 60 caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(60, ErrorMessage = "Máximo 60 caracteres")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "El código médico es obligatorio")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres")]
        [Display(Name = "Código Médico")]
        public string CodigoMed { get; set; } = string.Empty;

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Phone(ErrorMessage = "Formato de teléfono inválido")]
        [StringLength(20)]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        [StringLength(120)]
        [Display(Name = "Correo Electrónico")]
        public string Correo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La especialidad es obligatoria")]
        [StringLength(80)]
        [Display(Name = "Especialidad")]
        public string Especialidad { get; set; } = "Medicina General";

        [StringLength(20)]
        [Display(Name = "Consultorio")]
        public string? Consultorio { get; set; }

        [Display(Name = "Activo")]
        public bool Activo { get; set; } = true;
    }
}