namespace Server.WebApi.DTOs;

public sealed record TicketCreateDto(
    string Subject,
    string IsUrgent,
    Guid UserId);
