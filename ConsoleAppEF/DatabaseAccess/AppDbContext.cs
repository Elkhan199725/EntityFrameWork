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
        modelBuilder.Entity<ProductInvoice>()
            .HasKey(pi => new {pi.ProductId, pi.InvoiceId})
            ;
        modelBuilder.Entity<Product>()
            .HasMany(p => p.ProductInvoices)
            .WithOne(pi => pi.Product)
            .HasForeignKey(pi => pi.ProductId)
            ;
        modelBuilder.Entity<Invoice>()
            .HasMany(i => i.ProductInvoices)
            .WithOne(pi => pi.Invoice)
            .HasForeignKey(pi => pi.InvoiceId)
            ;
        modelBuilder.Entity<ProductDetail>()
            .HasKey(pd => pd.Id)
            ;
        modelBuilder.Entity<Product>()
            .HasOne(p => p.ProductDetail)
            .WithOne(pd => pd.Product)
            .HasForeignKey<ProductDetail>(pd => pd.Id)
            ;
        //modelBuilder.Entity<Brand>()
        //    .HasMany(b => b.Products)
        //    .WithOne(p => p.Brand)
        //    .HasForeignKey(p => p.BrandId)
        //    ;
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Brand)
            .WithMany(b => b.Products)
            .HasForeignKey(p => p.BrandId)
            ;
    }

    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Setting> Settings { get; set; } = null!;
    public DbSet<ProductDetail> ProductDetails { get; set; } = null!;
    public DbSet<Brand> Brands { get; set; } = null!;
    public DbSet<Invoice> Invoices { get; set; } = null!;
    public DbSet<ProductInvoice> ProductInvoices { get; set; } = null!;
}
