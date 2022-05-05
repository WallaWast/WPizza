using WPizza.Domain.Dto;

namespace WPizza.Services
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersAsync();

        Task<UserDto?> GetUserByIdAsync(int id);
    }
}
