using System;

namespace SimpleMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your first name: ");
            //string firstName = Console.ReadLine();

            string firstName = PromptUser("Enter your first name: ");

            //Console.Write("Enter your last name: ");
            //string lastName = Console.ReadLine();

            string lastName = PromptUser("Enter your last name: ");

            //Console.Write("Enter your birth city: ");
            //string city = Console.ReadLine();

            string city = PromptUser("Enter your birth city: ");

            //char[] firstNameArray = firstName.ToCharArray();
            //Array.Reverse(firstNameArray);

            //for(int i = 0; i <= firstNameArray.Length; i++)
            //{
            //    Console.Write(firstNameArray[i]);
            //}
            //Console.Write(" ");

            //char[] lastNameArray = lastName.ToCharArray();
            //Array.Reverse(lastNameArray);

            //char[] cityArray = city.ToCharArray();
            //Array.Reverse(cityArray);

            //for (int i = 0; i <= lastNameArray.Length; i++)
            //{
            //    Console.Write(lastNameArray[i]);
            //}
            //Console.Write(" ");

            //for (int i = 0; i <= cityArray.Length; i++)
            //{
            //    Console.Write(cityArray[i]);
            //}
            //Console.Write(" ");

            //ReverseInput(firstName);
            //ReverseInput(lastName);
            //ReverseInput(city);

            Console.Write(ReverseInputString(firstName));
            Console.Write(ReverseInputString(lastName));
            Console.Write(ReverseInputString(city));

        }//end Main

        //This method takes an input parameter as a string
        //This method will return a string
        private static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
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
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string reverseString = "";

            for (int i = 0; i < inputArray.Length; i++)
            {
                //Console.Write(inputArray[i]);
                reverseString += inputArray[i];
            }
            //Console.Write(" ");
            reverseString += " ";
            return reverseString;
        }
    }
}
