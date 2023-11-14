namespace Server.WebApi.Models;

public sealed class Experience
{
    public Guid Id { get; set; }
    public string Year { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
}
