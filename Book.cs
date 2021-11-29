using System;

namespace Books
{

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsCheckedOut { get; set; }
        public void SetBookStatus()
        {
            IsCheckedOut = true;
        }
    }
}
