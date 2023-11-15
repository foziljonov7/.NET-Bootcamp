using CarAPI.Data;
using CarAPI.Entities;
using CarAPI.Service;
using Microsoft.EntityFrameworkCore;

namespace CarAPI.Services
{
    public class CarService : ICarService
    {
        private readonly AppDbContext _dbContext;

        public CarService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Car> CreateCar(Car newCar)
        {
            await _dbContext.Cars.AddAsync(newCar);
            await _dbContext.SaveChangesAsync();
            return newCar;
        }

        public bool DeleteCar(Guid id)
        {
            var car = _dbContext.Cars
                .FirstOrDefault(x => x.Id == id);

            if (car is null)
                return false;

            _dbContext.Cars.Remove(car);
            _dbContext.SaveChanges();
            return true;
        }

        public async Task<Car> EditCar(Car car)
        {
            _dbContext.Cars.Update(car);
            await _dbContext.SaveChangesAsync();
            return car;
        }

        public async Task<Car> GetCar(Guid id)
        {
            var car = await _dbContext.Cars
                .FirstOrDefaultAsync(x => x.Id == id);

            if (car is null)
                return null;

            return car;
        }

        public async Task<List<Car>> GetCars() 
            => await _dbContext.Cars.ToListAsync();
    }
}
