using FoodAPI.Data;
using FoodAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext dbContext;

        public CategoryService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Category> GetCategory(int id)
        {
            var category = await dbContext.Categorys
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category is null)
                return null;

            return category;
        }

        public async Task<List<Category>> GetCategorys()
            => await dbContext.Categorys.ToListAsync();

        public async Task<List<Food>> GetFoodCategorys(int id)
        {
            var foodCategory = await dbContext.Foods
                .Where(f => f.CategoryId == id)
                .ToListAsync();

            if (foodCategory is null)
                return null;

            return foodCategory;
        }
    }
}
