using Microsoft.AspNetCore.Mvc;
using Server.WebApi.DTOs;
using Server.WebApi.Services;

namespace Server.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost]
    public IActionResult Register(RegisterDto request)
    {
        _authService.Register(request);

        return NoContent();
    }

    [HttpPost]
    public IActionResult Login(LoginDto request)
    {
        var response = _authService.Login(request);
        return Ok(response);
    }
}
