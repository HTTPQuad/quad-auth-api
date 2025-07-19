using Microsoft.AspNetCore.Mvc;

namespace QuadAuthApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("signup")]
        public IActionResult Signup()
        {
            return Ok(new { message = "User signed up successfully (mock)" });
        }

        [HttpPost("login")]
        public IActionResult Login()
        {
            return Ok(new { message = "User logged in successfully (mock)" });
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            return Ok(new { message = "User logged out successfully (mock)" });
        }
    }
}
