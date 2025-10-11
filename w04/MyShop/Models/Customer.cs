namespace MyShop.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Adress { get; set; } = string.Empty;
    
    //Navigation property

    public virtual List<Order>? Orders { get; set; }
}