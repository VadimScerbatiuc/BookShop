using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Books
    {
        [Key] //primary key
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]  
        public string Img { get; set; }
        [Required]
        public ushort Price { get; set; }
        
        public string Description { get; set; }

        public bool IsFavorite { get; set; }
        [Required]
        public int GenreId { get; set; }   //foreign key
        public virtual Genre genre { get; set; }
    }
}
