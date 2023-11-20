using FoodAPI.Models;

namespace FoodAPI.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategorys();
        Task<Category> GetCategory(int id);
        Task<List<Food>> GetFoodCategorys(int id);
    }
}
