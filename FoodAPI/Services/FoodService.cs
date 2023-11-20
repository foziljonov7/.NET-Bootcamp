using FoodAPI.Data;
using FoodAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.Services
{
    public class FoodService : IFoodService
    {
        private readonly AppDbContext dbContext;

        public FoodService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Food> CreateFood(Food newFood)
        {
            await dbContext.Foods.AddAsync(newFood);
            await dbContext.SaveChangesAsync();
            return newFood;
        }

        public bool DeleteFood(Guid id)
        {
            var food =dbContext.Foods
                .FirstOrDefault(f => f.Id == id);

            if (food is null)
                return false;

            dbContext.Foods.Remove(food);
            dbContext.SaveChanges();
            return true;
        }

        public async Task<Food> GetFood(Guid id)
        {
            var food = await dbContext.Foods
                .FirstOrDefaultAsync(f => f.Id == id);

            if (food is null)
                return null;

            return food;
        }

        public async Task<List<Food>> GetFoods()
            => await dbContext.Foods.ToListAsync();
        public async Task<Food> UpdateFood(Food food)
        {
            dbContext.Foods.Update(food);
            await dbContext.SaveChangesAsync();
            return food;
        }
    }
}
