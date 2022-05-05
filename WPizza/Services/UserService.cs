using WPizza.Data.Repositories;
using WPizza.Domain.Dto;

namespace WPizza.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllUsersAsync();

            return users.Select(x => new UserDto()
            {
                Id = x.Id,
                Name = x.Name,
                Phone = x.Phone,
                Address = x.Address
            }).ToList();
        }

        public async Task<UserDto?> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);

            if (user == null)
                return null;

            var userDto = new UserDto()
            {
                Id = user.Id,
                Name = user.Name,
                Address = user.Address,
                Phone = user.Phone
            };

            return userDto;
        }
    }
}
