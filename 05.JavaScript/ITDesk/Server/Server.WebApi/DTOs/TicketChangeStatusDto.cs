namespace Server.WebApi.DTOs;

public sealed record TicketChangeStatusDto(
    Guid Id,
    string Status);
