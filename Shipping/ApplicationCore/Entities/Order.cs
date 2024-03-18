namespace ApplicationCore.Entities;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; }
    public ICollection<Product> ProductList { get; }
    public decimal TotalPrice { get; }
}