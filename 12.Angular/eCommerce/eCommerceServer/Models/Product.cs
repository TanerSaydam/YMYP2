namespace eCommerceServer.Models;

public sealed class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string CoverImageUrl { get; set; } = string.Empty;
}
