namespace Server.WebApi.Models;

public sealed class SocialMedia
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Link { get; set; }
}
