using System;

namespace ArraysWithInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students are in your class?: ");
            int numStudents = int.Parse(Console.ReadLine());

            string[] students = new string[numStudents];

            for(int i = 0; i < students.Length; i++)
            {
                Console.Write($"Enter student #{i + 1}:");
                students[i] = Console.ReadLine();
            }
            
            Console.WriteLine();
            foreach(string student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
