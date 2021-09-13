using System;

namespace Switching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you like this app? (y/n): ");
            

            switch(Console.ReadLine())
            {
                //string input = Console.ReadLine();
                //if(input == "y" || input == "yes")
                case "y":
                case "yes":
                            Console.WriteLine("Awesome sauce!");
                            break;

                case "n":
                case "no":
                case "nope":
                            Console.WriteLine("That sucks, we'll bother you again sometime.");
                            break;


                default: Console.WriteLine("Cannot compute this.");
                            break;
            }
        }
    }
}
