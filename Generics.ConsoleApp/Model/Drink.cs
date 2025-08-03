public class Drink : IEntity
{
    public string Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Drink(string id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}