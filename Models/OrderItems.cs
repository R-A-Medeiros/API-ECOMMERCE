namespace APIEcommerce.Models;

public class OrderItems
{
    public int Id { get; set; }
    public int order_id { get; set; }
    public int product_id { get; set; }
    public int quantity { get; set; }
}
