using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        // Cunstructor
        public Vehicle()
        {
        }

        // Properties
        public string Year { get; set; } = "Any Year";
        public string Make { get; set; } = "Any Make";
        public string Model { get; set; } = "Any Model";

        // Abstract Method
        public abstract void DriveAbstract();

        // Virtual Method
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"{GetType().Name}");
        }

    }
}
