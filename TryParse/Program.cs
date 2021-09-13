using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a whole number: ");
            double total = 0;
            //string data = "abc";
            //int converted = 0;
            //if(int.TryParse(data, out converted))

            //int num = int.Parse(Console.ReadLine());
            //if(int.TryParse(Console.ReadLine(), out int num))
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                //double total = num + num;
                total = num + num;
                Console.WriteLine(total);
                Console.WriteLine("You entered a number.  You are indeed very smart.");
            }
            else
            {
                Console.WriteLine("Bad data, you cannot follow simple instructions.");
            }
            
            total += num; //total = total + num;
            Console.WriteLine(total);
        }
    }
}
