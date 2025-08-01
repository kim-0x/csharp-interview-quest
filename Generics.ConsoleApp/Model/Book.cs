public class Book : Product
{
    public string ISBN { get; set; }
    public string Title { get; set; }

    public Book(string isbn, string title) : base(title)
    {
        ISBN = isbn;
        Title = title;
    }

    public Book(string isbn, string title, decimal price) : base(title, price)
    {
        ISBN = isbn;
        Title = title;
    }
}
