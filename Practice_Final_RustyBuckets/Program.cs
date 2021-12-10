using System;
//Name: Professor BT
//Date: 12/8/2021
//Course: NMAD.180
//Purpose: Help students understand the solution to the practice final exam

namespace Practice_Final_RustyBuckets
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "*** Rusty Bucket's Car Emporium Salary Calculator ***";
            string salespersonName, sales;
            int carSales = 0, truckSales = 0, vanSales = 0;
            const double BASE_SALARY = 2000, BONUS = 500, CAR_COMMISSSION = 150, VAN_COMMISSION = 225, TRUCK_COMMISSION = 250, BONUS_THRESHOLD = 12;

            Console.WriteLine($"{title}\n");

            Console.Write("Enter the salesperson's name: ");
            salespersonName = Console.ReadLine();

            //Check if user enters name, exit if no name entered
            if (salespersonName.Trim() == "")
            {
                Console.WriteLine("\nYou must enter the salesperson's name.\nExiting...");
                Environment.Exit(0);
            }

            #region Car Sales
            Console.Write($"How many cars did {salespersonName} sell this month? ");
            sales = Console.ReadLine();

            //Another way to check if user enters something, exit if no number entered
            if (sales.Trim().Length == 0)
            {
                Console.WriteLine("\nYou must enter a valid number!\nExiting...");
                Environment.Exit(0);
            }
            //Check if input is a number
            if (int.TryParse(sales, out carSales))
            {
                //Program cannot allow negative numbers
                if (carSales < 0)
                {
                    Console.WriteLine("\nYou cannot enter a negative number!\nExiting...");
                    Environment.Exit(0);
                }
            }
            #endregion

            #region Van Sales
            Console.Write($"How many vans did {salespersonName} sell this month? ");
            sales = Console.ReadLine();

            //Another way to check if user enters something, exit if no number entered
            if (sales.Trim().Length == 0)
            {
                Console.WriteLine("\nYou must enter a valid number!\nExiting...");
                Environment.Exit(0);
            }
            //Check if input is a number
            if (int.TryParse(sales, out vanSales))
            {
                //Program cannot allow negative numbers
                if (vanSales < 0)
                {
                    Console.WriteLine("\nYou cannot enter a negative number!\nExiting...");
                    Environment.Exit(0);
                }
            }
            #endregion

            #region Truck Sales
            Console.Write($"How many trucks did {salespersonName} sell this month? ");
            sales = Console.ReadLine();

            //Another way to check if user enters something, exit if no number entered
            if (sales.Trim().Length == 0)
            {
                Console.WriteLine("\nYou must enter a valid number!\nExiting...");
                Environment.Exit(0);
            }
            //Check if input is a number
            if (int.TryParse(sales, out truckSales))
            {
                //Program cannot allow negative numbers
                if (truckSales < 0)
                {
                    Console.WriteLine("\nYou cannot enter a negative number!\nExiting...");
                    Environment.Exit(0);
                }
            }
            #endregion

            Console.WriteLine($"\n{title}\n");

            #region Calculation
            double carCommission = carSales * CAR_COMMISSSION;
            double vanCommission = vanSales * VAN_COMMISSION;
            double truckCommission = truckSales * TRUCK_COMMISSION;
            
            double bonus = 0;

            if ((carSales + vanSales + truckSales) > BONUS_THRESHOLD)
                bonus = BONUS;

            double total = BASE_SALARY + carCommission + vanCommission + truckCommission + bonus;
            #endregion

            #region Final Display
            Console.WriteLine($"   {"Base Salary", -13}{BASE_SALARY, 13:C}");
            Console.WriteLine("=>Commission<=");
            Console.WriteLine($"{carSales,2} {"Cars sold:", -13}{carCommission, 13:C}");
            Console.WriteLine($"{vanSales,2} {"Vans sold:", -13}{vanCommission,13:C}");
            Console.WriteLine($"{truckSales,2} {"Trucks sold:", -13}{truckCommission,13:C}");
            Console.WriteLine($"   {"Bonus", -13}{bonus, 13:C}");
            Console.WriteLine($"   {"Total", -13}{total, 13:C}");

            Console.WriteLine("\n*** Goodbye ***");
            #endregion
        }
    }
}
