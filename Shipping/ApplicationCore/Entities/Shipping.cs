namespace ApplicationCore.Entities;

public class Shipping
{
    public int Id { get; set; }
    public string Address { get; set; }
    public int OrderId { get; set; } // 1-5
}