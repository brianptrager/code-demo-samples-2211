using System;

namespace StringAwesomeSauce
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello";
            word = "World";

            Console.WriteLine($"{word,20}");

            string fullName = "Brian Trager";

            //We need to find the whitespace in the full name first
            int index = fullName.IndexOf(' ');
            Console.WriteLine(index);

            string firstName = fullName.Substring(0, fullName.IndexOf(' '));
            string lastName = fullName.Substring(fullName.IndexOf(' ') + 1);
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");

            string fullNameTwo = "Brian Paul Trager";

            string[] splitFullName = fullName.Split(" ");
            string[] splitFullNameTwo = fullNameTwo.Split(" ");

            Console.WriteLine(SmartPrint(splitFullName));
            Console.WriteLine(SmartPrint(splitFullNameTwo));


        }//end Main

        private static string SmartPrint(string[] names)
        {
            string[] prefixes = { "First Name:", "Middle Name:", "Last Name:" };
            //switch (names.Length)
            //{
            //    case 2:
            //        Console.WriteLine($"First Name: {names[0]}");
            //        Console.WriteLine($"Last Name: {names[1]}");
            //        break;

            //    case 3:
            //        Console.WriteLine($"First Name: {names[0]}");
            //        Console.WriteLine($"Middle Name: {names[1]}");
            //        Console.WriteLine($"Last Name: {names[2]}");
            //        break;
            //}
            string newName = "";
            
            for (int i = 0; i < names.Length; i++)
            {
                if (names.Length == 2 && i == 1)
                {
                    newName += prefixes[i + 1] + " ";
                }
                else
                {
                    newName += prefixes[i] + " ";
                }

                newName += names[i] + "\n";
            }

            return newName;
        }
    }
}
