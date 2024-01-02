using eCommerceServer.Context;
using eCommerceServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerceServer.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public sealed class ShoppingCartsController : ControllerBase
{
    ApplicationDbContext context = new();

    [HttpGet]    
    public IActionResult GetAll()
    {
        string userIdString = User.Claims.Single(s => s.Type == "UserId").Value;
        int userId = int.Parse(userIdString);
                
        List<ShoppingCart> carts = context.ShoppingCarts.Where(p => p.UserId == userId).Include(p => p.Product).ToList();

        return Ok(carts);
    }

    [HttpGet]
    public IActionResult Increment(int productId)
    {
        string userIdString = User.Claims.Single(s => s.Type == "UserId").Value;
        int userId = int.Parse(userIdString);

        ShoppingCart? shoppingCart = context.ShoppingCarts.Where(p => p.UserId == userId && p.ProductId == productId).FirstOrDefault();

        if (shoppingCart is null)
        {
            shoppingCart = new()
            {
                ProductId = productId,
                UserId = userId,
                Quantity = 1
            };
            context.Add(shoppingCart);
        }
        else
        {
            shoppingCart.Quantity++;
        }

        context.SaveChanges();

        return NoContent();
    }

    [HttpGet]
    public IActionResult Decrement(int productId)
    {
        string userIdString = User.Claims.Single(s => s.Type == "UserId").Value;
        int userId = int.Parse(userIdString);

        ShoppingCart? shoppingCart = context.ShoppingCarts.Where(p => p.UserId == userId && p.ProductId == productId).FirstOrDefault();
        if (shoppingCart is not null)
        {
            shoppingCart.Quantity--;

            if (shoppingCart.Quantity == 0)
            {
                context.Remove(shoppingCart);
            }
            context.SaveChanges();
        }

        return NoContent();
    }

    [HttpGet]
    public IActionResult RemoveById(int id)
    {
        ShoppingCart? shoppingCart = context.ShoppingCarts.Find(id);
        if (shoppingCart is not null)
        {
            context.Remove(shoppingCart);
            context.SaveChanges();
        }

        return NoContent();
    }

    [HttpGet]
    public IActionResult Pay()
    {
        string userIdString = User.Claims.Single(s => s.Type == "UserId").Value;
        int userId = int.Parse(userIdString);

        List<ShoppingCart> carts = context.ShoppingCarts.Where(p=> p.UserId == userId).Include(p=> p.Product).ToList();

        Order order = new()
        {
            Number = Guid.NewGuid().ToString(),
            Date = DateTime.Now,
            UserId = userId,
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

        context.Add(order);
        context.RemoveRange(carts);

        context.SaveChanges();
        return NoContent();
    }
}
    
