using eCommerceServer.Context;
using eCommerceServer.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceServer.Repositories;

public sealed class OrderRepository
{
    private ApplicationDbContext context;
    public OrderRepository()
    {
        context = new();
    }

    public IEnumerable<Order> GetAllByUserId(int userId)
    {
        return 
            context.Orders
            .Where(p=> p.UserId == userId)
            .Include(p=> p.Details)!
            .ThenInclude(p=> p.Product)
            .OrderByDescending(p=> p.Id)
            .ToList();
    }

    public void Add(Order order)
    {
        context.Orders.Add(order);
        context.SaveChanges();
    }
}
