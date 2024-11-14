using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# Calculator!");

            while (true)
            {
                // Display the menu
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                // Get user inputs
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                bool validOperation = true;

                // Perform the chosen operation
                switch (choice)
                {
                    case "1":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case "2":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                            validOperation = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please select a valid operation.");
                        validOperation = false;
                        break;
                }

                // Ask if the user wants to perform another calculation
                if (validOperation)
                {
                    Console.WriteLine("\nDo you want to perform another calculation? (y/n)");
                    string continueChoice = Console.ReadLine().ToLower();
                    if (continueChoice != "y")
                    {
                        Console.WriteLine("Thank you for using the C# Calculator. Goodbye!");
                        break;
                    }
                }
            }
        }
    }
}