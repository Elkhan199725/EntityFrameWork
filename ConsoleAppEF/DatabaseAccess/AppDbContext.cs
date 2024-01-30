using ConsoleAppEF.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppEF.DatabaseAccess;

public class AppDbContext:DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=ELKHAN-HOME\SQLEXPRESS;Database=P238EF;Trusted_Connection=true;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductDetail>()
            .HasKey(pd => pd.Id)
            ;
        modelBuilder.Entity<Product>()
            .HasOne(p => p.ProductDetail)
            .WithOne(pd => pd.Product)
            .HasForeignKey<ProductDetail>(pd => pd.Id)
            ;
    }

    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Setting> Settings { get; set; } = null!;
    public DbSet<ProductDetail> ProductDetails { get; set; } = null!;
}
