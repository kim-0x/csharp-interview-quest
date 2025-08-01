// See https://aka.ms/new-console-template for more information

// Example of using a generic class constraint with Product
var tv = new Product("Samsung TV", 500.00m);
Console.WriteLine(ProductHelper.Discount(tv)); // Outputs: 50, since the price is greater than 100

// Example of using a generic class constraint with Book
// Book is derived from Product, so it can use the same helper
var book = new Book("123-456-789", "C# Programming", 29.99m);
Console.WriteLine(ProductHelper.Discount<Book>(book)); // Outputs: 0, since the price is not greater than 100

var book2 = new Book("987-654-321", "Advanced C#", 150.00m);
Console.WriteLine(ProductHelper.Discount<Book>(book2)); // Outputs: 15, since the price is greater than 100

var book3 = new Book("111-222-333", "C# Design Patterns", 120.00m);
// Compiler smart enought to infer the type
Console.WriteLine(ProductHelper.Discount(book3)); // Outputs: 12, since the price is greater than 100
//book3.Discount(); // This will also work, as Discount is an extension method