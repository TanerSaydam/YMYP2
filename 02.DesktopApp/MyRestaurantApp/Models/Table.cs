namespace MyRestaurantApp.Models;
public sealed class Table
{
    public int Number { get; set; } //Masa numarası
    public bool IsAvailable { get; set; } //Masa müsait mi
    public bool IsPayment { get; set; } //Ödemesi Yapıldı mı
    public decimal TotalAmount { get; set; } //Toplam Tutarı
    public decimal PaidAmount { get; set; } //Ödenmiş Tutarı
}
