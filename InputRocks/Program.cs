using System;

namespace InputRocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 05 - Console Input");

            var date = DateTime.Now;

            Console.WriteLine($"Happy {date.DayOfWeek}!");

            Console.Write("Enter your name: ");
            Console.ForegroundColor = ConsoleColor.Green;

            string name = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine($"Your name is {name}");

            //Retrieve input as an integer
            Console.Write("Enter your favorite number: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int favoriteNum = int.Parse(Console.ReadLine());
            Console.ResetColor();

            //Retrieve input as a double
            Console.Write("Enter your desired salary: $");
            Console.ForegroundColor = ConsoleColor.Green;
            double salary = double.Parse(Console.ReadLine());
            Console.ResetColor();

            //Order of operation impacts the operator based on the operands
            Console.WriteLine("Adding up your favorite number: " + favoriteNum + favoriteNum);
            Console.WriteLine("Adding up your favorite number: " + (favoriteNum + favoriteNum));
            Console.WriteLine(favoriteNum + favoriteNum + "Adding up your favorite number ");
            Console.WriteLine(favoriteNum + (favoriteNum + "Adding up your favorite number "));

            //String interpolation
            Console.WriteLine($"Adding up your favorite number: {name + favoriteNum + favoriteNum}");

            Console.WriteLine("Your desired salary is $" + salary);
            Console.WriteLine($"Your desired salary is {salary:C}");
        }
    }
}
