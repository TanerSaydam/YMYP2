using eCommerceServer.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceServer.Context;

public sealed class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=TANER\\SQLEXPRESS;Initial Catalog=eCommerceDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<AppUser> Users { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppUser>().HasIndex(x => x.Email).IsUnique(true);

        modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("money");
        modelBuilder.Entity<Product>().HasIndex(x=> x.Name).IsUnique();

        List<Product> products = new();
        Product product1 = new()
        {
            Id = 1,
            Name = "Elma",
            Price = 20,
            CoverImageUrl = "elma.png"
        };
        products.Add(product1);

        Product product2 = new()
        {
            Id = 2,
            Name = "Armut",
            Price = 30,
            CoverImageUrl = "armut.png"
        };
        products.Add(product2);

        Product product3 = new()
        {
            Id = 3,
            Name = "Karpuz",
            Price = 120,
            CoverImageUrl = "karpuz.png"
        };
        products.Add(product3);

        Product product4 = new()
        {
            Id = 4,
            Name = "Muz",
            Price = 50,
            CoverImageUrl = "muz.png"
        };
        products.Add(product4);

        modelBuilder.Entity<Product>().HasData(products);
    }
}