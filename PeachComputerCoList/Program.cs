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

            computers.Insert(2, new Computer("Windows", "SSD", "Laptop", "Microsoft"));

            Console.WriteLine($"There are {computers.Count} computers in the list");

            for(int i = 0; i < computers.Count; i++)
            {
                Console.WriteLine($"Computer #{(i + 1)}");
                Console.WriteLine(computers[i]);
            }

            computers.RemoveAt(1);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"There are {computers.Count} computers in the list");

            for (int i = 0; i < computers.Count; i++)
            {
                Console.WriteLine($"Computer #{(i + 1)}");
                Console.WriteLine(computers[i]);
            }

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
