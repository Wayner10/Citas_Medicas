using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Gestion_de_Citas_Medicas.ViewModels
{
    public class EspecialidadCreateVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(80, ErrorMessage = "Máximo 80 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        public string? Descripcion { get; set; }

        public bool Activa { get; set; } = true;
    }
}