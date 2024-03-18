using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Reviews
{
    [Key]
    public int ReviewId { get; set; }
    public int ProductId { get; set; }
    public string UserId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime Date { get; set; }
}