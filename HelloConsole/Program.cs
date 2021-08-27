using System;
/*
 * Name: Professor BT
 * Date: 8/27/2021
 * Course: NMAD.180 - Prog. Fund. Domain I: Mobile Domain
 * Purpose: Everything you need to know about Console
 */
namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello everyone!!");
            Console.Clear(); //This clears everything in the console window

            //Adding colors to console (foreground and background colors)
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            Console.Write("This will display something, but it will not create a new line. ");
            Console.WriteLine("Adding to the previous line, but it will create a new line afterwards.");

            Console.ResetColor(); //resets to default console colors
            Console.Beep(100, 2000); //makes a sound at 100Hz (low frequency) for 2000ms (2 seconds)

        }
    }
}
