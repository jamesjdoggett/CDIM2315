namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        // Call Q1_method()
        Console.WriteLine("Enter first number (a): ");
        string? inputA = Console.ReadLine();
        int a = (int.TryParse(inputA, out int numA)) ? numA : 0; // Default to 0 if input is invalid

        Console.WriteLine("Enter second number (b): ");
        string? inputB = Console.ReadLine();
        int b = (int.TryParse(inputB, out int numB)) ? numB : 0; // Default to 0 if input is invalid

        int largest = Q1_method(a, b);
        Console.WriteLine($"The largest number is {largest}\n");

        // Call Q2_method()
        Console.WriteLine("Enter an integer N for the triangle: ");
        string? inputN = Console.ReadLine();
        int N = (int.TryParse(inputN, out int numN)) ? numN : 0; // Default to 0 if input is invalid

        Console.WriteLine("Enter shape (left/right): ");
        string? shape = Console.ReadLine()?.ToLower(); // Handle potential null

        if (!string.IsNullOrEmpty(shape))
        {
            Q2_method(N, shape);
        }
        else
        {
            Console.WriteLine("Invalid shape input.");
        }
    }

    // Q1_method: Returns the largest of two numbers
    static int Q1_method(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }

    // Q2_method: Prints a left or right-aligned triangle
    static void Q2_method(int N, string shape)
    {
        Console.WriteLine($"N is: {N}; shape is {shape}\n");
        if (shape == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        else if (shape == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string(' ', N - i) + new string('*', i));
            }
        }
        else
        {
            Console.WriteLine("Invalid shape input. Please enter 'left' or 'right'.");
        
        }
    }
}
