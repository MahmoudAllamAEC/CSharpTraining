using System;
using System.Collections.Generic;
using System.Text;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day1
{
    /// <summary>
    /// Day 1 – Problem 5: Substring Extractor
    /// </summary>
    public class SubstringExtractor
    {
        /// <summary>
        /// Reads a word and prints its first 3 characters
        /// </summary>
        private const int CHARACTER_COUNT = 3;
        public static void Run()
        {

            string word = ReadText("Input a word: ");
            if (word.Length < CHARACTER_COUNT)
            {
                Console.WriteLine($"The first characters are : {word}");
                return;
            }
            string firstThreeCharacters = word.Substring(0, CHARACTER_COUNT);
            Console.WriteLine($"The first three characters are : {firstThreeCharacters}");
        }

    }
}
