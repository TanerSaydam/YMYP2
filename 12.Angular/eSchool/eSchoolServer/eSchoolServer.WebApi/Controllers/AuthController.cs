using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSchoolServer.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class AuthController : ControllerBase
{    
    public static string SecretKey = "56a3c02f-36a6-47b0-b981-784c01e7c3e0";

    [HttpGet]
    public IActionResult SignIn(string emailOrUserName)
    {
        if(emailOrUserName != "tanersaydam@gmail.com" &&  emailOrUserName != "taner")
        {
            return BadRequest(new { ErrorMessage = "Kullanıcı bulunamadı!" });
        }

        return Ok(new { Token = SecretKey });
        }
}
