namespace eSchoolServer.WebApi.Models;

public sealed class Student
{
    public int Id { get; set; }
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public string Image { get; set; } = string.Empty;
}
