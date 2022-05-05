using Microsoft.AspNetCore.Mvc;
using WPizza.Domain.Dto;
using WPizza.Services;

namespace WPizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<UserDto>> Get()
        {
            return await _userService.GetAllUsersAsync();
        }
    }
}