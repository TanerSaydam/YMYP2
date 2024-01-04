using eCommerceServer.Models;
using eCommerceServer.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceServer.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public sealed class ShoppingCartsController : ControllerBase
{
    private ShoppingCartReposiyory shoppingCartReposiyory;
    private OrderRepository orderRepository;
    public ShoppingCartsController()
    {
        shoppingCartReposiyory = new();
        orderRepository = new();
    }

    [HttpGet]    
    public IActionResult GetAll()
    {
        string userIdString = User.Claims.Single(s => s.Type == "UserId").Value;
        int userId = int.Parse(userIdString);
                
        IEnumerable<ShoppingCart> carts = shoppingCartReposiyory.GetAllByUserId(userId);

        return Ok(carts);
    }

    [HttpGet]
    public IActionResult Increment(int productId)
    {
        string userIdString = User.Claims.Single(s => s.Type == "UserId").Value;
        int userId = int.Parse(userIdString);

        ShoppingCart? shoppingCart = shoppingCartReposiyory.GetByUserIdAndProductId(userId, productId);

        if (shoppingCart is null)
        {
            shoppingCart = new()
            {
                ProductId = productId,
                UserId = userId,
                Quantity = 1
            };
            shoppingCartReposiyory.Add(shoppingCart);
        }
        else
        {
            shoppingCart.Quantity++;
            shoppingCartReposiyory.Update(shoppingCart);
        }

        return NoContent();
    }

    [HttpGet]
    public IActionResult Decrement(int productId)
    {
        string userIdString = User.Claims.Single(s => s.Type == "UserId").Value;
        int userId = int.Parse(userIdString);

        ShoppingCart? shoppingCart = shoppingCartReposiyory.GetByUserIdAndProductId(userId, productId);
        if (shoppingCart is not null)
        {
            shoppingCart.Quantity--;

            if (shoppingCart.Quantity == 0)
            {
                shoppingCartReposiyory.Remove(shoppingCart);
            }
            else
            {
                shoppingCartReposiyory.Update(shoppingCart);
            }            
        }

        return NoContent();
    }

    [HttpGet]
    public IActionResult RemoveById(int id)
    {
        ShoppingCart? shoppingCart = shoppingCartReposiyory.GetById(id);
        if (shoppingCart is not null)
        {
            shoppingCartReposiyory.Remove(shoppingCart);
        }

        return NoContent();
    }

    [HttpGet]
    public IActionResult Pay()
    {
        string userIdString = User.Claims.Single(s => s.Type == "UserId").Value;
        int userId = int.Parse(userIdString);

        IEnumerable<ShoppingCart> carts = shoppingCartReposiyory.GetAllByUserId(userId);

        Order order = new()
        {
            Number = Guid.NewGuid().ToString(),
            Date = DateTime.Now,
            UserId = userId
        };

        List<OrderDetail> details = new List<OrderDetail>();

        foreach (var cart in carts)
        {
            OrderDetail orderDetail = new()
            {
                Price = cart.Product!.Price,
                Quantity = cart.Quantity,
                ProductId = cart.ProductId,
            };

            details.Add(orderDetail);
        }

        order.Details = details;

        orderRepository.Add(order);
        shoppingCartReposiyory.RemoveRange(carts);

        return NoContent();
    }
}
    
