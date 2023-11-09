using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace WebApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class HomeController : ControllerBase
{
    public static List<string> Todos = new() { "Taner", "Ahmet" };

    [HttpGet]
    public IActionResult Get()
    {
        //Todos.Add(name);
        return Ok(Todos);
    }

    [HttpPost]
    public IActionResult Add()
    {
        // Todos.Add(user.Name + " " + user.LastName);
        return Ok(Todos);
    }
}

public class User
{
    public string Name { get; set; }
    public string LastName { get; set; }
}