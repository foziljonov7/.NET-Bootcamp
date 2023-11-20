using FoodAPI.Data;
using FoodAPI.Models;

namespace FoodAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext dbContext;

        public CategoryService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<Category> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetCategorys()
        {
            throw new NotImplementedException();
        }

        public Task<List<Food>> GetFoodCategorys(int id)
        {
            throw new NotImplementedException();
        }
    }
}
