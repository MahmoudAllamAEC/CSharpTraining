using static TrainingBasics.Utilities;

namespace TrainingBasics.Day7.Problem1
{
    /// <summary>
    /// Day 7 - Problem 1: Create sample elements (e.g. a Wall and a Door)
    /// and call DisplayInfo() on each.
    /// </summary>
    public class RevitElementProblem
    {

        public static void Run()
        {
            var wall = new RevitElement(1, "Wall");
            var door = new RevitElement(2, "Door");

            wall.DisplayInfo();
            door.DisplayInfo();
        }
    }
}
