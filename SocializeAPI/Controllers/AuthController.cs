using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Socialize.DataAccess.Repositories;
using Socialize.DataAccess.Repositories.IRepositories;
using Socialize.Models;

namespace SocializeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public AuthController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _userRepository = new UserRepository(signInManager, userManager);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(User user)
        {
            var result = await _userRepository.Register(user);
            if (result.Succeeded)
                return Ok(new { Message = "User created successfully!" });
            return Ok(result);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(User user)
        {
            var result = await _userRepository.Login(user);
            if (result.Succeeded)
                return Ok(new { Message = "Login successfully!" });
            return Ok(new { Message = "wrong credintials!" });
        }
    }
}
