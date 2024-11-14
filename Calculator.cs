using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Advanced C# Calculator!");

            while (true)
            {
                // Display the menu
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Modulus (%)");
                Console.WriteLine("6. Power (^)");
                Console.WriteLine("7. Square Root (√)");
                Console.WriteLine("8. Factorial (!)");
                Console.WriteLine("9. Exit");

                string choice = Console.ReadLine();

                if (choice == "9")
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                double result = 0;
                bool validOperation = true;

                try
                {
                    switch (choice)
                    {
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                            // Get two numbers for these operations
                            double num1 = GetNumber("Enter the first number: ");
                            double num2 = GetNumber("Enter the second number: ");
                            
                            result = PerformOperation(choice, num1, num2);
                            break;

                        case "7":
                            // Square root operation
                            double num = GetNumber("Enter the number: ");
                            result = Math.Sqrt(num);
                            Console.WriteLine($"Result: √{num} = {result}");
                            break;

                        case "8":
                            // Factorial operation
                            int factorialNumber = (int)GetNumber("Enter a non-negative integer: ");
                            result = Factorial(factorialNumber);
                            Console.WriteLine($"Result: {factorialNumber}! = {result}");
                            break;

                        default:
                            Console.WriteLine("Invalid choice! Please select a valid operation.");
                            validOperation = false;
                            break;
                    }

                    if (validOperation && choice != "7" && choice != "8")
                    {
                        Console.WriteLine($"Result: {result}");
                    }

                    // Ask if the user wants to perform another calculation
                    if (validOperation)
                    {
                        Console.WriteLine("\nDo you want to perform another calculation? (y/n)");
                        string continueChoice = Console.ReadLine().ToLower();
                        if (continueChoice != "y")
                        {
                            Console.WriteLine("Thank you for using the Advanced C# Calculator. Goodbye!");
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        // Helper function to get a number from user input with exception handling
        static double GetNumber(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double number))
                    return number;

                Console.Write("Invalid input. Please enter a valid number: ");
            }
        }

        // Helper function to perform basic operations based on choice
        static double PerformOperation(string choice, double num1, double num2)
        {
            return choice switch
            {
                "1" => num1 + num2,
                "2" => num1 - num2,
                "3" => num1 * num2,
                "4" when num2 != 0 => num1 / num2,
                "4" => throw new DivideByZeroException("Cannot divide by zero."),
                "5" => num1 % num2,
                "6" => Math.Pow(num1, num2),
                _ => throw new InvalidOperationException("Invalid operation.")
            };
        }

        // Factorial function
        static double Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers.");

            double result = 1;
            for (int i = 1; i <= number; i++)
                result *= i;

            return result;
        }
    }
}
