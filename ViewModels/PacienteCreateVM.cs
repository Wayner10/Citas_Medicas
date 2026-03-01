using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Gestion_de_Citas_Medicas.ViewModels
{
    public class PacienteCreateVM
    {
        public int Id { get; set; }   

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(50)]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "La cédula es obligatoria")]
        [StringLength(20)]
        public string? Cedula { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [StringLength(20)]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }

        public bool Activo { get; set; } = true;
    }
}