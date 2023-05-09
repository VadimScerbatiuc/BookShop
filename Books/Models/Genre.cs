using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        
        [Required(ErrorMessage ="Required field!")]
        [Display(Name = "Introduce genre")]
        [StringLength(200)]
        public string? GenreName { get; set; }

        public List<Book>? Book { get; set; } = new List<Book> { }; //one-to-many 
    }
}
