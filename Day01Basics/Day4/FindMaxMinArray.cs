using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day4
{
    /// <summary>
    /// Day 4 - Problem 3: Find Maximum and Minimum in Array
    /// </summary>
    public class FindMaxMinArray
    {
        private const int MAX_LENGTH = 25;
        private const int MIN_LENGTH = 1;

        /// <summary>
        /// finding the smallest and largest elements in an array of numbers using loops from the user input.
        /// </summary>
        public static void Run()
        {
            double[] numbers = ReadNumberArray($"Enter the length of the array ({MIN_LENGTH} to {MAX_LENGTH}): ", MIN_LENGTH, MAX_LENGTH);

            double max = double.MinValue;
            double min = double.MaxValue;

            foreach (double number in numbers)
            {
                if (number >max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");

        }
    }
}
