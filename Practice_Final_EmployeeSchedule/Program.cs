using System;
using System.IO;
//Name: Professor BT
//Date: 12/9/2021
//Course: NMAD.180
//Purpose: Help students understand the solution to the practice final exam
namespace Practice_Final_EmployeeSchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Rusty Buckets Work Roster***\n");

            string fileName = "workers.csv";
            string[] menuOptions = {"Enter employee work data",
            "List all worker data", "List all employees working on a specific date",
            "List all dates worked for a specific employee", "Exit"};
            //Parallel arrays
            string[] employees = new string[1000];
            string[] dateTimes = new string[1000];

            #region Read Data From File
            if (File.Exists(fileName))
            {
                //Read file if exists
                using(StreamReader sr = new StreamReader(fileName))
                {
                    //Get all the data on the first line into a string (employee data)
                    string empData = sr.ReadLine();
                    string dtData = sr.ReadLine();
                    //Split the data by comma since this is a CSV file
                    employees = empData.Split(',');
                    dateTimes = dtData.Split(',');
                }
            }
        #endregion
        Menu:
            while (true)
            {
                Console.WriteLine("Make a selection from the choices below:");
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    Console.WriteLine($"  {i + 1}. {menuOptions[i]}");
                }
                Console.Write("Enter your selection: ");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1": //Enter employee work data
                        Console.Write("Enter the Employee's first name: ");
                        string empName = Console.ReadLine();
                        Console.Write("Enter the date s/he worked (mm/dd/yyyy): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                        {
                            for (int i = 0; i < employees.Length; i++)
                            {
                                if (employees[i] == null)
                                {
                                    employees[i] = empName;
                                    dateTimes[i] = date.ToShortDateString();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("***Error: Invalid Data");
                            goto Menu;
                        }
                        break;

                    case "2": //List all worker data
                        Console.WriteLine("All Employee Work Dates");
                        Console.WriteLine($"{"Date",-12}{"Name",-12}");
                        Console.WriteLine($"{"----",-12}{"----",-12}");
                        int workerCounter = 0;
                        for (int i = 0; i < employees.Length; i++)
                        {
                            if (employees[i] != null && employees[i] != "")
                            {
                                Console.WriteLine($"{dateTimes[i],-12}{employees[i],-12}");
                                workerCounter++;
                            }
                        }
                        Console.WriteLine($"{workerCounter} employees listed\n");
                        break;

                    case "3": //List employees by date
                        Console.Write("Enter the date for reporting (mm/dd/yyyy): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime dt))
                        {
                            Console.WriteLine($"All Employee Working on {dt.ToShortDateString()}");
                            Console.WriteLine($"{"Date",-12}{"Name",-12}");
                            Console.WriteLine($"{"----",-12}{"----",-12}");
                            int counter = 0;
                            for (int i = 0; i < employees.Length; i++)
                            {
                                if (dateTimes[i] == dt.ToShortDateString())
                                {
                                    Console.WriteLine($"{dateTimes[i],-12}{employees[i],-12}");
                                    counter++;
                                }
                            }
                            Console.WriteLine($"{counter} employees listed\n");
                        }
                        else
                        {
                            Console.WriteLine("***Error: Invalid Date");
                            goto Menu;
                        }
                        break;

                    case "4": //List all dates for a specific employee
                        Console.Write("Enter employee name to report: ");
                        string employeeSearch = Console.ReadLine();

                        Console.WriteLine($"\nAll Work Dates for {employeeSearch}");
                        Console.WriteLine($"{"Date",-12}{"Name",-12}");
                        Console.WriteLine($"{"----",-12}{"----",-12}");
                        int empCounter = 0;
                        for (int i = 0; i < employees.Length; i++)
                        {
                            if (employees[i] == employeeSearch)
                            {
                                Console.WriteLine($"{dateTimes[i],-12}{employees[i],-12}");
                                empCounter++;
                            }
                        }
                        Console.WriteLine($"{empCounter} dates listed\n");
                        break;

                    case "5":
                        string employeeData = null;
                        string dateTimeData = null;

                        for (int i = 0; i < employees.Length; i++)
                        {
                            employeeData += employees[i] + ",";
                            dateTimeData += dateTimes[i] + ",";
                        }
                        Console.Write("Saving data...");
                        using (StreamWriter writer = new StreamWriter(fileName, false))
                        {
                            writer.WriteLine(employeeData);
                            writer.WriteLine(dateTimeData);
                        }
                        Console.WriteLine("done");
                        Console.WriteLine("\nExiting program...");
                        Environment.Exit(0);
                        break;

                    default:
                        int numSelection = 0;
                        if (!int.TryParse(selection, out numSelection))
                        {
                            Console.WriteLine("***Error: You must enter a numeric value");
                            Environment.Exit(0);
                        }
                        //Print this error message as this will run if number is valid, but not between 1 and 5
                        Console.WriteLine("***Error: Value out of range");
                        Environment.Exit(0);
                        break;
                }
            }//end outer loop
        }
    }
}
