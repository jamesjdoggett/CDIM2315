using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code for Q1:
            int N = GetValidInteger("Input an integer: ");
            if (IsPrime(N))
                Console.WriteLine($"{N} is prime");
            else
                Console.WriteLine($"{N} is non-prime");

            // Code for Q2:
            N = GetValidInteger("Assign an int value to N: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            // Code for Q3:
            N = GetValidInteger("Assign an int value to N: ");
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Code for Bonus Question:
            N = GetValidInteger("Assign an int value to N: ");
            for (int i = 1; i <= N; i++)
            {
                Console.Write(new string(' ', N - i));
                Console.WriteLine(new string((char)(i + '0'), i));
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2)
                return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static int GetValidInteger(string message)
        {
            int number;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }
            return number;
        }
    }
}