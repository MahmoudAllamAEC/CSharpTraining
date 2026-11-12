using TrainingBasics.Day1;
using TrainingBasics.Day3;
using TrainingBasics.Day4;
using TrainingBasics.Day5;
using TrainingBasics.Day6.Problem1;
using TrainingBasics.Day6.Problem2;
using TrainingBasics.Day7.Problem1;
using TrainingBasics.Day7.Problem2;
using TrainingBasics.Day7.Problem3;
using TrainingBasics.Day7.Problem4;
using TrainingBasics.Day8;

namespace TrainingBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // week 1
            #region Day 1&2
            HelloWorldProblem.Run();
            BasicCalculator.Run();
            NumberSwapper.Run();
            FullNameBuilder.Run();
            SubstringExtractor.Run();
            #endregion

            #region Day 3
            EvenOrOdd.Run();
            MultiplicationTable.Run();
            ReverseString.Run();
            RightAngleTriangle.Run();
            ReverseRightAngleTriangle.Run();
            CenteredPyramid.Run();
            #endregion

            #region Day 4
            StorePrintArrayElements.Run();
            AccessArrayElement.Run();
            FindMaxMinArray.Run();
            RoomAreaAnalysis.Run();
            SortArrayAscending.Run();
            #endregion

            #region Day 5
            DoorWindowAnalysis.Run();
            ListFilteringMethods.Run();
            #endregion

            // week 2
            #region Day 6
            RectangleProblem.Run();
            RoomProblem.Run();
            #endregion

            #region Day 7
            RevitElementProblem.Run();
            FamilyInstanceProblem.Run();
            ElementGeometryProblem.Run();
            SelectableProblem.Run();
            #endregion

            #region Day 8
            DivideTwoNumbers.Run();
            FileReading.Run();
            #endregion



        }
    }
}
