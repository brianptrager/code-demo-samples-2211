using System;
/*
 * Name: Professor BT
 * Date: 9/8/2021
 * Course: NMAD.180 - Prog. Fund. Domain I: Mobile Domain
 * Purpose: Everything you need to know about basic decisions
 */
namespace BasicDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 125;
            const int MIN = 100;
            Console.Write($"Enter any number between {MIN} and {MAX}: ");

            int inputNum = int.Parse(Console.ReadLine());
            

            //if(inputNum <= MAX)
            if(inputNum >= MIN && inputNum <= MAX)
            {
                //Console.WriteLine($"This number is valid as an integer equal to or less than {MAX}.");
                Console.WriteLine($"{inputNum} is valid because it is between {MIN} and {MAX}");
            }
        }
    }
}
