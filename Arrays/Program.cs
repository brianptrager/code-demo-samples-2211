using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("How many elements do you want in your fancy new array?: ");
            //int numOfElements = int.Parse(Console.ReadLine());

            //int[] numbers = new int[numOfElements];

            int[] numbers = new int[5];

            numbers[0] = 3;
            numbers[1] = 4;
            numbers[2] = 27;
            numbers[3] = 5;
            numbers[4] = 7;


            Console.WriteLine($"Index 0: {numbers[0]}");
            Console.WriteLine($"Index 1: {numbers[1]}");
            Console.WriteLine($"Index 2: {numbers[2]}");
            Console.WriteLine($"Index 3: {numbers[3]}");
            Console.WriteLine($"Index 4: {numbers[4]}");

            Console.WriteLine($"The sum of every element in the array: " +
                $"{numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]}");

            Console.WriteLine($"The average of every element in the array: " +
                $"{(numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]) / numbers.Length}");

            //array to store string objects
            string[] strings = new string[3];

            strings[0] = "3";
            strings[1] = "4";
            strings[2] = "5";

            Console.WriteLine($"The sum of every element in the string array: " +
                $"{int.Parse(strings[0]) + int.Parse(strings[1]) + int.Parse(strings[2])}");
        }
    }
}
