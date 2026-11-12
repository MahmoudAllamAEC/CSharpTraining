using static TrainingBasics.Utilities;

namespace TrainingBasics.Day6.Problem1
{
    /// <summary>
    /// Day 6 - Problem 1: Create Rectangle objects and display area and perimeter.
    /// </summary>
    public class RectangleProblem
    {
        private const int MAX_WIDTH = 100;
        private const int MIN_WIDTH = 1;
        private const int MAX_LENGTH = 100;
        private const int MIN_LENGTH = 1;


        /// <summary>
        /// askes the user for length and width, creates a rectangle object, and displays its area and perimeter.
        /// </summary>
        public static void Run()
        {
            int length = ReadIntegerInRange($"Enter the length of the rectangle ({MIN_LENGTH} - {MAX_LENGTH}): ",
                                            MIN_LENGTH,
                                            MAX_LENGTH);

            int width = ReadIntegerInRange($"Enter the width of the rectangle ({MIN_WIDTH} - {MAX_WIDTH}): ",
                                            MIN_WIDTH,
                                            MAX_WIDTH);

            // Create a rectangle objects
            Rectangle userRectangle = new Rectangle(length, width);
            Rectangle squareRectangle = new Rectangle(length, length);



            // Display the rectangle's details
            userRectangle.DisplayDetails();
            squareRectangle.DisplayDetails();
        }
    }
}
