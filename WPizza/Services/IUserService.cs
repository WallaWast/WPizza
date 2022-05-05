using WPizza.Domain.Entities;

namespace WPizza.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();

        Task<User?> GetUserByIdAsync(int id);
    }
}
