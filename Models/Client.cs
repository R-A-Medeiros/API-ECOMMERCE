namespace APIEcommerce.Models;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string cpf_cnpj { get; set; }
    public string? phone { get; set;}
    public string email { get; set; }
    public string password { get; set; }
    public int street { get; set; }
    public int number { get; set; }
    public string? complement {  get; set; }
    public string  city { get; set; }
    public string state { get; set; }
    public string postal_code { get; set; }
    public string country { get; set; }


}
