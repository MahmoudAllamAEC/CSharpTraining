namespace TrainingBasics.Day7.Problem2
{
    /// <summary>
    /// Day 7 - Problem 2: A door, derived from FamilyInstance.
    /// Task: extra property DoorType (e.g. "Single Panel", "Double Panel"),
    /// constructor chaining with base, and override DisplayInfo() to also print DoorType.
    /// </summary>
    public class Door : FamilyInstance
    {
        public string DoorType { get; private set; }

        public Door(int id, string doorType) : base(id, "Door")
        {
            DoorType = doorType;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Door Type: {DoorType}\n");


        }
    }
}
