// See https://aka.ms/new-console-template for more information
var book = new Book("1234567890", "C# Programming");

var list = new GenericList<int>();
list.Add(10);
Console.WriteLine(list[0]); // Output: 10

var bookList = new GenericList<Book>();
bookList.Add(book);
Console.WriteLine(bookList[0].Title); // Output: C# Programming
