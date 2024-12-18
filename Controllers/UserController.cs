using IdentityX.Dto;
using IdentityX.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IdentityX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController:Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService){
            _userService=userService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDto registerUserDto){
            await _userService.RegisterUserAsync(registerUserDto);
            return Ok("User registered successfully. Please check your email for confirmation.");
        }
    }
}