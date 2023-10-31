using Microsoft.EntityFrameworkCore;
using MyRestaurantApp.Models;

namespace MyRestaurantApp.Context;

public sealed class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=TUGAY\SQLEXPRESS;Initial Catalog=RestaurantDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Table> Tables { get; set; }
    public DbSet<Addition> Additions { get; set; }
    public DbSet<PaymentHistory> PaymentHistories { get; set; }
    public DbSet<ProductVariant> ProductVariants { get; set; }
}