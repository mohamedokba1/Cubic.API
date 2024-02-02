namespace Cubic.API.Models;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public bool? isAvailable { get; set; }
}
