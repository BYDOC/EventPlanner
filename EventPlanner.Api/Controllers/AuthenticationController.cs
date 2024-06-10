using EventPlanner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace EventPlanner.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        // Register the user
        return Ok(request);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        // Register the user
        return Ok(request);
    }


}