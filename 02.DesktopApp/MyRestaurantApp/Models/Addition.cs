namespace MyRestaurantApp.Models;
public sealed class Addition
{
    public int Id { get; set; }
    public int TableId { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public decimal Price { get; set; }
    public DateTime AdditionDate { get; set; }
    public bool IsPaid { get; set; }
    public int? ProductVariantId { get; set; }
    public ProductVariant? ProductVariant { get; set; }
}
