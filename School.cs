using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEnrollmentApp;


public class School
{
    private readonly List<Course> courses = new();

    public void AddCourse(Course course)
    {
        courses.Add(course);
        Console.WriteLine($"Course '{course.Title}' added.");
    }

    public Course? FindCourse(int id) => courses.Find(c => c.Id == id);

    public void ShowAllCourses()
    {
        Console.WriteLine("\nCourses in School:");
        foreach (var course in courses)
        {
            course.DisplayInfo();
        }
    }
}

