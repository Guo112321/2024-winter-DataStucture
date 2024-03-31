using Lab_6;

public class Program
{
    private static void Main(string[] args)
    {
        CourseManager courseManager = CourseManager.getCourseManager();

        courseManager.PresentAllCourse();

        Console.WriteLine("----------------");

        courseManager.AddCourse("English");
        courseManager.PresentAllCourse();
        Console.WriteLine("----------------");

        courseManager.RemoveCourse("English");
        courseManager.PresentAllCourse();
        Console.WriteLine("----------------");

        courseManager.RemoveCourse("Chinese");

    }
}