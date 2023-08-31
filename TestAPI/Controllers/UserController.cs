using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBackend.Models;
using TestBackend.Services;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("User")]
        public User AddUser(User user)
        {
            _userService.AddUser(user);
            return user;
        }

        [HttpGet()]
        public List<User> GetAllUsers()
        {
            return _userService.GetUsers();
        }

        [HttpDelete("Id")]
        public void DeleteUser(Guid Id)
        {
            _userService.DeleteUser(Id);
        }

        [HttpPut("user")]
        public void UpdateUser(User user)
        {
            _userService.UpdateUser(user);
        }
    }
}
