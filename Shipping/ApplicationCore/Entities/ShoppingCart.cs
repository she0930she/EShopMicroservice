namespace ApplicationCore.Entities;

public class ShoppingCart
{
    public ICollection<Product> ListProducts { get; set; }
}