namespace eSchoolServer.WebApi.DTOs;

public sealed record AddStudentDto(
    string FirstName,
    string LastName,
    string DateOfBirth,
    IFormFile File);
