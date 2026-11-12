using static TrainingBasics.Utilities;

namespace TrainingBasics.Day1
{
    /// <summary>
    /// Day 1 – Problem 2: Basic Calculator
    /// </summary>
    public class BasicCalculator
    {
        /// <summary>
        /// Reads two numbers and prints +, -, *, / results.
        /// </summary>
        public static void Run()
        {
            
            double firstNumber = ReadNumber("Enter the first number: ");
            double secondNumber = ReadNumber("Enter the second number: ");

            // Perform calculations and print results
            Console.WriteLine($"Addition: {firstNumber + secondNumber}");
            Console.WriteLine($"Subtraction: {firstNumber - secondNumber}");
            Console.WriteLine($"Multiplication: {firstNumber * secondNumber}");

            // Check for division by zero
            if (IsZero(secondNumber))
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine($"Division: {firstNumber / secondNumber}");
            }
        }
    }
}
