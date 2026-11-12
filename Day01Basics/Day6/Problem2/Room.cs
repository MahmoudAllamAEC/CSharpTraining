namespace TrainingBasics.Day6.Problem2
{

    /// <summary>
    /// Day 6 - Problem 2: A room.
    /// Task: fields Area, Doors and Windows, constructors to set them,
    /// ClassifyRoom() returns "Small", "Medium" or "Large",
    /// GetOpeningsCount() returns doors + windows.
    /// </summary>
    public class Room
    {
        #region Constants
        private const int SMALL_ROOM_LIMIT = 100;
        private const int LARGE_ROOM_LIMIT = 200;
        #endregion

        public int Area { get; private set; }
        public int Doors { get; private set; }
        public int Windows { get; private set; }

        /// <summary>
        /// Create room with area doors and windows
        /// </summary>
        /// <param name="area"></param>
        /// <param name="doors"></param>
        /// <param name="windows"></param>
        /// <exception cref="ArgumentException"></exception>
        public Room(int area, int doors, int windows)
        {
            if (area <= 0 || doors < 0 || windows < 0)
            {
                throw new ArgumentException("Area must be positive, and doors/windows cannot be negative.");
            }
            Area = area;
            Doors = doors;
            Windows = windows;
        }

        private string ClassifyRoom()
        {
            if (Area < SMALL_ROOM_LIMIT)
                return "Small";
            else if (Area <= LARGE_ROOM_LIMIT)
                return "Medium";
            else
                return "Large";

        }

        private int GetOpeningsCount()
        {
            return Doors + Windows;
        }
        /// <summary>
        /// Prints the room's data, classification and openings count.
        /// </summary>
        public void DisplayDetails()
        {
            Console.WriteLine($"Area: {Area}," +
                             $" Doors: {Doors}," +
                             $" Windows: {Windows}," +
                             $" Classification: {ClassifyRoom()}," +
                             $" Total Openings: {GetOpeningsCount()}");
        }

    }
}
