public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name)
    {
        Name = name;
    }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}