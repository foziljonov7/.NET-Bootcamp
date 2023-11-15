using CarAPI.Data;
using CarAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarAPI.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _dbContext;

        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<User> CreateUser(User newUser)
        {
            await _dbContext.Users.AddAsync(newUser);
            await _dbContext.SaveChangesAsync();
            return newUser;
        }

        public bool DeleteUser(Guid id)
        {
            var user = _dbContext.Users
                .FirstOrDefault(x => x.Id == id);

            if (user is null)
                return false;

            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
            return true;
        }

        public async Task<User> EditUser(User user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<User> GetUser(Guid id)
        {
            var user = await _dbContext.Users
                .FirstOrDefaultAsync(x => x.Id == id);
            if (user is null)
                return null;
            return user;
        }

        public async Task<List<User>> GetUsers()
            => await _dbContext.Users.ToListAsync();
    }
}
