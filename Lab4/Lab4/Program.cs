using System;

class Program
{
    static void Main(string[] args)
    {
        CourseDB courseDB = new CourseDB();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display details of all courses");
            Console.WriteLine("2. Add a new course");
            Console.WriteLine("3. Find a course by ID");
            Console.WriteLine("4. Remove a course by ID");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        DisplayAllCourses(courseDB);
                        break;
                    case 2:
                        AddNewCourse(courseDB);
                        break;
                    case 3:
                        FindCourseByID(courseDB);
                        break;
                    case 4:
                        RemoveCourseByID(courseDB);
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.WriteLine();
        }
    }

    static void DisplayAllCourses(CourseDB courseDB)
    {
        var courses = courseDB.GetCourses();
        foreach (var course in courses)
        {
            Console.WriteLine(course.Value);
        }
    }

    static void AddNewCourse(CourseDB courseDB)
    {
        Console.Write("Enter course ID: ");
        string id = Console.ReadLine();
        Console.Write("Enter course title: ");
        string title = Console.ReadLine();
        Console.Write("Enter course credits: ");
        int credits;
        if (int.TryParse(Console.ReadLine(), out credits))
        {
            Console.Write("Enter course description: ");
            string description = Console.ReadLine();

            Course newCourse = new Course(id, title, credits, description);
            courseDB.AddCourse(newCourse);
        }
        else
        {
            Console.WriteLine("Invalid credits. Please enter a valid integer value.");
        }
    }

    static void FindCourseByID(CourseDB courseDB)
    {
        Console.Write("Enter course ID to find: ");
        string id = Console.ReadLine();
        Course foundCourse = courseDB.FindCourse(id);
        if (foundCourse != null)
        {
            Console.WriteLine(foundCourse);
        }
    }

    static void RemoveCourseByID(CourseDB courseDB)
    {
        Console.Write("Enter course ID to remove: ");
        string id = Console.ReadLine();
        courseDB.RemoveCourse(id);
    }
}
