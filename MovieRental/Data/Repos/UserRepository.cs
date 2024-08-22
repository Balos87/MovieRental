using MovieRental.Data.Repos.IRepos;
using MovieRental.Models;

namespace MovieRental.Data.Repos
{
    public class UserRepository : IUserRepository
    {
        private readonly MovieRentalContext _context;

        public UserRepository(MovieRentalContext context)
        {
            _context = context;
        }
        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public Task DeleteUserAsync(int userId)
        {
            var user = _context.Users.Find(userId);
            _context.Users.Remove(user);
            return _context.SaveChangesAsync();
        }

        public Task<IEnumerable<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
