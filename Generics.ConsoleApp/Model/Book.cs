public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }

    public Book(string isbn, string title)
    {
        ISBN = isbn;
        Title = title;
    }
}
