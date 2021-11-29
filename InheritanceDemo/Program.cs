using System;
using System.Collections.Generic;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle v = new Vehicle() { Color = "Blue", Value = 40000, Year = 2021 };
            Car c = new Car() { Color = "Red", Value = 15000, Year = 2010, CarType = "Sedan" };
            Boat b = new Boat() { Color = "Yellow", Value = 20000, Year = 2012, BoatType = "Yacht", HasDrowned = false };

            vehicles.Add(v);
            vehicles.Add(c);
            vehicles.Add(b);

            foreach(Vehicle vehicle in vehicles)
            {
                if (vehicle is Car)
                {
                    Console.WriteLine(vehicle);
                    Console.WriteLine("=================================");
                }
            }

            //Console.WriteLine(v);
            //Console.WriteLine("=================================");
            //Console.WriteLine(c);
            //Console.WriteLine("=================================");
            //Console.WriteLine(b);
        }
    }
}
