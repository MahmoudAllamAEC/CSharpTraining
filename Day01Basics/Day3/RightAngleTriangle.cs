using System;
using System.Collections.Generic;
using System.Text;
using static TrainingBasics.Utilities;


namespace TrainingBasics.Day3
{
    /// <summary>
    /// Day 3 problem 4: Right Angle Triangle
    /// </summary>
    public class RightAngleTriangle
    {
        private const int MIN_HEIGHT = 1;
        private const int MAX_HEIGHT = 25;

        /// <summary>
        /// create a right angle triangle pattern from the user input
        /// </summary>
        public static void Run()
        {
            int height = ReadIntegerInRange($"Input the height of the triangle ({MIN_HEIGHT} to {MAX_HEIGHT}): ",
                                            MIN_HEIGHT,
                                            MAX_HEIGHT);

            Console.WriteLine($"Right Angle Triangle with height {height}:");
            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}
