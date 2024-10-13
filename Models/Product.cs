namespace APIEcommerce.Models;

public class Product
{
    public int product_id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string image_url { get; set; }
    public double price {  get; set; }
    public int stock_quantity {  get; set; }
    public int category_id { get; set; }
    public DateTime created_at { get; set; }

}
