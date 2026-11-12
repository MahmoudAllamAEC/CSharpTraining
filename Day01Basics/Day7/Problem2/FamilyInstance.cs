namespace TrainingBasics.Day7.Problem2
{
    /// <summary>
    /// Day 7 - Problem 2: Base class for family instances (inheritance).
    /// Task: Id (int) and Category (string, e.g. "Door" or "Window"),
    /// a constructor to set them, and DisplayInfo() that prints Id and Category
    /// (derived classes must be able to override it).
    /// </summary>
    public class FamilyInstance
    {
        public int Id { get; private set; }
        public string Category { get; private set; }


        public FamilyInstance(int id, string category)
        {
            Id = id;
            Category = category;
        }

        /// <summary>
        /// Prints Id and Category. Derived classes can override it.
        /// </summary>
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}\nCategory: {Category}\n");
        }


    }
}
