namespace Server.WebApi.DTOs;

public sealed record RegisterDto(
    string Name,
    string LastName,
    string Username,
    string Email,
    string Password);
