namespace TodoServer.DTOs;

public record UpdateTodoDto(Guid Id, string Title, bool Completed);