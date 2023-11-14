namespace Server.WebApi.Models;

public sealed class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CoverImageUrl { get; set; }
}