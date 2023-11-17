using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Models
{
    public class Food
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Food name is required!")]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Food price is required!")]
        public double Price { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
    }
}
