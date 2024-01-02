namespace eCommerceServer.Models;

public sealed class Order
{
    public int Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public DateTime? ExpectedArrival { get; set; }
    public string? CargoCompany { get; set; }
    public string? CargoTrackingNumber { get; set; }
    public int UserId { get; set; }
    public IEnumerable<OrderDetail>? Details { get; set; }
}   
