using System;

namespace ProgramExit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 'a' or 'b': ");
            string input = Console.ReadLine();
            if(input == "a" || input == "b")
                Console.WriteLine("You can follow instructions.");
            else
            {
                Console.WriteLine("Umm, not sure what to tell you.");
                Environment.Exit(0);
            }

            Console.WriteLine("Thank you for using this very very very simple program.");
        }
    }
}
