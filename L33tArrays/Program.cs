using System;

namespace L33tArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example1
            //int[] numbers = new int[5];

            //numbers[0] = 4;
            //numbers[1] = 10;
            //numbers[2] = 14;
            //numbers[3] = 6;
            //numbers[4] = 23;

            int[] numbers = { 4, 10, 14, 6, 23 };
            string[] names = new string[4];

            names[0] = "Bob";
            names[1] = "Chris";
            names[2] = "Danielle";
            names[3] = "1";

            Console.WriteLine(names[0]);

            Console.WriteLine(numbers[1]);
            Array.Sort(numbers);
            Console.WriteLine(numbers[1]);
            Array.Reverse(numbers);
            Console.WriteLine(numbers[1]);

            Console.WriteLine(names[1]);
            Array.Sort(names);
            Console.WriteLine(names[1]);
            Array.Reverse(names);
            Console.WriteLine(names[1]);
            #endregion

            #region ParallelArrays
            string[] studentRoster = { "Dylan", "Ashley", "Flavio", "Sam", "Amir", "Irving" };
            int[] favoriteNumbers = { 4, 2, 27, 7, 5, 19 };
            Console.WriteLine("\nClass Roster:");
            //for (int i = 0; i < studentRoster.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {studentRoster[i]}");
            //}

            //int counter = 1;
            //foreach (string name in studentRoster)
            //{
            //    Console.WriteLine($"{counter++}. {name}");
            //}

            if(studentRoster.Length == favoriteNumbers.Length)
            {
                for(int i = 0; i < studentRoster.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {studentRoster[i], -15}Favorite Number: {favoriteNumbers[i], -3}");
                }
            }
            else
            {
                Console.WriteLine("The arrays are not parallel.");
            }
            #endregion

            #region HighestNumber
            //Highest number in favoriteNumbers array
            int highestNumber = Int32.MinValue;
            for(int i = 0; i < favoriteNumbers.Length; i++)
            {
                if (favoriteNumbers[i] > highestNumber)
                    highestNumber = favoriteNumbers[i];
            }

            Console.WriteLine($"Highest number: {highestNumber}");
            #endregion
        }
    }
}
