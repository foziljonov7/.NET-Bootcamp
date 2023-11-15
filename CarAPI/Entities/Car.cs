using System.ComponentModel.DataAnnotations;

namespace CarAPI.Entities
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Car model is required")]
        [MaxLength(50)]
        public string Model { get; set; }
        [Required]
        public string Color { get; set; }
        [Required(ErrorMessage = "Car year is required")]
        public string Year { get; set; }
        [Required]
        public double Probeg { get; set; }
    }
}
