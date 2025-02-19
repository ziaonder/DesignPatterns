namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCollection bookCollection = new BookCollection();
            bookCollection.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
            bookCollection.AddBook(new Book("1984", "George Orwell"));
            bookCollection.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
            bookCollection.AddBook(new Book("Moby-Dick", "Herman Melville"));

            IIterator<Book> iterator = bookCollection.CreateIterator();

            Console.WriteLine("Books in the collection:");
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
