using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class CourseManager
    {
        private static CourseManager instance;

        private CourseManager()
        {
            courseList = ["Mathematics", "Computer Science", "Physics", "Biology", "Chemistry"];
        }

        private static List<string> courseList;

        public static CourseManager getCourseManager()
        {
            if (instance == null)
            {
                instance = new CourseManager();
            }
            return instance;
        }

        public void AddCourse(string courseName)
        {
            courseList.Add(courseName);
            Console.WriteLine("Add successfully!");
        }

        public void RemoveCourse(string courseName)
        {
            try
            {
                if (courseList.Remove(courseName))
                {
                    Console.WriteLine("Remove successfully!");
                }
                else
                {
                    throw new Exception(courseName);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Could not remove {e.Message}!");
            }
        }

        public void PresentAllCourse()
        {
            Console.WriteLine("Available course:");
            foreach (var course in courseList)
            {
                Console.WriteLine(course);
            }
        }
    }
}
