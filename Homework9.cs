namespace Homework9p;
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    private int studentID;
    private string studentName;

    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public string Name
    {
        get { return studentName; }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 2: Create 4 students
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

        // Step 3: Create gradebook
        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

        // Step 4: Check for Tom (sneaky guy)
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }

        // Step 5: Calculate average GPA
        double totalGPA = gradebook.Values.Sum();
        double avgGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"The average GPA is: {avgGPA:F2}");

        // Step 6: Print students with GPA above average
        foreach (Student s in Student.studentList)
        {
            if (gradebook.ContainsKey(s.Name) && gradebook[s.Name] > avgGPA)
            {
                s.PrintInfo();
            }
        }
    }
}
