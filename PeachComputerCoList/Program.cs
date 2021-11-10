using System;
using System.Collections.Generic;

namespace PeachComputerCoList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make sure to add "using System.Collections.Generic;" at the top
            //List of computers -- note that size is NOT specified
            List<Computer> computers = new List<Computer>();

            computers.Add(new Computer());
            computers.Add(new Computer("Kali", "SSD", "Desktop", "Dell"));
            computers.Add(new Computer("Kali", "SSD", "Desktop", "Gateway", 16));

            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < computers.Count; i++)
            {
                Console.WriteLine($"Computer #{(i + 1)}");
                Console.WriteLine(computers[i]);
            }

            Console.WriteLine($"There are {computers.Count} computers in the list");

            //Insert a new computer in element (index) 2
            //The computer object that is already in index 2 will be bumped to the next element
            computers.Insert(2, new Computer("Windows", "SSD", "Laptop", "Microsoft"));

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < computers.Count; i++)
            {
                Console.WriteLine($"Computer #{(i + 1)}");
                Console.WriteLine(computers[i]);
            }
            Console.WriteLine($"There are {computers.Count} computers in the list");

            //This removes a computer object that is in index #1 (second element in the List)
            computers.RemoveAt(1);

            Console.ForegroundColor = ConsoleColor.Yellow;
            
            for (int i = 0; i < computers.Count; i++)
            {
                Console.WriteLine($"Computer #{(i + 1)}");
                Console.WriteLine(computers[i]);
            }
            Console.WriteLine($"There are {computers.Count} computers in the list");
            //foreach(Computer c in computers)
            //{
            //    Console.WriteLine(c);
            //}

            //Array is fixed so I had to make up a number to store computers.
            //Computer[] computers = new Computer[100];

            //How to add computers to an array -- just for comparison purposes
            //computers[0] = new Computer();
            //computers[1] = new Computer("Kali", "SSD", "Desktop", "Dell");
            //computers[2] = new Computer("Kali", "SSD", "Desktop", "Gateway", 16);

        }
    }
}
