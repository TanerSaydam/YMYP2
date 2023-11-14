using Microsoft.EntityFrameworkCore;
using Server.WebApi.Models;

namespace Server.WebApi.Context;

public sealed class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-3BJ5GK9\\SQLEXPRESS;Initial Catalog=PortfolioDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Skill> Skills { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Experience>()
            .HasData(GetExperiencesSeedData());

        modelBuilder.Entity<Project>()
            .HasData(GetProjectsSeedData());

        modelBuilder.Entity<Skill>()
            .Property(p => p.Image)
            .IsRequired(false);

        modelBuilder.Entity<Skill>()
            .HasData(GetSkillsSeedData());
    }

    private List<Skill> GetSkillsSeedData()
    {
        List<Skill> skills = new();
        Skill skill1 = new()
        {
            Id = Guid.NewGuid(),
            Image = null,
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/2048px-.NET_Core_Logo.svg.png",
            Order = 1
        };
        skills.Add(skill1);

        Skill skill2 = new()
        {
            Id = Guid.NewGuid(),
            Image = null,
            ImageUrl = "https://blog.ninja-squad.com/assets/images/angular_gradient.png",
            Order = 2
        };
        skills.Add(skill2);

        Skill skill3 = new()
        {
            Id = Guid.NewGuid(),
            Image = null,
            ImageUrl = "https://pluralsight2.imgix.net/paths/images/domain-driven-design-6d10f953a0.png",
            Order = 3
        };
        skills.Add(skill3);

        Skill skill4 = new()
        {
            Id = Guid.NewGuid(),
            Image = null,
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ea/Docker_%28container_engine%29_logo_%28cropped%29.png",
            Order = 4
        };
        skills.Add(skill4);

        return skills;
    }

    private List<Project> GetProjectsSeedData()
    {
        List<Project> projects = new();
        Project project1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "e-Muhasebe Projesi",
            CoverImageUrl = "project1.png"
        };
        projects.Add(project1);

        Project project2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "e-Finans Projesi",
            CoverImageUrl = "project2.png"
        };
        projects.Add(project2);

        Project project3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "My Portfolio Projesi",
            CoverImageUrl = "project3.png"
        };
        projects.Add(project3);

        return projects;
    }

    private List<Experience> GetExperiencesSeedData()
    {
        List<Experience> experiences = new();
        Experience experience1 = new()
        {
            Id = Guid.NewGuid(),
            Date = "09.2011 - 08.2013",
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur ex sit amet massa scelerisque scelerisque. Aliquam erat volutpat. Aenean interdum finibus efficitur. Praesent dapibus dolor felis, eu ultrices elit molestie.",
            Title = "Visual Art &amp; Design",
            Year = "2 Years"
        };
        experiences.Add(experience1);

        Experience experience2 = new()
        {
            Id = Guid.NewGuid(),
            Date = "09.2011 - 08.2013",
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur ex sit amet massa scelerisque scelerisque. Aliquam erat volutpat. Aenean interdum finibus efficitur. Praesent dapibus dolor felis, eu ultrices elit molestie.",
            Title = "Visual Art &amp; Design",
            Year = "2 Years"
        };
        experiences.Add(experience2);

        return experiences;
    }
}
