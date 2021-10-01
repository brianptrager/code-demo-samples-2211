using System;

namespace LoopsWithInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to start: ");
            int startNum = int.Parse(Console.ReadLine());

            //How do I repeat this question if the user is a well, you know?
            #region firstExample
            //Console.Write("Enter a number to end: ");
            //int endNum = int.Parse(Console.ReadLine());

            //while (endNum < startNum)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("End number is too small. Try again.");
            //    Console.ResetColor();
            //    Console.Write("Enter a number to end: ");
            //    endNum = int.Parse(Console.ReadLine());
            //}
            #endregion

            #region SecondExample
            int endNum = 0;
            while (true)
            {
                Console.Write("Enter a number to end: ");
                endNum = int.Parse(Console.ReadLine());

                if (endNum < startNum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("End number is too small. Try again.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }
            #endregion
            #region whileLoop
            //while (startNum <= endNum)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    if (startNum % 10 == 0)
            //        Console.ForegroundColor = ConsoleColor.Cyan;

            //    Console.WriteLine(startNum);

            //    startNum++;

            //}
            #endregion
            int counter = 0;

            for (; startNum <= endNum; startNum++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (startNum % 10 == 0)
                    Console.ForegroundColor = ConsoleColor.Cyan;
                counter++;
                Console.WriteLine(startNum);
            }
            //El cheapo!
            //Console.WriteLine(endNum - startNum);
            Console.ResetColor();
            Console.WriteLine($"\nNumber of loops: {counter}");
        }
    }
}
