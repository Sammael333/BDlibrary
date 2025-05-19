using System.ComponentModel.DataAnnotations;

namespace BDlibrary.Modelos
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        public DateTime? BirthDate {  get; set; }
        [Required(ErrorMessage = "La nacionalidad es obligatoria")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nacionalidad { get; set; }

    }
}
