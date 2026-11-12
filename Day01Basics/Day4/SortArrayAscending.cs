using System;
using System.Collections.Generic;
using System.Text;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day4
{
    /// <summary>
    /// Day 4 - Problem 5: Sort Elements of an Array in Ascending Order
    /// </summary>
    public class SortArrayAscending
    {
        private const int MaxValue = 25;
        private const int MinValue = 1;
        /// <summary>
        /// 
        /// </summary>
        public static void Run()
        {
            double[] numbers = ReadNumberArray("Input the size of array : ", MinValue, MaxValue);
            
            //Array.Sort(numbers);

            //Console.WriteLine("Elements of the array in ascending order:");
            //foreach (double number in numbers)
            //{
            //    Console.Write($"{number} ");
            //}
            //Console.WriteLine();

            for (int i=0; i<numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
                    }
                }
            }

            Console.WriteLine("Elements of the array in sorted ascending order:");
            foreach (double number in numbers)
                Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
