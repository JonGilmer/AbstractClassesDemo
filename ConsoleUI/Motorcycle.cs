using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        // Constructor
        public Motorcycle()
        {
        }

        // Distinct Properties
        public bool has2_Cylinders { get; set; }
        public bool hasLessThan_4Wheels { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name}.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This is a motorcyle thing now.");
        }
    }
}
