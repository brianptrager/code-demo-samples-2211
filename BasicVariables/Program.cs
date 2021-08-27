using System;
using System;
/*
 * Name: Professor BT
 * Date: 8/27/2021
 * Course: NMAD.180 - Prog. Fund. Domain I: Mobile Domain
 * Purpose: Everything you need to know about string and int variables
 */
namespace BasicVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //To create a variable, make sure you have type and name
            //string is a type; message is the name for a variable
            string message = "Hello everyone!";
            string name = "Sam Bowerman";
            string anotherName = "Flavio Medina";

            Console.WriteLine(message);
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Hello " + name + " and " + anotherName);
            //OR
            Console.WriteLine("Hello {0} and {1}", name, anotherName);

            //this is called a variable declaration.
            //We "declare" or create a variable, but we haven't assigned a value yet.
            string prompt;
            //You initialize a variable by assigning a value.
            prompt = "I am taking ";
            
            //This is called a variable initialization.  Declaring and assigning in one line of code.
            int credits = 15;

            //Ways to display the same thing.  What you choose is up to you.
            Console.WriteLine(prompt + credits + " credits.");
            Console.WriteLine("{0}{1} credits.", prompt, credits);
            Console.WriteLine($"{prompt}{credits} credits.");

        }
    }
}
