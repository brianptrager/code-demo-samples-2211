using System;
/*
 * Name: Professor BT
 * Date: 8/30/2021
 * Course: NMAD.180 - Prog. Fund. Domain I: Mobile Domain
 * Purpose: Everything you need to know about expressions and more datatypes
 */
namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 17;
            double floatNum = 40.5;

            //int add = num1 + floatNum;  Cannot do this!
            int add = num1 + (int)floatNum;
            double floatAdd = num1 + floatNum;

            Console.WriteLine($"Add: {add}");
            Console.WriteLine($"Float Add: {floatAdd}");

            Console.WriteLine($"Postfix operator: {num1++}"); //17
            Console.WriteLine($"Prefix operator: {++num1}"); //19

            floatNum++;
            Console.WriteLine($"Float Number after Postfix operator: {floatNum}"); //41.5

            double crazyNum = floatNum++ + (--num1 + num1++);
            Console.WriteLine($"Crazy stuff: {crazyNum}"); //77.5
        }
    }
}
