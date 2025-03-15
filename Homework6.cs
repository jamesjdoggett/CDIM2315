using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1: Creating and initializing professor objects
            Professor professor1 = new Professor("Alice", "Java");
            professor1.SetSalary(9000);

            Professor professor2 = new Professor("Bob", "Math");
            professor2.SetSalary(8000);

            // Creating and initializing student objects
            Student student1 = new Student("Lisa", "Java");
            student1.SetGrade(90);

            Student student2 = new Student("Tom", "Math");
            student2.SetGrade(80);

            // Q2: Printing professor details
            Console.WriteLine($"Professor {professor1.profName} teaches {professor1.classTeach}, and the salary is: {professor1.GetSalary()}");
            Console.WriteLine($"Professor {professor2.profName} teaches {professor2.classTeach}, and the salary is: {professor2.GetSalary()}");

            // Printing student details
            Console.WriteLine($"Student {student1.studentName} enrolls {student1.classEnroll}, and the grade is: {student1.GetGrade()}");
            Console.WriteLine($"Student {student2.studentName} enrolls {student2.classEnroll}, and the grade is: {student2.GetGrade()}");

            // Calculating and printing salary difference
            double salaryDifference = professor1.GetSalary() - professor2.GetSalary();
            Console.WriteLine($"The salary difference between {professor1.profName} and {professor2.profName} is: {salaryDifference}");

            // Calculating and printing total grades
            double totalGrades = student1.GetGrade() + student2.GetGrade();
            Console.WriteLine($"The total grade of {student1.studentName} and {student2.studentName} is: {totalGrades}");
        }
    }

    // Professor class definition
    class Professor
    {
        public string profName { get; }
        public string classTeach { get; }
        private double salary;

        public Professor(string name, string teachClass)
        {
            profName = name;
            classTeach = teachClass;
        }

        public void SetSalary(double salary_amount) => salary = salary_amount;
        public double GetSalary() => salary;
    }

    // Student class definition
    class Student
    {
        public string studentName { get; }
        public string classEnroll { get; }
        private double studentGrade;

        public Student(string name, string enrollClass)
        {
            studentName = name;
            classEnroll = enrollClass;
        }

        public void SetGrade(double newGrade) => studentGrade = newGrade;
        public double GetGrade() => studentGrade;
    }
}
