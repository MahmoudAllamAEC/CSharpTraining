using System;
using System.Collections.Generic;
using System.Text;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day3
{
    /// <summary>
    /// Day 3 problem 6: upside Down Centered Pyramid
    /// </summary>
    public class CenteredPyramid
    {
        const int MIN_HEIGHT = 1;
        const int MAX_HEIGHT = 25;

        /// <summary>
        /// Creating an upside down centered pyramid pattern from user input
        /// </summary>
        public static void Run()
        {
            int height = ReadIntegerInRange($"Input the height of the pyramid ({MIN_HEIGHT} to {MAX_HEIGHT}): ",
                                            MIN_HEIGHT,
                                            MAX_HEIGHT);

            Console.WriteLine($"Centered Pyramid with height {height}:");
            for (int i = height; i >= 1; i--)
            {
                string spaces = new string(' ', height - i);
                string stars = new string('*', 2 * i - 1);
                Console.WriteLine(spaces + stars + spaces);
            }
        }
    }
}
