using System;

namespace CoolMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Tau);

            int absValue = Math.Abs(-100);
            Console.WriteLine(absValue);

            double testCeiling = 11.95;
            Console.WriteLine($"Ceiling {Math.Ceiling(testCeiling)}");

            double testFloor = 11.99;
            Console.WriteLine($"Floor: {Math.Floor(testFloor)}");

            Console.WriteLine(Math.Max(Math.Ceiling(testCeiling), Math.Floor(testFloor)));

            const int MAX_NUM = 50;
            Console.WriteLine(Math.Min(500, MAX_NUM));

            Console.WriteLine(Math.Pow(3,4));

            Console.WriteLine(Math.Round(11.49));

            Console.WriteLine(Math.Sqrt(81));

            Console.WriteLine(Math.Sqrt(Math.Pow(3, 6)));
        }
    }
}
