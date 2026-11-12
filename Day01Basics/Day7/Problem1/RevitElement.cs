namespace TrainingBasics.Day7.Problem1
{
    /// <summary>
    /// Day 7 - Problem 1: A Revit element with protected data (encapsulation).
    /// Task: private fields for ElementId (int) and Name (string), exposed through
    /// properties with validation: ElementId accepts positive numbers only,
    /// Name cannot be null or empty. DisplayInfo() prints the Id and Name.
    /// </summary>
    public class RevitElement
    {
        private int _elementId;
        private string _name = string.Empty;

        /// <summary>
        /// Element Id. Positive only; set once in the constructor.
        /// </summary>
        public int ElementId
        {
            get => _elementId;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(_elementId), "ElementId must be a positive number.");
                }
                _elementId = value;
            }

        }
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.", nameof(_name));
                }
                _name = value;
            }
        }

        public RevitElement(int elementId, string name)
        {
            ElementId = elementId;
            Name = name;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Element ID: {ElementId}, Name: {Name}");
        }
    }
}
