using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Books
    {
        [Key] //primary key
        public int Id { get; set; }

        [Required(ErrorMessage = "Required field!")]
        [Display(Name = "Introduce book title")]
        [StringLength(200)]
        public string? BookName { get; set; }

        [Required(ErrorMessage = "Required field!")]
        [Display(Name = "Introduce book author")]
        [StringLength(200)]
        public string? Author { get; set; }

        [DefaultValue("https://pngimg.com/uploads/book/book_PNG50990.png")]
        public string? Img { get; set; }

        [Required(ErrorMessage = "Required field!")]
        [Display(Name = "Introduce book price")]
        [Range(50,1000)]
        public ushort Price { get; set; }

        [StringLength(5000)]
        public string? Description { get; set; }

        [DefaultValue("false")]
        public bool IsFavorite { get; set; }
        

        public int GenreId { get; set; }   //foreign key
        public virtual Genre? genre { get; set; }   
    }
}
