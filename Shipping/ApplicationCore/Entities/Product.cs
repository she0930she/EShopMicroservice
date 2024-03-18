using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class Product
{
    public int Id { get; set; }
    [Column(TypeName="varchar(20)")]
    public string ProductName { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}