using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_jwt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class SecureController : ControllerBase
    {
        [HttpGet("admin")]
        [Authorize(Policy = "Admin")]
        public IActionResult AdminOnly()
        {
            return Ok("Este endpoint � acess�vel apenas por admin.");
        }

        [HttpGet("user")]
        [Authorize]
        public IActionResult AnyUser()
        {
            return Ok("Este endpoint � acess�vel por qualquer usu�rio.");
        }
    }
}
