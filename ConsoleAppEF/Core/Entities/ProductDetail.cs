using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppEF.Core.Entities;

public class ProductDetail
{
    //[Key, ForeignKey(nameof(Product))]
    public int Id { get; set; }
    public string? Description { get; set; }
    //public int ProductId { get; set; } //unnecessary here bc Id can be both key and foreign
    public Product? Product { get; set; }
}
