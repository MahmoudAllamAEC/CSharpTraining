using System;
using System.Collections.Generic;
using System.Text;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day1
{
    /// <summary>
    /// Day 1 – Problem 3: Swap Two Numbers
    /// </summary>
    public class NumberSwapper
    {
        /// <summary>
        /// Takes two numbers from the user and swaps them
        /// </summary>
        public static void Run()
        {
            double firstNumber = ReadNumber("Enter the first number: ");
            double secondNumber = ReadNumber("Enter the second number: ");

            Console.WriteLine($"First Number: {firstNumber}");
            Console.WriteLine($"Second Number: {secondNumber}");

            double originalFirstNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = originalFirstNumber;

            Console.WriteLine("After Swapping:");
            Console.WriteLine($"First Number: {firstNumber}");
            Console.WriteLine($"Second Number: {secondNumber}");
        }
    }
}
