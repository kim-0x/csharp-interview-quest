// See https://aka.ms/new-console-template for more information

var productRepository = new EntityRepository<Product>();
productRepository.Add(new Product("Laptop", 1200));
productRepository.Add(new Product("Mouse", 25));

foreach (var product in productRepository.GetAll())
{
    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
}

var drinkRepository = new EntityRepository<IEntity>();
drinkRepository.Add(new Drink("1", "Coke", 1.5m));
drinkRepository.Add(new Drink("2", "Pepsi", 1.2m));

foreach (var entity in drinkRepository.GetAll())
{
    var drink = entity as Drink;
    if (drink == null)
    {
        Console.WriteLine("Entity is not a Drink.");
        continue;
    }
    Console.WriteLine($"Drink: {drink.Name}, Price: {drink.Price}");
}

var evenNumberRepository = new EntityRepository<int[]>();
evenNumberRepository.Add(new int[] { 2, 4, 6 });
evenNumberRepository.Add(new int[] { 8, 10 });

foreach (var numbers in evenNumberRepository.GetAll())
{
    Console.WriteLine("Even Numbers: " + string.Join(", ", numbers));
}


/*
// Example of using EntityRepository with a value type (int)
// This will not compile because int is a value type and does not meet the class constraint.

var intRepository = new EntityRepository<int>();
intRepository.Add(42);
intRepository.Add(100);
foreach (var number in intRepository.GetAll())
{
    Console.WriteLine($"Number: {number}");
} */