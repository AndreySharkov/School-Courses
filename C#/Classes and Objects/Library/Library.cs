using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        private List<Book> books = new List<Book>();
        public void AddBook(string title, string author, int year)
        {
            if (books.Any(b => b.Title.Equals(title) &&
                               b.Author.Equals(author) &&
                               b.Year.Equals(year)))
            {
                Console.WriteLine("This book already exists in the library.");
            }
            else
            {
                books.Add(new Book(title, author, year));
                Console.WriteLine("Book added successfully.");
            }
        }
        public void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
            }
            else
            {
                Console.WriteLine("\nList of Books:");
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }
        public void SearchBook(string title)
        {
            var foundBooks = books.Where(b => b.Title.IndexOf(title) >= 0).ToList();

            if (foundBooks.Count == 0)
            {
                Console.WriteLine("No books found with that title.");
            }
            else
            {
                Console.WriteLine("\nSearch Results:");
                foreach (var book in foundBooks)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}
