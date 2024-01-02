using eCommerceServer.Context;
using eCommerceServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceServer.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts()
    {
        ApplicationDbContext context = new();
        IEnumerable<Product> products = context.Products.OrderBy(p=> p.Name).ToList();
        
        return Ok(products);
    }
}
