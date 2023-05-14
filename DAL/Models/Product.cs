namespace Order.DAL.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public virtual Order Order { get; set; }
    public virtual Category Category { get; set; }
}
