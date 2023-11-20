using System.ComponentModel.DataAnnotations;

namespace FoodAPI.Models
{
    public class Food
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
