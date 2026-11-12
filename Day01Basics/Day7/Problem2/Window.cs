namespace TrainingBasics.Day7.Problem2
{
    /// <summary>
    /// Day 7 - Problem 2: A window, derived from FamilyInstance.
    /// Task: extra property WindowType (e.g. "Sliding", "Fixed"),
    /// constructor chaining with base, and override DisplayInfo() to also print WindowType.
    /// </summary>
    public class Window : FamilyInstance
    {
        public string WindowType { get; private set; }

        public Window(int id, string windowType) : base(id, "Window")
        {
            WindowType = windowType;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Window Type: {WindowType}\n");
        }
    }
}
