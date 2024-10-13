namespace APIEcommerce.Models;

public class Order
{
    public int Id { get; set; }
    public int client_id { get; set; }
    public int seller_id { get; set; }
    public string delivery_type { get; set; }
    public string order_status { get; set; }
    public double total_price { get; set; }

}
