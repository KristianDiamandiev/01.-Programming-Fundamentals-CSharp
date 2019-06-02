using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    static Book AddBook()
    {
        Book NewBook = new Book();
        var input = Console.ReadLine().Split();
        NewBook.Title = input[0];
        NewBook.Author = input[1];
        NewBook.Publisher = input[2];
        NewBook.ReleaseDate = input[3];
        NewBook.ISBN = input[4];
        NewBook.Price = double.Parse(input[5]);
        return NewBook;
    }

    static Library CreateLibrary()
    {
        Library NewLibrary = new Library();
        int NumberOfBooks = int.Parse(Console.ReadLine());
        List<Book> AddingBooks = new List<Book>();
        while (NumberOfBooks-- != 0)
        {
            AddingBooks.Add(AddBook());
        }
        NewLibrary.Books = AddingBooks;
        return NewLibrary;
    }

    static void Main()
    {
        Library MoqtaBiblioteka = new Library();
        MoqtaBiblioteka = CreateLibrary();
        Dictionary<string, double> AuthorPrice = new Dictionary<string, double>();
        foreach (var book in MoqtaBiblioteka.Books)
        {
            if (!AuthorPrice.ContainsKey(book.Author))
            {
                AuthorPrice.Add(book.Author, book.Price);
            }
            else
            {
                AuthorPrice[book.Author] += book.Price;
            }
        }
        foreach (var ap in AuthorPrice.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{ap.Key} -> {ap.Value:F2}");
        }
    }
}

