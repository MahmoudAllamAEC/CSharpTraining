using System;
using System.Collections.Generic;
using System.Text;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day3
{
    /// <summary>
    /// Day 3 – Problem 1: Even or Odd checker
    /// </summary>
    public class EvenOrOdd
    {
        /// <summary>
        /// this method reads a number and checks if it is even or odd
        /// </summary>
        public static void Run()
        {
            int number = ReadInteger("Input a number: ");
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is Even.");
            }
            else
            {
                Console.WriteLine($"The number {number} is Odd.");
            }
        }
            

    }
}
