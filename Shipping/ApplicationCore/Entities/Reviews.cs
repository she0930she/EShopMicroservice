namespace ApplicationCore.Entities;

public class Reviews
{
    public int Id { get; set; }
    public string ReviewContent { get; set; }
    public int Rating { get; set; } // 1-5
}