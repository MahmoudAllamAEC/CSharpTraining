using System;
using System.Collections.Generic;
using System.Text;
using static TrainingBasics.Utilities;


namespace TrainingBasics.Day5
{
    /// <summary>
    /// Day 5 - Problem 2: Door/Window Analysis
    /// </summary>
    public class DoorWindowAnalysis
    {
        #region Constants
        // constants for the minimum and maximum number of rooms
        private const int MIN_ROOMS = 1;
        private const int MAX_ROOMS = 10;

        // constants for the minimum and maximum number of doors 
        private const int MIN_DOORS = 0;
        private const int MAX_DOORS = 10;

        // constants for the minimum and maximum number of windows
        private const int MIN_WINDOWS = 0;
        private const int MAX_WINDOWS = 10;
        #endregion

        /// <summary>
        /// Reads doors and windows for each room, then prints totals, averages,
        /// the rooms with the most doors and windows, and room comparisons.
        /// </summary>
        public static void Run()
        {
            int roomCount = ReadIntegerInRange($"Enter the number of rooms ({MIN_ROOMS}-{MAX_ROOMS}): ",
                                               MIN_ROOMS,
                                               MAX_ROOMS);

            //create the doors array
            int[] doors = new int[roomCount];
            for(int i = 0; i < roomCount; i++)
                doors[i] = ReadIntegerInRange($"Enter the number of doors in room {i + 1}: ",MIN_DOORS, MAX_DOORS);
           
            // create the windows array
            int[] windows = new int[roomCount];
            for(int i = 0; i < roomCount; i++)
                windows[i] = ReadIntegerInRange($"Enter the number of windows in room {i + 1}: ",
                                                MIN_WINDOWS,
                                                MAX_WINDOWS);


            // printing section

            Console.WriteLine($"Total doors and total windows : " +
                              $"doors ={TotalDoors(doors)} " +
                              $"windows ={TotalWindows(windows)}");

            Console.WriteLine($"Average doors and windows per room : " +
                              $"doors ={AveragePerRoom(doors)} " +
                              $"windows ={AveragePerRoom(windows)}");

            Console.WriteLine($"Room(s) with the most doors and windows : " +
                              $"doors ={RoomWithMaxDoors(doors)+1} " +
                              $"windows ={RoomWithMaxWindows(windows)+1} ");

            Console.WriteLine($"List of rooms that have more windows than doors :" +
                              $"{string.Join(", ", CompareBetweenArrays(windows,doors))}");

            Console.WriteLine($"List of rooms that have more doors than windows :" +
                             $"{string.Join(", ", CompareBetweenArrays(doors, windows))}");
            



        }

        /// <summary>
        /// takes array1 and see how many values of it is more than array2
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns> a list of string containg all the indexes that are correct</returns>
        public static List<string> CompareBetweenArrays(int[] array1 , int[] array2)
        {
            List<string> compareBetweenArrays = new List<string>();
            for (int i = 0; i < array1.Length; i++)
                if (array1[i] >array2[i])
                    compareBetweenArrays.Add($"Room {i + 1}");
            return compareBetweenArrays;
        }
        /// <summary>
        /// give the sum number of all doors
        /// </summary>
        /// <param name="doors"></param>
        /// <returns> sum of doors </returns>
        public static int TotalDoors(int[] doors)
        {
            return doors.Sum();
        }
        /// <summary>
        /// give the sum number of all windows 
        /// </summary>
        /// <param name="windows"></param>
        /// <returns> sum of windows </returns>
        public static int TotalWindows(int[] windows)
        {
            return windows.Sum();
        }

        /// <summary>
        /// gives the average of the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>doube average</returns>
        public static double AveragePerRoom(int[] array)
        {
            return (double)array.Sum() / array.Length;
        }

        /// <summary>
        /// gives the index of the room with most doors
        /// </summary>
        /// <param name="doors"></param>
        /// <returns>index</returns>
        public static int RoomWithMaxDoors(int[] doors)
        {
            return Array.IndexOf(doors, doors.Max());
        }

        /// <summary>
        /// gives the index of the room with most windows
        /// </summary>
        /// <param name="windows"></param>
        /// <returns>index</returns>
        public static int RoomWithMaxWindows(int[] windows)
        {
            return Array.IndexOf(windows, windows.Max());

        }
    }
}
