namespace TrainingBasics.Day6.Problem1
{
    /// <summary>
    /// Day 6 - Problem 1: A rectangle.
    /// Task: fields Length and Width, a constructor to set them,
    /// CalculateArea() and CalculatePerimeter().
    /// </summary>
    public class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        /// <summary>
        /// creates a rectangle .throws if a side is not positive
        /// </summary>
        /// <param name="length">The length of the rectangle. Must be positive.</param>
        /// <param name="width">The width of the rectangle. Must be positive.</param>
        public Rectangle(int length, int width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Length and width must be positive.");
            }
            Length = length;
            Width = width;
        }
        /// <summary>
        /// calculates the area of the rectangle
        /// </summary>
        /// <returns>area</returns>
        public int CalculateArea()
        {
            return Length * Width;
        }
        
        /// <summary>
        /// calculates the perimeter of the rectangle
        /// </summary>
        /// <returns>perimeter</returns>
        public int CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        /// <summary>
        /// prints the length, width, area, and perimeter of the rectangle to the console.
        /// </summary>
        public void DisplayDetails()
        {
            Console.WriteLine($"Length: {Length}," +
                             $" Width: {Width}," +
                             $" Area: {CalculateArea()}," +
                             $" Perimeter: {CalculatePerimeter()}");
        }
    }
}

   

