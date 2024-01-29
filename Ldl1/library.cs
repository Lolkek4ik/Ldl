
namespace Ldl1
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string ISBN;

        public Book(string title, string author, string iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }
    }

    internal class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }
        //======================ADD==============================ADD===============================ADD=============================
        public void AddBook()
        {
            Console.WriteLine("Enter the book's Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the book's Author:");
            string author = Console.ReadLine();
            Console.WriteLine("Enter the book's ISBN:");
            string isbn = Console.ReadLine();

            Book book = new Book(title, author, isbn);
            books.Add(book);

            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }

        //=======================REMOVE==================REMOVE=======================REMOVE=======================================
        public void Remove()
        {
            Console.WriteLine("Enter the ISBN of the book to remove:");
            string isbn = Console.ReadLine();

            int indexToRemove = -1;

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == isbn)
                {indexToRemove = i; break;}
            }

            if (indexToRemove != -1)
            {
                Book removedBook = books[indexToRemove];
                books.RemoveAt(indexToRemove);
                Console.WriteLine($"Book '{removedBook.Title}' removed from the library.");
            }
            else
            {Console.WriteLine($"Book with ISBN {isbn} not found in the library.");}
        }

        //================DISPLAY=============================DISPLAY==========================DISPLAY===========================
        public void Display()
        {
            Console.WriteLine("Books in the library:");
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title} ({book.Author})");
            }
        }
    }
}
