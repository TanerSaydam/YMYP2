namespace eCommerceServer.Models;

public class ShoppingCart
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int Quantity { get; set; }
    public int UserId { get; set; }
    public AppUser? User { get; set; }
}
