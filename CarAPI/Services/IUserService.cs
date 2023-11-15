using CarAPI.Entities;

namespace CarAPI.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
        Task<User> GetUser(Guid id);
        Task<User> CreateUser(User newUser);
        Task<User> EditUser(User user);
        bool DeleteUser(Guid id);
    }
}
