using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppEF.Core.Entities;

public class ProductInvoice
{
    //public int Id { get; set; }
    //[Key,ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    //[Key,ForeignKey(nameof(Invoice))]
    public int InvoiceId { get; set; }
    public decimal Counting { get; set; }
    public Product? Product { get; set; }
    public Invoice? Invoice { get; set; }
}
