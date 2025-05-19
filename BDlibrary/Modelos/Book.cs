using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDlibrary.Modelos
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "El año de publicación es obligatoria.")]
        public DateTime? YearPublished { get; set; }

        [ForeignKey("AuthorId")]
        public int? AuthorId { get; set; }
    }
}
