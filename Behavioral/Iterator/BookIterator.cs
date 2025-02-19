public class BookIterator : IIterator<Book>
{
    private readonly BookCollection _collection;
    private int _currentIndex = 0;

    public BookIterator(BookCollection collection)
    {
        _collection = collection;
    }

    public bool HasNext()
    {
        return _currentIndex < _collection.Count;
    }

    public Book Next()
    {
        if (HasNext())
        {
            return _collection[_currentIndex++];
        }
        else
        {
            throw new InvalidOperationException("No more elements.");
        }
    }
}
