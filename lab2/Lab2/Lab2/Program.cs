using Lab2;

class Program
{
    static Stack<Book> bookStack = new Stack<Book>();

    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add New Book");
            Console.WriteLine("2. Display All Books");
            Console.WriteLine("3. Display Number of Books");
            Console.WriteLine("4. Remove Latest Books");
            Console.WriteLine("5. Remove Books by Title or Author");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice (1-6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewBook();
                    break;
                case "2":
                    DisplayAllBooks();
                    break;
                case "3":
                    DisplayNumberOfBooks();
                    break;
                case "4":
                    RemoveBooks();
                    break;
                case "5":
                    RemoveBooksByTitleAndAuthor();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }


    static void AddNewBook()
    {
        Console.WriteLine("Enter book title:");
        string title = Console.ReadLine();

        Console.WriteLine("Enter author name:");
        string author = Console.ReadLine();

        Console.WriteLine("Enter number of pages:");
        int numOfPages = 0;
        while (!int.TryParse(Console.ReadLine(), out numOfPages) || numOfPages < 0)
        {
            Console.WriteLine("Invalid number of pages. Please enter a non-negative integer:");
        }

        bool sameBook = true;

        foreach (var existingBook in bookStack)
        {
            if (existingBook.Title == title && existingBook.Author == author)
            {
                Console.WriteLine("Book already exists:\n" + existingBook);
                sameBook = false;
                break;
            }
        }

        if (sameBook)
        {
            Book newBook = new Book(title, author, numOfPages);
            bookStack.Push(newBook);
            Console.WriteLine("Book added successfully!");
        }

    }

    static void DisplayAllBooks()
    {
        Console.WriteLine("All Books:");
        foreach (var book in bookStack)
        {
            Console.WriteLine(book.ToString());
        }
        Console.WriteLine();
    }

    static void DisplayNumberOfBooks()
    {
        Console.WriteLine($"Number of Books: {bookStack.Count}\n");
    }

    static void RemoveBooks()
    {
        if (bookStack.Count > 0)
        {
            Book removedBook = bookStack.Pop();
            Console.WriteLine($"Removed book: {removedBook.Title} by {removedBook.Author}\n");
        }
        else
        {
            Console.WriteLine("No books to remove. The stack is empty.\n");
        }
    }

    static void RemoveBooksByTitleAndAuthor()
    {
        Console.WriteLine("Enter book title or author to remove:");
        string searchQuery = Console.ReadLine();

        Stack<Book> tempStack = new Stack<Book>();
        bool findBook = false;

        while (bookStack.Count > 0)
        {
            Book book = bookStack.Pop();

            if (!(book.Title == searchQuery || book.Author == searchQuery))
            {
                tempStack.Push(book);
            }
            else
            {
                findBook = true;
            }
        }

        while (tempStack.Count > 0)
        {
            bookStack.Push(tempStack.Pop());
        }

        if (findBook)
        {
            Console.WriteLine($"Books with title or author '{searchQuery}' removed.\n");
        }
        else
        {
            Console.WriteLine($"Books with title or author '{searchQuery}' not found.\n");
        }
    }



}
