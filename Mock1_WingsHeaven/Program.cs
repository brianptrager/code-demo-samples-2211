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

            double subTotal = 0;
            const double TAX_RATE = 0.08;
            string receipt = "";

            Console.WriteLine("*** HEAVENLY WINGS ***\n");

            //First Menu
            Console.Write($"Type of Wings:\n\t{"1. Boneless",-16}{BONELESS_WINGS_PRICE, 9:C}" +
                $"\n\t{"2. Traditional",-16}{TRADITIONAL_WINGS_PRICE,9:C}" +
                $"\n\t{"3. Both",-16}{BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE,9:C}" +
                $"\nEnter your selection: ");

            switch(Console.ReadLine())
            {
                case "1": subTotal += BONELESS_WINGS_PRICE;
                    receipt += $"{"Boneless",-25}{BONELESS_WINGS_PRICE,-9:C}";
                    break;
                case "2": subTotal += TRADITIONAL_WINGS_PRICE;
                    receipt += $"{"Traditional",-25}{TRADITIONAL_WINGS_PRICE,-9:C}";
                    break;
                case "3": subTotal += BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE;
                    receipt += $"{"Both Wings",-25}{BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE,-9:C}";
                    subTotal -= (BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE) - COMBO_WINGS_PRICE;
                    receipt += $"{"\nDiscount",-25}{((BONELESS_WINGS_PRICE + TRADITIONAL_WINGS_PRICE) - COMBO_WINGS_PRICE) * -1,-9:C}";
                    break;
            }

            //Second menu
            Console.Write($"\n\nType of Sauce:\n\t{"1. Buffalo Sauce",-16}{BUFFALO_SAUCE_PRICE,9:C}" +
                $"\n\t{"2. Mild Sauce",-16}{MILD_SAUCE_PRICE,9:C}" +
                $"\n\t{"3. BBQ Sauce",-16}{BBQ_SAUCE_PRICE,9:C}" +
                $"\n\t{"4. Plain",-16}{"No Charge",9}" +
                $"\nEnter your selection: ");

            switch (Console.ReadLine())
            {
                case "1":
                    subTotal += BUFFALO_SAUCE_PRICE;
                    break;
                case "2":
                    subTotal += MILD_SAUCE_PRICE;
                    break;
                case "3":
                    subTotal += BBQ_SAUCE_PRICE;
                    break;
            }

            //Third Menu
            Console.Write($"\n\nDo you want a side order:\n\t{"1. Waffle Fries",-16}{WAFFLE_FRIES_PRICE,9:C}" +
                $"\n\t{"2. Onion Rings",-16}{ONION_RINGS_PRICE,9:C}" +
                $"\n\t{"3. Both",-16}{WAFFLE_FRIES_PRICE + ONION_RINGS_PRICE,9:C}" +
                $"\nEnter your selection: ");

            switch (Console.ReadLine())
            {
                case "1":
                    subTotal += WAFFLE_FRIES_PRICE;
                    break;
                case "2":
                    subTotal += ONION_RINGS_PRICE;
                    break;
                case "3":
                    subTotal += WAFFLE_FRIES_PRICE + ONION_RINGS_PRICE;
                    break;
            }

            Console.WriteLine(receipt);

        }
    }
}
