using System;

namespace MenuOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "1. Create a new sandwich\n" +
                "2. Edit a sandwich\n" +
                "3. Remove a sandwich\n" +
                "4. Bundle sandwiches\n" +
                "5. Exit program\n";
            Console.Write($"{menu}\nEnter option: ");

            //string option = Console.ReadLine();
            //int optionNum = Convert.ToInt32(option);
            //int optionNum = int.Parse(option);

            //Make sure case matches type of test value
            switch(Console.ReadLine())
            {
                case "1": //Create a sandwich
                    Console.WriteLine("Sandwich created!");
                    break;

                case "2": //Edit a sandwich
                    Console.WriteLine("Sandwich edited!");
                    break;

                case "3": //Remove a sandwich
                    Console.WriteLine("Sandwich tossed!");
                    break;

                case "4": //Bundle sandwiches
                    Console.WriteLine("Sandwich combo!");
                    break;

                case "5": //Exit program
                    Console.WriteLine("Bye bye!");
                    break;

                default: //Any input other than 1 - 5
                    Console.WriteLine("No sandwich for you!");
                    break;
            }
        }
    }
}
