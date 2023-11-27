using FoodAPI.Dtos;
using FoodAPI.Models;

namespace FoodAPI.Services
{
    public interface IFoodService
    {
        Task<List<Food>> GetFoods();
        Task<Food> GetFood(Guid id);
        Task<Food> CreateFood(CreateFoodDto newFood);
        Task<Food> UpdateFood(Guid id, UpdateFoodDto food);
        bool DeleteFood(Guid id);
    }
}
