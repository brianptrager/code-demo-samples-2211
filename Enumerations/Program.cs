using System;

namespace Enumerations
{
    class Program
    {

        public enum Students
        {
            Dylan, Ashley, Sam, Amir, Irving
        }
        static void Main(string[] args)
        {
            Students[] students = (Students[]) Students.GetValues(typeof(Students));

            Console.WriteLine(Students.Dylan);
            Console.WriteLine((int)Students.Dylan);

            Console.WriteLine(Students.Irving.ToString());
            Console.WriteLine((int)Students.Irving);

            Console.WriteLine(ConsoleColor.Red);
            Console.WriteLine((int)ConsoleColor.Red);

            foreach(Students s in students)
            {
                Console.WriteLine($"{s} is {(int)s}");
            }
        }
    }
}
