using System;

namespace SimpleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloWorld(); //call the HelloWorld method
            //HelloWorld();

            DisplayMessage("Good morning");
            DisplayMessage("We will learn methods today.");
            DisplayMessage("Parameters are awesome!!", ConsoleColor.Cyan);
            DisplayMessage("Colors are fun!", ConsoleColor.Green);
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void DisplayMessage(string message, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
        //Simple HelloWorld message being displayed to the Console window
        private static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
