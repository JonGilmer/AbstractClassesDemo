using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Vehicles

            var vehicleList = new List<Vehicle>();


            Car car1 = new Car()
            {
                has4_OrMore_Wheels = true,
                canHold_Multiple_People = true,
                Year = "2019",
                Make = "Bugatti",
                Model = "Chiron Super Sport"
            };

            vehicleList.Add(car1);

            Motorcycle chopper1 = new Motorcycle()
            {
                has2_Cylinders = true,
                hasLessThan_4Wheels = true,
                Year = "2016",
                Make = "Harley-Davidson",
                Model = "883 Iron SPORTSTER"
            };

            vehicleList.Add(chopper1);

            Vehicle v1 = new Car()
            {
                has4_OrMore_Wheels = true,
                canHold_Multiple_People = true,
                Year = "2004",
                Make = "Maserati",
                Model = "MC12"
            };

            vehicleList.Add(v1);

            Vehicle v2 = new Motorcycle()
            {
                has2_Cylinders = true,
                hasLessThan_4Wheels = true,
                Year = "2014",
                Make = "Victory",
                Model = "Boardwalk"
            };

            vehicleList.Add(v2);


            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                Console.WriteLine("");
            }

            Console.WriteLine("Car Methods: ");
            car1.DriveAbstract();
            Console.WriteLine("");

            Console.WriteLine("Motorcycle Methods: ");
            chopper1.DriveAbstract();
            chopper1.DriveVirtual();
            Console.WriteLine("");




            #endregion            
            Console.ReadLine();
        }
    }
}
