using System;

namespace TheNameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The Name Game";
            Console.WriteLine("The Name Game\n");

            string firstName = PromptUser("Enter your first name: ");
            string lastName = PromptUser("Enter your last name: ");
            string city = PromptUser("Enter your birth city: ");
            string favoriteFood = PromptUser("Enter your favorite food: ");
            int favoriteNumber = PromptForNumber("Enter your favorite number: ");

            //Console.Write(ReverseInputString(firstName));
            //Console.Write(ReverseInputString(lastName));
            //Console.Write(ReverseInputString(city));
            //Console.Write(ReverseInputString(favoriteFood));
            //Console.Write(ReverseInputString(favoriteNumber.ToString()));

            string reverseFirstName = ReverseInputString(firstName);
            string reverseLastName = ReverseInputString(lastName);
            string reverseCity = ReverseInputString(city);
            string reverseFavoriteFood = ReverseInputString(favoriteFood);
            string reverseFavNumber = ReverseInputString(favoriteNumber.ToString());

            DisplayResult(reverseFirstName, reverseLastName, reverseCity, reverseFavoriteFood, reverseFavNumber);

            DisplayResult(reverseFirstName + reverseLastName + reverseCity + reverseFavoriteFood + reverseFavNumber);

            DisplayResult(ReverseInputString(firstName) + ReverseInputString(lastName) + ReverseInputString(city)
                + ReverseInputString(favoriteFood) + ReverseInputString(favoriteNumber.ToString()));

        }//end Main

        //This method takes an input parameter as a string
        //This method will return a string
        private static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private static int PromptForNumber(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        //This method takes an input parameter as a string
        //This method does not return anything (void)
        private static void ReverseInput(string input)
        {
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i]);
            }
            Console.Write(" ");
        }

        //This method does the same thing as ReverseInput, but returns a string
        private static string ReverseInputString(string input)
        {
            char[] inputArray = input.ToCharArray();  //converted string into an array of characters
            Array.Reverse(inputArray); //reversed all the elements in the array (last becomes first)
            return String.Concat(inputArray) + " "; //put all characters together as one string and then BAM, return it
        }

        private static void DisplayResult(string firstName, string lastName,
            string city, string favoriteFood, string favNumber)
        {
            Console.WriteLine($"{firstName}{lastName}{city}{favoriteFood}{favNumber}");
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
