using FoodAPI.Models;

namespace FoodAPI.Dtos
{
    public class GetFoodsDto
    {
        public GetFoodsDto(Food entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Price = entity.Price;
            Description = entity.Description;
            CategoryId = entity.CategoryId;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
