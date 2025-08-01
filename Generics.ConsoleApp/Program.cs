// See https://aka.ms/new-console-template for more information
var book = new Book("1234567890", "C# Programming");

var list = new ObjectList();
list.Add(10);
Console.WriteLine(list[0]); // Output: 10

list.Add(book);
var unboxBook = list[1] as Book;
Console.WriteLine(unboxBook?.Title); // Output: C# Programming

