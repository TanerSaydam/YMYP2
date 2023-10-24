namespace MyRestaurantApp.Models;
public sealed class PaymentHistory
{
    public int Id { get; set; }
    public int TableId { get; set; }
    public Table Table { get; set; }
    public DateTime PaymentDate { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public decimal Price { get; set; }
    public int? ProductVariantId { get; set; }
    public ProductVariant? ProductVariant { get; set; }
}
