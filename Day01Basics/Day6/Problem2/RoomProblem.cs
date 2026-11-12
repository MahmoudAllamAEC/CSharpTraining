using static TrainingBasics.Utilities;

namespace TrainingBasics.Day6.Problem2
{
    /// <summary>
    /// Day 6 - Problem 2: Create multiple Room objects and print their classification.
    /// </summary>
    public class RoomProblem
    {
        #region Constants
        private const int MIN_ROOMS = 1;
        private const int MAX_ROOMS = 5;

        private const int MIN_ROOM_AREA = 1;
        private const int MAX_ROOM_AREA = 500;

        private const int MIN_OPENINGS = 0;
        private const int MAX_OPENINGS = 10;
        #endregion

        /// <summary>
        /// Runs the Room problem.
        /// </summary>
        public static void Run()
        {
            int numberOfRooms = ReadValue("the number of rooms to create", MIN_ROOMS, MAX_ROOMS);


            for (int i = 0; i < numberOfRooms; i++)
            {
                Console.WriteLine($"\nRoom {i + 1}:");

                int area = ReadValue("the area of the room", MIN_ROOM_AREA, MAX_ROOM_AREA);
                int doors = ReadValue("the number of doors", MIN_OPENINGS, MAX_OPENINGS);
                int windows = ReadValue("the number of windows", MIN_OPENINGS, MAX_OPENINGS);

                Room room = new Room(area, doors, windows);
                room.DisplayDetails();
            }
        }
        /// <summary>
        /// Reads an integer in a range, adding the range to the prompt automatically.
        /// </summary>
        /// <param name="label">What to ask for, e.g. "the number of doors".</param>
        /// <param name="min">Smallest allowed value.</param>
        /// <param name="max">Largest allowed value.</param>
        /// <returns>The value the user entered.</returns>
        private static int ReadValue(string label, int min, int max)
        {
            return ReadIntegerInRange($"Enter {label} ({min} - {max}): ", min, max);
        }
    }
}
