namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
         // Call Q1_method
            Console.WriteLine("Q1: Find the largest of two numbers");
            int largestTwo = Q1_LargestNumber();
            Console.WriteLine("The largest number is: " + largestTwo);
            Console.WriteLine();

            // Call Q2_method
            Console.WriteLine("Q2: Find the largest of four numbers using Q1 method");
            int largestFour = Q2_LargestNumber();
            Console.WriteLine("The largest number is: " + largestFour);
            Console.WriteLine();

            // Call Q3_method
            Console.WriteLine("Q3: Account Creation");
            createAccount();
        }

        // Q1: Method to get 2 integers and return the largest one
        static int Q1_LargestNumber()
        {
            Console.Write("Enter first number (a): ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid input. Defaulting to 0.");
                a = 0;
            }

            Console.Write("Enter second number (b): ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid input. Defaulting to 0.");
                b = 0;
            }
            
            return (a > b) ? a : b;
        }

        // Q2: Method to get 4 integers and return the largest one using Q1_LargestNumber method
        static int Q2_LargestNumber()
        {
            Console.Write("Enter first number (a): ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid input. Defaulting to 0.");
                a = 0;
            }

            Console.Write("Enter second number (b): ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid input. Defaulting to 0.");
                b = 0;
            }

            Console.Write("Enter third number (c): ");
            if (!int.TryParse(Console.ReadLine(), out int c))
            {
                Console.WriteLine("Invalid input. Defaulting to 0.");
                c = 0;
            }

            Console.Write("Enter fourth number (d): ");
            if (!int.TryParse(Console.ReadLine(), out int d))
            {
                Console.WriteLine("Invalid input. Defaulting to 0.");
                d = 0;
            }
            
            int max1 = Q1_LargestNumberHelper(a, b);
            int max2 = Q1_LargestNumberHelper(c, d);
            return Q1_LargestNumberHelper(max1, max2);
        }

        // Helper method for Q1 (since we can't use input calls inside Q2 method)
        static int Q1_LargestNumberHelper(int x, int y)
        {
            return (x > y) ? x : y;
        }

        // Q3.1: Method to check age eligibility
        static bool checkAge(int birth_year)
        {
            int current_year = DateTime.Now.Year;
            int age = current_year - birth_year;
            return age >= 18;
        }

        // Q3.2: Method to create an account
        static void createAccount()
        {
            Console.Write("Enter username: ");
            string? username = Console.ReadLine();
            
            Console.Write("Enter password: ");
            string? password1 = Console.ReadLine();
            
            Console.Write("Re-enter password: ");
            string? password2 = Console.ReadLine();
            
            Console.Write("Enter birth year: ");
            if (!int.TryParse(Console.ReadLine(), out int birthYear))
            {
                Console.WriteLine("Invalid input. Could not create an account.");
                return;
            }

            if (checkAge(birthYear))
            {
                if (password1 == password2 && !string.IsNullOrEmpty(password1))
                {
                    Console.WriteLine("Account is created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account");
            }
        }
    }