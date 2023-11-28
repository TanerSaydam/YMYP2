using Microsoft.EntityFrameworkCore;
using Server.WebApi.Models;

namespace Server.WebApi.Context;

public sealed class ApplicationDbContext : DbContext
{  
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
}
