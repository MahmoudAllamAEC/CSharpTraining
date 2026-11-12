using static TrainingBasics.Utilities;

namespace TrainingBasics.Day1
{
    /// <summary>
    /// Day 1 – Problem 4: String Concatenation
    /// </summary>
    public class FullNameBuilder
    {
        /// <summary>
        /// Takes first and last name from the user and prints the full name.
        /// </summary>
        public static void Run()
        {
            string firstName = ReadText("Input first name: ");
            string lastName = ReadText("Input last name: ");
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Full Name: {fullName}");
        }
    }
}
