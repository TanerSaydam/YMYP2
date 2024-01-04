using eCommerceServer.Context;
using eCommerceServer.Models;
using eCommerceServer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceServer.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class HomeController : ControllerBase
{
    private ProductRepository productRepository;
    public HomeController()
    {
        productRepository = new();
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        IEnumerable<Product> products = productRepository.GetAll();
        
        return Ok(products);
    }
}
