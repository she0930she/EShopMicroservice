using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Shipping
{
    [Key]
    public int ShipperId { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string Phone { get; set; }
}