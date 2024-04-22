using Lab9;
using System;
using File = Lab9.File;
using Directory = Lab9.Directory;

class Program
{
    static Directory root = new Directory("Root");

    static void Main(string[] args)
    {
        DisplayMenu();
    }


    static void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\nFile System Menu:");
            Console.WriteLine("1. Add File");
            Console.WriteLine("2. Add Directory");
            Console.WriteLine("3. Display File System");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddFile();
                    break;
                case "2":
                    AddDirectory();
                    break;
                case "3":
                    DisplayFileSystem();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void AddFile()
    {
        Console.Write("Enter the name of the file: ");
        string fileName = Console.ReadLine();
        Console.Write("Enter the size of the file: ");
        if (long.TryParse(Console.ReadLine(), out long fileSize))
        {
            root.Add(new File(fileName, fileSize));
            Console.WriteLine("File added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid file size.");
        }
    }

    static void AddDirectory()
    {
        Console.Write("Enter the name of the directory: ");
        string dirName = Console.ReadLine();
        root.Add(new Directory(dirName));
        Console.WriteLine("Directory added successfully.");
    }

    static void DisplayFileSystem()
    {
        root.Display(0);
    }
}