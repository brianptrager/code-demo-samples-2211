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
            const int MINIMUM_NUM = 1;

            Console.WriteLine("***Disk4Cheap***\n");
            Console.Write("How many disk drives are in the current inventory?: ");

            //string input = Console.ReadLine();
            //if(int.TryParse(input, out int numInput))
            if(int.TryParse(Console.ReadLine(), out int inventoryCount))
            {
                Console.Write("\nMENU\n\n\t1. Display current inventory value\n" +
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

                        case 2:
                            Console.WriteLine("How many disks would you like to purchase?");
                            if (int.TryParse(Console.ReadLine(), out int purchaseCount))
                            {
                                if((purchaseCount >= MINIMUM_NUM) && (purchaseCount <= inventoryCount))
                                {
                                    inventoryCount -= purchaseCount;
                                    //inventoryCount = inventoryCount - purchaseCount;
                                    //Console.WriteLine($"\nInventory Count: {inventoryCount}" +
                                    //$"\tValue: {COST_PER_DISK * inventoryCount:C}");
                                }
                                else
                                {
                                    Console.WriteLine($"Cannot purchase more than what is available in inventory: {inventoryCount}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error: The value you entered is invalid...Exiting");
                                Environment.Exit(0);
                            }
                            break; //end case 2

                        case 3:
                            Console.WriteLine("How many disks would you like to sell?");
                            if (int.TryParse(Console.ReadLine(), out int sellCount))
                            {
                                if ((sellCount >= MINIMUM_NUM))
                                {
                                    inventoryCount += sellCount;
                                    //inventoryCount = inventoryCount - purchaseCount;
                                    //Console.WriteLine($"\nInventory Count: {inventoryCount}" +
                                    //$"\tValue: {COST_PER_DISK * inventoryCount:C}");
                                }
                                else
                                {
                                    Console.WriteLine($"Cannot sell for less than {MINIMUM_NUM}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error: The value you entered is invalid...Exiting");
                                Environment.Exit(0);
                            }
                            break; //end case 3
                        default:
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

            Console.WriteLine($"\nInventory Count: {inventoryCount}" +
                              $"\tValue: {COST_PER_DISK * inventoryCount:C}");
            Console.WriteLine("Program End ... exiting");
        }
    }
}
