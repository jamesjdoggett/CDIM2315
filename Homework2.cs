namespace Homework2;

class Program 
{
    static void Main(string[] args)
    {  // Question 1: Grade to GPA Conversion
        Console.WriteLine("Please input a letter grade:");
        char grade = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); // Move to the next line after input

        switch (grade)
        {
            case 'A':
                Console.WriteLine("GPA point: 4");
                break;
            case 'B':
                Console.WriteLine("GPA point: 3");
                break;
            case 'C':
                Console.WriteLine("GPA point: 2");
                break;
            case 'D':
                Console.WriteLine("GPA point: 1");
                break;
            case 'F':
                Console.WriteLine("GPA point: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }

        Console.WriteLine("\n-----------------------------\n");

        // Question 2: Find the Smallest Number
        Console.WriteLine("Please input the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please input the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please input the third number:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int smallest = num1;

        if (num2 < smallest)
            smallest = num2;
        if (num3 < smallest)
            smallest = num3;

        Console.WriteLine("The smallest value is: " + smallest);

        Console.WriteLine("\n-----------------------------\n");

        // Bonus: Leap Year Checker
        Console.WriteLine("Please input a year:");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }



}