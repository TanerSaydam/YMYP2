namespace Server.WebApi.Models;

public sealed class Ticket
{
    public Guid Id { get; set; }
    public string Subject { get; set; } = string.Empty;
    public string IsUrgent { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public Guid UserId { get; set; }
}
