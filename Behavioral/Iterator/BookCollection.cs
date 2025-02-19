public class BookCollection : IAggregate<Book>
{
    private readonly List<Book> _books = new List<Book>();
    public int Count => _books.Count;

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public Book this[int index] => _books[index];

    public IIterator<Book> CreateIterator()
    {
        return new BookIterator(this);
    }
}
