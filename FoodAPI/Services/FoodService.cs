using FoodAPI.Data;
using FoodAPI.Models;

namespace FoodAPI.Services
{
    public class FoodService : IFoodService
    {
        private readonly AppDbContext dbContext;

        public FoodService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<Food> CreateFood(Food newFood)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFood(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Food> GetFood(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Food>> GetFoods()
        {
            throw new NotImplementedException();
        }

        public Task<Food> UpdateFood(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
