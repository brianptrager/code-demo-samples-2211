using System;
using System.Collections.Generic;
using System.IO;

namespace CSVFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = null;
            List<Student> students = new List<Student>();
            string filePath = @"C:\Users\bptnbs\Documents\roster.csv";
            string title = "Next Generation Student Information System";

            string[] menuOptions = { "Add student data", "Save data to file", "Load data into program", "Modify student data", "Exit" };

            Console.Title = title;
            Console.WriteLine(title);

            while (true)
            {
                for (int i = 1; i <= menuOptions.Length; i++)
                {
                    Console.WriteLine($"{i--}. {menuOptions[i++]}");
                }
                Console.Write("Enter your option: ");

                switch (Console.ReadLine())
                {
                    case "1": //Add student data
                        students = AddData(students);
                        break;

                    case "2": //Save data to file
                        
                            WritetoCSV(students, filePath);
                        break;

                    case "3": //Load data into program
                        ReadFromCSV(filePath, ref students);
                        break;

                    case "4": //Modify student data
                        if (students == null || students.Count == 0)
                            ReadFromCSV(filePath, ref students);

                        for (int i = 1; i <= students.Count; i++)
                        {
                            Console.WriteLine($"{i--}. {students[i++]}");
                        }

                        Console.Write("Enter number to modify data: ");
                        int selectedData = int.Parse(Console.ReadLine());

                        Console.Write("Enter the new data: ");
                        students[--selectedData] = new Student() { Name = Console.ReadLine() };
                        break;

                    default: //Quit even if it's not a valid choice
                        Environment.Exit(0);
                        break;
                }
            }//infinite loop


            //ReadFromCSV(filePath);

        }

        public static void WritetoCSV(List<Student> students, string path)
        {
            bool writeFlag = true;
            if (File.Exists(path))
            {
                Console.Write("Do you wish to overwrite? (y/n): ");
                if (Console.ReadLine() == "y")
                    writeFlag = false;
            }

            StreamWriter writer = new StreamWriter(path, writeFlag);

            foreach (Student s in students)
            {
                writer.Write($"{s.Name},");
            }

            writer.Close();
        }

        public static void ReadFromCSV(string path, ref List<Student> students)
        {
            StreamReader reader = new StreamReader(path);
            string data = reader.ReadLine();
            reader.Close();

            if (data != null)
            {
                if (data.Contains(','))
                {

                    string[] splitData = data.Split(',');
                    int counter = 0;

                    foreach (var sd in splitData)
                    {
                        if (sd == "" || sd == null)
                        {
                            Console.WriteLine($"{++counter}. No data");
                            continue;
                        }
                        students.Add(new Student() { Name = sd });
                        Console.WriteLine($"{++counter}. {sd}");
                    }
                }
                else
                {
                    Console.WriteLine("This is not a valid CSV file.");
                }
            }
            else
            {
                Console.WriteLine("Data is empty or corrupted.");
            }
        }//end ReadFromCSV

        public static List<Student> AddData(List<Student> students)
        {
            while (true)
            {
                Console.Write("Enter name of student: ");
                students.Add(new Student() { Name = Console.ReadLine() });

                if (Console.ReadLine() == "quit")
                    break;
            }

            return students;

            //Write to CSV
           // WritetoCSV(students, path);
        }
    }

    class Student
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
