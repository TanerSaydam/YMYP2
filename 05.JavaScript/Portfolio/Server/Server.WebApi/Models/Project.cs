namespace Server.WebApi.Models;

public sealed class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Link { get; set; }
    public string GitHubRepo { get; set; }
    public string CoverImageUrl { get; set; }
}

public sealed class ProjectTechnologies
{
    public int Id { get; set; }
}


//public private protected internal
//access modifier - erişim belirleyecisi