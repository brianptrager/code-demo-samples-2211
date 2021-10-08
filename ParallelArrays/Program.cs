using System;

namespace ParallelArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int COUNT = 50000;
            string[] names = new string[COUNT];
            int[] favoriteNumbers = new int[COUNT];

            string[] menu = { "Add a name", "Edit your name", "Delete your name", "Exit program" };

            while (true)
            {

                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menu[i]}");
                }
                Console.Write("Enter your option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Enter your name: ");
                        for (int i = 0; i < names.Length; i++)
                        {
                            if (names[i] == null)
                            {
                                names[i] = Console.ReadLine();

                                Console.Write("Enter your favorite number: ");
                                favoriteNumbers[i] = int.Parse(Console.ReadLine());
                                break;
                            }
                        }
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }//end while
        }
    }
}
