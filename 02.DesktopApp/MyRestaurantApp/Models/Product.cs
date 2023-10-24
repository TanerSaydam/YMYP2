namespace MyRestaurantApp.Models;
public sealed class Product
{
    public int Id { get; set; }
    public string Name { get; set; } //Ürün Adı
    public decimal Price { get; set; } //Ürün Fiyatı
    public List<ProductVariant> ProductVariants { get; set; } //Ürün Çeşitleri
}
//seeddata // besleme veri

