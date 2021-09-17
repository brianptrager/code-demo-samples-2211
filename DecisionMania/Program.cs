using System;

namespace DecisionMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15;
            int y = 2;
            int z = 10;

            if(!(!(x > 5) || (y >= 2)) && (z == 10))
                Console.WriteLine("This is true!");
            else
                Console.WriteLine("This is false");

            //Number must be between 1 and 5
            if((x >= 1) && (x <= 5))
            {
                Console.WriteLine($"{x} is between 1 and 5");
            }

            Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //if(Int64.TryParse(input, out Int64 num))
            if(Int64.TryParse(Console.ReadLine(), out Int64 num))
            {
                Console.WriteLine($"You did enter a number {num}");
            }
            else
                Console.WriteLine("You did not enter a number or the number was too big! :(");


            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine();
            username = username.ToLower();

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            if(username == "admin" && password == "codesnob")
            {
                Console.WriteLine("Welcome to Area 51");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

        }
    }
}
