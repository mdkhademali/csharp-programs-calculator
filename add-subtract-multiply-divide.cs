using System;

namespace EducationalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Calculator Program!");
            Console.WriteLine("This program can perform addition, subtraction, multiplication, and division.");
            
            // Get two numbers from the user
            double num1 = GetNumberFromUser("Enter the first number:");
            double num2 = GetNumberFromUser("Enter the second number:");

            // Ask the user to choose an operation
            Console.WriteLine("Choose an operation (+, -, *, /):");
            string operation = Console.ReadLine();

            // Perform the operation based on the user's choice
            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // Handle division by zero
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    validOperation = false;
                    break;
            }

            // Display the result if the operation is valid
            if (validOperation)
            {
                Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
            }
        }

        // Method to get a valid number input from the user
        static double GetNumberFromUser(string prompt)
        {
            double number = 0;  // Initialize number to avoid the CS0165 error
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();

                // Try to convert the input to a double
                isValid = double.TryParse(userInput, out number);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }

            return number;
        }
    }
}