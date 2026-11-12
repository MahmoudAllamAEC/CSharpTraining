using System;
using System.Collections.Generic;
using System.Text;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day5
{
    /// <summary>
    /// Day 5 - Problem 1: List Filtering Using Methods
    /// </summary>
    public class ListFilteringMethods
    {
        private const int MIN_NAMES = 1;
        private const int MAX_NAMES = 25;

        /// <summary>
        ///filter names from a list and returns all names starting with the specified letter 
        /// </summary>
        public static void Run()
        {
            List<string> names = ReadListStrings($"Enter the number of names to filter (between {MIN_NAMES} and {MAX_NAMES}): ",
                                                MIN_NAMES,
                                                MAX_NAMES);
            char letter = ReadLetter("Letter = ");

            List<string> filteredNames = FilterNames(names, letter);
            if (filteredNames.Count == 0)
            {
                Console.WriteLine($"No names found starting with '{letter}'.");
                return;
            }

            Console.WriteLine($"Names starting with '{letter}': " +
                              $"{string.Join(", ", filteredNames)}");
            
        }
        /// <summary>
        /// Returns the names that start with the given letter (not case-sensitive).
        /// </summary>
        /// <param name="names">The names to search.</param>
        /// <param name="letter">The starting letter to look for.</param>
        /// <returns>A new list with the matching names.</returns>
        public static List<string> FilterNames(List<string> names, char letter)
        {
            List<string> filteredNames = new List<string>();
            foreach (string name in names)
            {
                if (char.ToUpper(name[0]) == char.ToUpper(letter))
                {
                    filteredNames.Add(name);
                }
            }
            return filteredNames;
        }
    }
}
