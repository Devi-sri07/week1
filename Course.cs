using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEnrollmentApp;



    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public int Capacity { get; private set; }
        public int Enrolled { get; private set; }

        public Course(int id, string title, int capacity)
        {
            Id = id;
            Title = title;
            Capacity = capacity;
            Enrolled = 0;
        }

        public void EnrollStudent()
        {
            if (Enrolled < Capacity)
            {
                Enrolled++;
                Console.WriteLine($"Student enrolled in '{Title}'. Seats left: {Capacity - Enrolled}");
            }
            else
            {
                Console.WriteLine($"Course '{Title}' is full.");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Title: {Title}, Capacity: {Capacity}, Enrolled: {Enrolled}");
        }
    }


