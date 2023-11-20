using FoodAPI.Models;

namespace FoodAPI.Services
{
    public interface IFoodService
    {
        Task<List<Food>> GetFoods();
        Task<Food> GetFood(Guid id);
        Task<Food> CreateFood(Food newFood);
        Task<Food> UpdateFood(Food food);
        bool DeleteFood(Guid id);
    }
}
