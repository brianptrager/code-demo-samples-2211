using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            const int MAX = 10;

            Console.WriteLine("\nWhile Loop");
            while (counter < MAX)
            {
                Console.WriteLine($"counter is less than 10: {counter}");
                counter++;
            }


            //for(int counterTwo = 1; counterTwo < MAX; counterTwo++)

            int counterTwo;

            Console.WriteLine("\nFor Loop");
            for (counterTwo = 1; counterTwo < MAX; counterTwo++)
            {
                Console.WriteLine(counterTwo);
            }

            Console.WriteLine(counterTwo);

            int counterThree = 0;

            Console.WriteLine("\nDo Loop");
            do
            {
                
                Console.WriteLine(counterThree);
                counterThree++;
            } while (counterThree < 10);
        }
    }
}
