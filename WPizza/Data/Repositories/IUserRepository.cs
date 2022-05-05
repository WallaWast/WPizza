using WPizza.Domain.Entities;

namespace WPizza.Data.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsersAsync();

        Task<User?> GetUserByIdAsync(int id);
    }
}
