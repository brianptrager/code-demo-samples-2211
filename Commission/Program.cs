using System;
/*
 * Name: Professor BT
 * Date: 9/10/2021
 * Course: NMAD.180 - Prog. Fund. Domain I: Mobile Domain
 * Purpose: Calculating a salesperson's commission
 */
namespace Commission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting up variables and constants
            const double MIN_SALES = 10000, TIER2_SALES = 100000, BASIC_COMMISSION_RATE = 0.07, UPGRADED_COMMISSION_RATE = 0.10;
            double commission = 0;

            Console.Write("Enter salesperson's name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string name = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Enter sales amount: $");
            Console.ForegroundColor = ConsoleColor.Green;
            double sales = double.Parse(Console.ReadLine());
            Console.ResetColor();

            //Calculates commission if sales meets or exceeds minimum sales expectation
            //if (sales >= MIN_SALES)
            //{
            //    commission = sales * BASIC_COMMISSION_RATE;
            //    if (sales > TIER2_SALES) //Calculate new commission if sales exceeds $100K
            //    {
            //        commission = sales * UPGRADED_COMMISSION_RATE;
            //    }
            //}

            if (sales > TIER2_SALES)
            {
                commission = sales * UPGRADED_COMMISSION_RATE;
            }
            else if (sales >= MIN_SALES)
            {
                commission = sales * BASIC_COMMISSION_RATE;
            }

            Console.WriteLine($"\n{name}'s Commission: {commission:C}");
        }
    }
}
