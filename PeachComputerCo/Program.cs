using System;

namespace PeachComputerCo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console is a static class
            //WriteLine is a static overloaded method
            //Console.WriteLine("Try to insert null");

            //string input = null;
            //if (input == null)
            //    input = "";
            //Console.WriteLine(input);


            Computer[] computers = new Computer[100];

            computers[0] = new Computer();
            computers[1] = new Computer("Kali", "SSD", "Desktop", "Dell");
            computers[2] = new Computer("Kali", "SSD", "Desktop", "Gateway", 16);
            

            int counter = 0;
            foreach(Computer c in computers)
            {
                if (computers[counter] != null)
                {
                    Console.WriteLine(computers[counter]);
                    //Console.WriteLine($"Trade-in Value: {Computer.DetermineValue(computers[counter].Brand)}\n");
                }
                counter++;
            }
            //Computer c = null;
            //for(int i = 0; i < computers.Length; i++)
            //{
            //    c = computers[i];
            //    if(c != null)
            //        Console.WriteLine(c);
            //}

            Math.Max(5, 50);
        }
    }
}
