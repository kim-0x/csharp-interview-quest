// See https://aka.ms/new-console-template for more information
var book = new Book("1234567890", "C# Programming");

var bookDictionary = new GenericDictionary<string, Book>();
bookDictionary.Add("122222", book);

Console.WriteLine($"Book added with ISBN: {bookDictionary["122222"].ISBN} and Title: {bookDictionary["122222"].Title}");
// Output: Book added with ISBN: 1234567890 and Title: C# Programming