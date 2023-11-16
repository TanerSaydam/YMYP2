using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.WebApi.Context;

namespace Server.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetSkills()
    {
        var response = _context.Skills.OrderBy(p=> p.Order).ToList(); //select * from Skills
        return Ok(response);
    }

    [HttpGet]
    public IActionResult GetProjects()
    {
        var response = _context.Projects.ToList();
        return Ok(response);
    }

    [HttpGet]
    public IActionResult GetExperiences()
    {
        var response = _context.Experiences.ToList();
        return Ok(response);
    }

    [HttpGet]
    public IActionResult GetSocialMedias()
    {
        var response = _context.SocialMedias.ToList();
        return Ok(response);
    }
}
