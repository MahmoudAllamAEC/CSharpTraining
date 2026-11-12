using System;
using System.Collections.Generic;
using System.Text;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day4
{
    /// <summary>
    /// Day 4 - Problem 2: Access Specific Element in Array
    /// </summary>
    public class AccessArrayElement
    {
        private const int MAX_LENGTH = 25;
        private const int MIN_LENGTH = 1;
        /// <summary>
        /// user input an array of numbers and access a specific element in the array.
        /// </summary>
        public static void Run()
        {
            
            double[] numbers = ReadNumberArray($"Enter the length of the array ({MIN_LENGTH} to {MAX_LENGTH}): ", MIN_LENGTH, MAX_LENGTH);

            int index = ReadIntegerInRange($"Enter the index of the element to access (0 to {numbers.Length - 1}): ",
                                            0,
                                            numbers.Length - 1);
            Console.WriteLine($"Element at index {index}: {numbers[index]}");

        }
    }
}
