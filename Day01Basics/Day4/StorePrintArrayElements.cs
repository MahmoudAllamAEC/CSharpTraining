using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day4
{
    /// <summary>
    /// Day 4 - Problem 1: Store and Print Array Elements
    /// </summary>
    public class StorePrintArrayElements
    {
        private const int MAX_LENGTH = 25;
        private const int MIN_LENGTH = 1;

        /// <summary>
        /// Reads an array of numbers from the user and prints them to the console.
        /// </summary>
        public static void Run()
        {
            
            double[] numbers = ReadNumberArray($"Enter the length of the array ({MIN_LENGTH} to {MAX_LENGTH}): ", MIN_LENGTH, MAX_LENGTH);

            //print the array elements
            Console.WriteLine("Array elements:");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element {i + 1}: {numbers[i]}");
            }

        }
    }
}
