namespace Library
{
    class Program
    {
        static void Main()
        {
            Library library = new Library();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. List all Books");
                Console.WriteLine("3. Search for a Book by Title");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Book Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Book Year: ");
                        int year = int.Parse(Console.ReadLine());
                        library.AddBook(title, author, year);
                        break;

                    case "2":
                        library.ListBooks();
                        break;

                    case "3":
                        Console.Write("Enter title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchBook(searchTitle);
                        break;

                    case "4":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }

}
