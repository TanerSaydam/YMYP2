namespace Server.WebApi.DTOs;

public sealed record LoginResponseDto(
    string AccessToken,
    Guid UserId);