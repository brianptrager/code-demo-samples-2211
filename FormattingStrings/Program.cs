using System;
/*
 * Name: Professor BT
 * Date: 9/3/2021
 * Course: NMAD.180 - Prog. Fund. Domain I: Mobile Domain
 * Purpose: Everything you need to know about formatting strings
 */
namespace FormattingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escape character - \
            //How to print forward slash
            //Console.WriteLine("File saved c:\\professorbt\\Documents");
            Console.WriteLine(@"File saved c:\professorbt\Documents");

            //Creating tabs \t
            Console.WriteLine("Tab1\tTab2\tTab3\t");

            string name1 = "John Doe";
            string name2 = "Jane Doe";
            string name3 = "Jackie Doe";

            //Fancy string interpolation formatting
            Console.WriteLine($"{name1}\t{name2}\t{name3}");

            string firstName1 = "John";
            string firstName2 = "Jane";
            string firstName3 = "Jackie";
            string lastName = "Doe";
            Console.WriteLine($"{firstName1} {lastName}\n" +
                $"{firstName2} {lastName}\n{firstName3} {lastName}");

            //Fancy formatting
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{firstName1,-10} {lastName}\n" +
                $"{firstName2,-10} {lastName}\n{firstName3,-10} {lastName}");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n\n{firstName1,15} {lastName}\n" +
                $"{firstName2,15} {lastName}\n{firstName3,15} {lastName}");

            //Number formatting
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            double num = 14;
            double num2 = 14.567890;
            Console.WriteLine($"\n{num:#.##}");
            Console.WriteLine($"\n{num2:#.####}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            double salesTax = 0.0825;
            Console.WriteLine($"{salesTax:P}");
            Console.WriteLine($"Total: {num2,-10:C2}Tax: {(num2 * salesTax),-6:C2}");
            double num3 = 1234.56;
            Console.WriteLine($"Total: {num3,-10:C2}Tax: {(num3 * salesTax),-6:C2}");

            Console.ResetColor();
        }
    }
}
