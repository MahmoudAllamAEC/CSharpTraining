namespace TrainingBasics
{
    /// <summary>
    /// Reusable helpers for reading and validating console input
    /// </summary>
    public static class Utilities
    {

        
        /// <summary>
        /// takes the number of names as a list then reads each name 
        /// </summary>
        /// <returns></returns>
        public static List<string> ReadListStrings(string prompt, int minCount, int maxCount)
        {
            int count = ReadIntegerInRange(prompt, minCount, maxCount);

            List<string> names = new List<string>();

            for (int i = 0; i < count; i++)
                names.Add(ReadText($"Enter name {i + 1}: "));

            return names;

        }
        /// <summary>
        /// Asks the user until a single letter is entered, then returns that letter.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static char ReadLetter(string prompt)
        {
            string intput = ReadText(prompt);
            while (intput.Length != 1 || !char.IsLetter(intput[0]))
            {
                intput = ReadText("Must be a single letter. Try again: ");
            }
            return intput[0];

        }

        /// <summary>
        /// Asks the user for an array length, then for each element.
        /// </summary>
        /// <param name="prompt">The prompt to display to the user.</param>
        /// <param name="minLength">The minimum allowed length.</param>
        /// <param name="maxLength">The maximum allowed length.</param>
        /// <returns>The filled array.</returns>
        public static double[] ReadNumberArray(string prompt, int minLength, int maxLength)
        {
            int length = ReadIntegerInRange(prompt, minLength, maxLength);
            double[] numbers = new double[length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumber($"Enter element {i + 1}: ");
            }
            return numbers;
        }
        /// <summary>
        /// Asks the user for a whole number until one between min and max is entered.
        /// </summary>
        /// <param name="prompt">The prompt to display to the user.</param>
        /// <param name="min">The minimum allowed value.</param>
        /// <param name="max">The maximum allowed value.</param>
        public static int ReadIntegerInRange(string prompt, int min, int max)
        {
            int number = ReadInteger(prompt);
            while (number < min || number > max)
            {
                number = ReadInteger($"Must be from {min} to {max}. Try again: ");
            }
            return number;
        }
        /// <summary>
        /// Asks the user for text until a non-empty value is entered.
        /// </summary>
        public static string ReadText(string prompt)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Input cannot be empty. Try again: ");
                input = Console.ReadLine();
            }
            return input.Trim();
        }

        /// <summary>
        /// Asks the user for a number until a valid one is entered.
        /// </summary>
        public static double ReadNumber(string prompt)
        {
            double number;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid number. Try again: ");
            }
            return number;
        }

        /// <summary>
        /// Asks the user for a whole number until a valid one is entered.
        /// </summary>
        public static int ReadInteger(string prompt)
        {
            int number;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid whole number. Try again: ");
            }
            return number;
        }

        /// <summary>
        /// Returns true if the number is 0, otherwise returns false.
        /// </summary>
        public static bool IsZero(double number)
        {
            return number == 0;
        }
    }
}
