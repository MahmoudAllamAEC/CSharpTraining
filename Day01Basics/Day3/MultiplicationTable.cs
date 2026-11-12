using System;
using System.Collections.Generic;
using System.Text;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day3
{
    /// <summary>
    /// Day 3 - Problem 2: take a number and print its multiplication table
    /// </summary>
    public class MultiplicationTable
    {
        private const int MAX_TABLE_LENGTH = 25;
        /// <summary>
        /// takes a number and the length of the table and output the table
        /// </summary>
        public static void Run()
        {
            int number = ReadInteger("Input a number: ");
            int length = ReadInteger($"Input the length from 1 to {MAX_TABLE_LENGTH} for the multiplication table: ");

            if (length <= 0)
            {
                Console.WriteLine("Error: Length must be a positive integer.");
                return;
            }
            if (length > MAX_TABLE_LENGTH)
            {
                Console.WriteLine($"Error: Length must be from 1 to {MAX_TABLE_LENGTH}.");
                return;

            }

            Console.WriteLine($"Multiplication Table for {number} with {length} rows:");
            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
