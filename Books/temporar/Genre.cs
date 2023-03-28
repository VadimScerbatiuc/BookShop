using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Books> books { get; set; }
    }
}
