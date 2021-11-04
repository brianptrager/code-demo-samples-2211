using System;

namespace TrimmingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word or sentence: ");

            string input = Console.ReadLine();

            Console.WriteLine($"Length of input: {input.Length}");

            input = input.Trim();

            Console.WriteLine($"Length of input: {input.Length}");
        }
    }
}
