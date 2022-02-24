using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
        }

        // Distinct Properties
        public bool has4_OrMore_Wheels { get; set; }
        public bool canHold_Multiple_People { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"This {GetType().Name} is a { GetType().BaseType.Name}.");
        }
    }
}
