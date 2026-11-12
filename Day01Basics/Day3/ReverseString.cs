using System;
using System.Collections.Generic;
using System.Text;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day3
{
    /// <summary>
    /// Day 3 - Problem 3: taking a string and reversing the result 
    /// </summary>
    public class ReverseString
    {
        /// <summary>
        /// Reads a string and prints it reversed
        /// </summary>
        public static void Run()
        {
            string inputString = ReadText("Input a string: ");
            char[] characters = inputString.ToCharArray();

            //Array.Reverse(charArray);

            for (int index = inputString.Length-1;index >= 0; index--)
            {
                characters[inputString.Length - 1 - index] = inputString[index];
            }
            string reversedInputString = new string(characters);
            
            Console.WriteLine($"The reversed string is: {reversedInputString}");
        }
    }
}
