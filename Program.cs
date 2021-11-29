using System;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book()
            {
                Name = "Watchmen",
                Author = "Alan Moore"
            };

            book.SetBookStatus();

            Console.WriteLine(book.Name + " " + book.Author);
            Console.WriteLine(book.IsCheckedOut);
        }
    }
}
