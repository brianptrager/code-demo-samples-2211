using System;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[10];

            Car[] cars = new Car[10];

            //First car object EVER!!!
            Car car = new Car();
            car.Year = 1950;
            car.Make = "Ford";
            car.Model = "Mustang GT500";
            car.Color = "Black";
            car.CarType = "2-door sport";
            cars[0] = car;

            //Second car object
            Car car2 = new Car();
            car2.Year = 1865;
            car2.Make = "Jeep";
            car2.Model = "Wrangler Rubicon";
            car2.Color = "White";
            car2.CarType = "4-door 4x4 SUV";
            cars[1] = car2;


            //Object Initializer Syntax
            cars[2] = new Car() { Year = 2012, Make = "Toyota", Model = "Camry", Color = "Silver", CarType = "Sedan" };

            foreach(Car c in cars)
            {
                if (c != null)
                    Console.WriteLine(c.GetCarInformation());
            }

            //Console.WriteLine(car.GetCarInformation(false));
            //Console.WriteLine(car2.GetCarInformation());

        }
    }
}
