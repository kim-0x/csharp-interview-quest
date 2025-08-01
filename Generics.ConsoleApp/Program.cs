// See https://aka.ms/new-console-template for more information
var book = new Book("1234567890", "C# Programming");

var list = new List();
list.Add(10);
Console.WriteLine(list[0]);

var bookList = new BookList();
bookList.Add(book);
Console.WriteLine(bookList[0].Title);
