namespace eCommerceServer.Models;

public sealed class OrderDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
