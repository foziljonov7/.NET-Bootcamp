using CarAPI.Entities;

namespace CarAPI.Service
{
    public interface ICarService
    {
        Task<List<Car>> GetCars();
        Task<Car> GetCar(Guid id);
        Task<Car> CreateCar(Car newCar);
        Task<Car> EditCar(Car car);
        bool DeleteCar(Guid id);
    }
}
