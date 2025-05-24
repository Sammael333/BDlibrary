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

        [Required(ErrorMessage = "El año de publicación es obligatorio.")]
        [Range(1000, 9999, ErrorMessage = "Debe ser un año válido de 4 dígitos.")]
        public int YearPublished { get; set; }

        [ForeignKey("AuthorId")]
        public int? AuthorId { get; set; }
        virtual public Author? Author { get; set; }
    }
}
