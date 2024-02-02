using Cubic.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cubic.API.Context;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {}
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("dbo");
        modelBuilder.Entity<Product>()
            .HasKey(p => p.Id);
        modelBuilder.Entity<Product>()
            .Property(p => p.Id)
            .HasColumnName("product_number");
        modelBuilder.Entity<Product>()
           .Property(p => p.ProductName)
           .HasMaxLength(250)
           .HasColumnName("product_name");
        modelBuilder.Entity<Product>()
           .Property(p => p.ExpiryDate)
           .HasColumnType("DATE")
           .HasColumnName("expiry_date");
        modelBuilder.Entity<Product>()
           .Property(p => p.isAvailable)
           .HasDefaultValue(true)
           .HasColumnName("is_available");
    }
}
