using System;
/* Name: Professor BT
 * Date: 9/22/2021
 * Course: NMAD.180: Programming Fundamentals I: Mobile Domain
 * Program: Swap Meet
 * Purpose: Program to buy/sell disks
 * Caveats: I may have no clue what to do
 * */

namespace MockExam1_SwapMeet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Disk4Cheap";
            const double COST_PER_DISK = 25.75;

            Console.WriteLine("***Disk4Cheap***\n");
            Console.Write("How many disk drives are in the current inventory?: ");

            //string input = Console.ReadLine();
            //if(int.TryParse(input, out int numInput))
            if(int.TryParse(Console.ReadLine(), out int inventoryCount))
            {
                Console.Write("MENU\n\n\t1. Display current inventory value\n" +
                    "\t2. Buy disks from Disk4Cheap\n\t3. Sell disks to Disk4Cheap\n" +
                    "\t4. Exit\n" +
                    "Enter your choice (1, 2, 3, or 4): ");

                //Nested if statement
                if (int.TryParse(Console.ReadLine(), out int selection))
                {
                    //if(selection == 1)
                    switch(selection)
                    {
                        case 1: 
                            Console.WriteLine($"\nInventory Count: {inventoryCount}" +
                                $"\tValue: {COST_PER_DISK * inventoryCount:C}");
                            break;
                            
                    }
                }
                else
                {
                    Console.WriteLine("Error: The value you entered is invalid...Exiting");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Error: The value you entered is invalid...Exiting");
                Environment.Exit(0);
            }
        }
    }
}
