using CourseEnrollmentApp;

var school = new School();

var c1 = new Course(1, "Mathematics", 2);
var c2 = new Course(2, "Computer Science", 3);

school.AddCourse(c1);
school.AddCourse(c2);

c1.EnrollStudent();
c1.EnrollStudent();
c1.EnrollStudent(); // exceeds capacity

school.ShowAllCourses();

var found = school.FindCourse(2);
if (found is not null)
{
    Console.WriteLine("\nFound Course:");
    found.DisplayInfo();
}