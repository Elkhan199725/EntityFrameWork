namespace ConsoleAppEF.Core.Entities;

public class Invoice
{
    public int Id { get; set; }
    public DateTime CreatedTime { get; set; }
    public decimal TotalPrice { get; set; }
    public ICollection<ProductInvoice>? ProductInvoices { get; set; }
}
