using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ValuesController : ControllerBase
{

    [HttpGet]
    public IActionResult GetAll()
    {
        var result = HttpContext.Request.Headers.Where(p=> p.Key == "secretkey").FirstOrDefault().Value;

        if(result != "Taner Saydam")
        {
            return StatusCode(401);
        }

        List<string> names = new();
        for (int i = 0; i < 100; i++)
        {
            names.Add("Name " + i);
        }

        return Ok(names);
    }
}
