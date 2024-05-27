using System;
class Student
{
// Properties
public string FullName { get; set; }
public int Semester { get; set; }
public string CourseCode { get; set; }
public string Subject { get; set; }
public string Email { get; set; }
public string PhoneNumber { get; set; }
// Constructors
public Student()
{
// Default constructor
}
public Student(string fullName, int semester, string courseCode, string subject, string email,
string phoneNumber)
{
FullName = fullName;
Semester = semester;
CourseCode = courseCode;
Subject = subject;
Email = email;
PhoneNumber = phoneNumber;
}
public Student(string fullName, int semester, string courseCode)
{
FullName = fullName;
Semester = semester;
CourseCode = courseCode;
Subject = null;
Email = null;
PhoneNumber = null;
}
// Method to display complete information
public void DisplayInformation()
{
Console.WriteLine("Full Name: " + FullName);
Console.WriteLine("Semester: " + Semester);

Console.WriteLine("Course Code: " + CourseCode);
Console.WriteLine("Subject: " + (Subject ?? "N/A"));
Console.WriteLine("Email: " + (Email ?? "N/A"));
Console.WriteLine("Phone Number: " + (PhoneNumber ?? "N/A"));
}
}
class Program
{
static void Main(string[] args)
{
// Using different constructors
Student student1 = new Student("John", 3, "CS101", "Dot Net Framework",
"john@example.com", "123-456-7890");
Student student2 = new Student("Joseph", 3, "ENG201");
Student student3 = new Student();
// Displaying information
Console.WriteLine("Student 1 Information:");
student1.DisplayInformation();
Console.WriteLine();
Console.WriteLine("Student 2 Information:");
student2.DisplayInformation();
Console.WriteLine();
Console.WriteLine("Student 3 Information:");
student3.DisplayInformation();
}
}