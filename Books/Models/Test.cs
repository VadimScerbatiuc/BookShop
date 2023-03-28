using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class Test
    {
        [Key] //primary key
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Fname { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
