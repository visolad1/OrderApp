namespace Order.DAL.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderTime { get; set; }
    public virtual IList<Product> Products { get; set; } = new List<Product>();
}
