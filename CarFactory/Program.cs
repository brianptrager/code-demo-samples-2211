using System;
using System.Collections.Generic;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new Dictionary<string, Car>();

            cars.Add("1001AB", new Car());
            cars.Add("3004CD", new Car());
            cars.Add("9911FF", new Car());

            //If I only want to change the year for the car with the key "1001AB", can I do this?  Yes
            cars["1001AB"].Year = 2019;

            Car modCar = cars["1001AB"];
            Console.WriteLine(cars["1001AB"].ToString());

            modCar.Year = 2021;
            modCar.Make = "Toyota";
            modCar.Model = "Camry";
            modCar.Color = "Red";

            cars["1001AB"] = modCar;
            Console.WriteLine("\nInformation updated for car 1001AB");
            Console.WriteLine(cars["1001AB"].ToString());

            if(cars.TryGetValue("1001AB", out modCar))
            {
                Console.WriteLine("Car found!  Now let's mod it!");
                modCar.Year = DateTime.Now.Year;
            }
            else
            {
                Console.WriteLine("Car not found.");
            }

            foreach (KeyValuePair<string, Car> kvp in cars)
            {
                Console.WriteLine($"Key = {kvp.Key}, Value = {kvp.Value}");
            }

            Console.Write("Enter a key for a new car: ");
            string uniqueKey = Console.ReadLine();

            if(cars.ContainsKey(uniqueKey))
            {
                Console.WriteLine("Key already exists in cars, cannot use");
            }
            else
            {
                Console.WriteLine("Great, let's create a new car.");
            }


        }
    }
}
