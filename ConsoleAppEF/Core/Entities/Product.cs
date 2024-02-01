namespace ConsoleAppEF.Core.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal? Price { get; set; }
    public ProductDetail? ProductDetail { get; set; }
    public int? BrandId { get; set; }
    public Brand? Brand { get; set; }
    public ICollection<ProductInvoice>? ProductInvoices { get; set; }
}
