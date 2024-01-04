using eCommerceServer.Context;
using eCommerceServer.Models;

namespace eCommerceServer.Repositories;

public sealed class ProductRepository
{
    private ApplicationDbContext context;

    public ProductRepository()
    {
        context = new();
    }

    public IEnumerable<Product> GetAll()
    {
        return context.Products.OrderBy(p => p.Name).ToList();
    }
}
