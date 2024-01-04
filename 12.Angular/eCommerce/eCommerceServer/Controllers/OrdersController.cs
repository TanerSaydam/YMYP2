using eCommerceServer.Models;
using eCommerceServer.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceServer.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
[Authorize(AuthenticationSchemes ="Bearer")]
public sealed class OrdersController : ControllerBase
{
    private OrderRepository orderRepository;

    public OrdersController()
    {
        orderRepository = new();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        string userIdString = User.Claims.FirstOrDefault(p => p.Type == "UserId")!.Value;
        int userId = int.Parse(userIdString);

        IEnumerable<Order> orders = orderRepository.GetAllByUserId(userId);

        return Ok(orders);
    }
}
