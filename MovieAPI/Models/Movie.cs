using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class Movie
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required"), MaxLength(60)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Genre is required"), MaxLength(60)]
        public string Genre { get; set; }
        [Required(ErrorMessage = "Director  is required")]
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
