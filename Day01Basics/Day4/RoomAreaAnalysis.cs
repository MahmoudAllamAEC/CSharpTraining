using System;
using System.Collections.Generic;
using System.Text;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day4
{
    /// <summary>
    /// Day 4 - Problem 4: Room Area Analysis
    /// </summary>
    public class RoomAreaAnalysis
    {
        private const int MAX_ROOMS = 25;
        private const int MIN_ROOMS = 1;
        private const double SMALL_ROOM_LIMIT = 10;
        private const double LARGE_ROOM_LIMIT = 20;
        /// <summary>
        /// takes the number of rooms and each room's area from the user,
        /// calculates the total area, and counts the number of small,
        /// medium, and large rooms.
        /// </summary>
        public static void Run()
        {
            double[] rooms = ReadNumberArray($"Enter the number of rooms ({MIN_ROOMS} to {MAX_ROOMS}): ",
                                             MIN_ROOMS,
                                             MAX_ROOMS);

            double totalArea = 0;
            int smallRooms = 0;
            int mediumRooms = 0;
            int largeRooms = 0;

            foreach (double area in rooms)
            {
                totalArea += area;

                if (area < SMALL_ROOM_LIMIT)
                    smallRooms++;
                else if (area < LARGE_ROOM_LIMIT)
                    mediumRooms++;
                else
                    largeRooms++;

            }

            double averageArea = totalArea / rooms.Length;

            Console.WriteLine($"Total Area = {totalArea}");
            Console.WriteLine($"Average Area = {averageArea}");
            Console.WriteLine($"Small Rooms: {smallRooms}");
            Console.WriteLine($"Medium Rooms: {mediumRooms}");
            Console.WriteLine($"Large Rooms: {largeRooms}");



        }
    }
}
