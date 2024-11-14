# Advanced C# Calculator

This is an advanced calculator application written in C#. It supports basic arithmetic operations as well as more advanced functions, such as modulus, power, square root, and factorial. The calculator has built-in error handling and is designed for an interactive console environment.

## Features

The calculator includes the following operations:

1. **Addition (+)**
2. **Subtraction (-)**
3. **Multiplication (*)**
4. **Division (/)** - Includes handling for division by zero.
5. **Modulus (%)** - Finds the remainder of division.
6. **Power (^)** - Raises a number to the power of another.
7. **Square Root (√)** - Calculates the square root of a number.
8. **Factorial (!)** - Calculates the factorial of a non-negative integer.
9. **Exit** - Allows the user to exit the application.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or higher)

### Running the Application

1. Clone the repository or download the code files.
2. Open a terminal or command prompt.
3. Navigate to the directory containing the code files.
4. Compile and run the application using the following commands:

   ```bash
   dotnet run
   ```

### Usage

1. Run the program, and you will see a menu of operations.
2. Enter the number corresponding to the operation you want to perform.
3. For most operations, you will be prompted to enter one or two numbers as inputs.
4. The result of the calculation will be displayed, and you will be asked if you want to perform another calculation.

### Example Operations

- **Addition**: Enter `1` for addition, then input two numbers. The program will display the sum.
- **Square Root**: Enter `7` for square root, then input a number. The program will display the square root of the number.
- **Factorial**: Enter `8` for factorial, then input a non-negative integer. The program will display the factorial.

### Error Handling

The application includes error handling for the following cases:
- **Invalid Input**: If a non-numeric input is provided, the application will prompt the user to enter a valid number.
- **Division by Zero**: Attempting to divide by zero will result in an error message.
- **Invalid Factorial Input**: The factorial function only accepts non-negative integers.

## Example Interaction

```plaintext
Welcome to the Advanced C# Calculator!

Choose an operation:
1. Addition (+)
2. Subtraction (-)
3. Multiplication (*)
4. Division (/)
5. Modulus (%)
6. Power (^)
7. Square Root (√)
8. Factorial (!)
9. Exit

> 1
Enter the first number: 10
Enter the second number: 5
Result: 10 + 5 = 15

Do you want to perform another calculation? (y/n)
> y
```

## License

This project is open-source and free to use.

---

Thank you for using the Advanced C# Calculator!
