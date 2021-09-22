using System;
/* Name: Professor BT
 * Date: 9/22/2021
 * Course: NMAD.180: Programming Fundamentals I: Mobile Domain
 * Program: Wings Heaven
 * Purpose: Program to take orders for food
 * Caveats: This makes me hungry!
 * */

namespace Mock1Exam_WingsHeaven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cost for each food item or combo
            const double BONELESS_WINGS_PRICE = 7.99;
            const double TRADITIONAL_WINGS_PRICE = 9.99;
            const double COMBO_DISCOUNT_RATE = 0.18;
            const double COMBO_WINGS_PRICE = (BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE) - ((BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE) * COMBO_DISCOUNT_RATE);
            //sauce
            const double BUFFALO_SAUCE_PRICE = 0.29;
            const double MILD_SAUCE_PRICE = 0.39;
            const double BBQ_SAUCE_PRICE = 0.29;
            //sides
            const double WAFFLE_FRIES_PRICE = 3.49;
            const double ONION_RINGS_PRICE = 2.49;

            Console.WriteLine("*** HEAVENLY WINGS ***\n");

            Console.Write($"Type of Wings:\n\t{"1. Boneless",-20}{BONELESS_WINGS_PRICE, 9:C}" +
                $"\t{"2. Traditional",-20}{TRADITIONAL_WINGS_PRICE,9:C}\n" +
                $"\t{"1. Both",-20}{BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE,9:C}" +
                $"Enter your selection: ");


        }
    }
}
