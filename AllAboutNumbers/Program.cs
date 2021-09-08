using System;
/*
 * Name: Professor BT
 * Date: 9/3/2021
 * Course: NMAD.180 - Prog. Fund. Domain I: Mobile Domain
 * Purpose: Everything you need to know about numbers
 */
namespace AllAboutNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 30000;
            short b = 30000;
            
            //This will create an overflow
            //That means the total is TOO BIG for a short variable
            short total = (short)(a + b);

            Console.WriteLine($"Max Value for short: {short.MaxValue}");
            Console.WriteLine($"{total}");

            double c = 14.56;
            decimal d = 34252345.43m;
            float f = 14.56f;
            var total2 = a + b + f;
            Console.WriteLine($"{total2}");

            total2 *= total2 * 100000000;
            Console.WriteLine($"{total2}");
            //Make sure one of the operands is a double/float for greater precision
            Console.WriteLine($"\n{((5 + 6) / 2.0)}");

            Console.WriteLine($"{byte.MaxValue}");
            Console.WriteLine($"{byte.MinValue}");

            sbyte b1 = -15;
            Console.WriteLine($"{sbyte.MaxValue}");
            Console.WriteLine($"{sbyte.MinValue}");

        }
    }
}
