using System.Runtime.ExceptionServices;
using static TrainingBasics.Utilities;

namespace TrainingBasics.Day7.Problem2
{
    /// <summary>
    /// Day 7 - Problem 2: Create a List of FamilyInstance with Doors and Windows.
    /// Use "is" to check whether an item is a Door or Window,
    /// and "as" to cast it safely and read its specific property.
    /// </summary>
    public class FamilyInstanceProblem
    {
        /// <summary>
        /// Lists doors and windows and prints each one's specific type.
        /// </summary>
        public static void Run()
        {
            List<FamilyInstance> instances = new List<FamilyInstance>
            {
                new Door(1, "Single Panel"),
                new Window(2, "Single Hinged"),
                new Door(3, "Double Panel")
            };
            int doorCount = 0;
            int windowCount = 0;
            foreach (FamilyInstance instance in instances)
            {
                instance.DisplayInfo();
                if (instance is Door)
                {
                    doorCount++;
                }

                Window? window = instance as Window;
                if (window != null)
                {
                    windowCount++;
                }
            }
            Console.WriteLine($"\nTotal Doors: {doorCount}\n" +
                              $"Total Windows: {windowCount}");


        }
    }
}
