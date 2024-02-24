using System;
using System.Collections.Generic;

public class CourseDB
{
    private Dictionary<string, Course> courses;

    public CourseDB()
    {
        courses = new Dictionary<string, Course>();
    }

    public void AddCourse(Course course)
    {
        if (!courses.ContainsKey(course.Id))
        {
            courses.Add(course.Id, course);
            Console.WriteLine("Course added successfully.");
        }
        else
        {
            Console.WriteLine("Course with this ID already exists.");
        }
    }

    public Dictionary<string, Course> GetCourses()
    {
        return courses;
    }

    public void RemoveCourse(string courseId)
    {
        if (courses.ContainsKey(courseId))
        {
            courses.Remove(courseId);
            Console.WriteLine("Course removed successfully.");
        }
        else
        {
            Console.WriteLine("Course with this ID does not exist.");
        }
    }

    public Course FindCourse(string courseId)
    {
        if (courses.ContainsKey(courseId))
        {
            return courses[courseId];
        }
        else
        {
            Console.WriteLine("Course with this ID does not exist.");
            return null;
        }
    }
}
