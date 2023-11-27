using FoodAPI.Data;
using FoodAPI.Dtos;
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

        public async Task<Food> CreateFood(CreateFoodDto newFood)
        {
            var food = dbContext.Foods.Add(new Food
            {
                Id = Guid.NewGuid(),
                Name = newFood.Name,
                Price = newFood.Price,
                Description = newFood.Description,
                CategoryId = newFood.CategoryId
            });

            await dbContext.SaveChangesAsync();
            return await Task.FromResult(food.Entity);
        }

        public bool DeleteFood(Guid id)
        {
            var food = dbContext.Foods
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

        public async Task<Food> UpdateFood(Guid id, UpdateFoodDto food)
        {
            var updated = await dbContext.Foods
                .FirstOrDefaultAsync(f => f.Id == id);

            if (updated is null)
                return null;

            updated.Name = food.Name;
            updated.Price = food.Price;
            updated.Description = food.Description;
            updated.CategoryId = food.CategoryId;

            await dbContext.SaveChangesAsync();
            return updated;
        }
    } 
}
