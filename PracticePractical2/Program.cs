using System;

namespace PracticePractical2
{
    class Program
    {
        static Alien[] aliens = new Alien[1000];
        static void Main(string[] args)
        {
            DisplayHeading();

            //int option = GetMainMenuChoice();

            //switch(option)
            while (true)
            {
                switch (GetMainMenuChoice())
                {
                    case 1:
                        EnterASighting();
                        break;

                    case 2:
                        DisplayAllSightings();
                        break;

                    case 3:
                        FilterBySpecies();
                        break;

                    case 4:
                        DisplayRecordCount();
                        break;

                    case 5:
                        ExitProgram();
                        break;
                }
            }
            //DisplayAllSightings();

        }

        //Specification 2
        //Helper method to display heading for program
        public static void DisplayHeading()
        {
            Console.Clear();
            Console.WriteLine("MAD4UFOS Data Collection System");
            Console.WriteLine($"{DateTime.Now.ToString()}\n");
        }

        //Specficiaton 3
        public static int GetMainMenuChoice()
        {
            string[] menuOptions = {"Enter a sighting", "Display all sightings",
            "Display sightings filtered by species", "Display Record Count", "Exit"};

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");

            Console.ForegroundColor = ConsoleColor.Cyan;
            for(int i = 0; i < menuOptions.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menuOptions[i]}");
            }
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter your selection (1-5): ");

                Console.ResetColor();

                //Input must be a number and matches any of the numeric options provided
                if(int.TryParse(Console.ReadLine(), out int choiceNum))
                    if(choiceNum >= 1 && choiceNum <= menuOptions.Length)
                        return choiceNum;

                //If method does not quit, this will print and repeat back to line 36
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please try again.");
                Console.Beep();
            }
        }

        //Specification 4
        public static void EnterASighting()
        {
            string name = null;
            string dt = null;
            string location = null;
            Console.ForegroundColor = ConsoleColor.Yellow;

            while (true)//species input
            {
                Console.Write("Enter the species (Cockroach, Cricket, or Octo): ");

                name = Console.ReadLine();
                if (name.Trim() == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  ==>You must enter a species name!");
                    continue;
                }
                break;
            }//end while species input

            while (true)//date sighting input
            {
                Console.Write("Enter the date of the sighting as mm/dd/yyyy: ");

                dt = Console.ReadLine();
                if (dt.Trim() == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  ==>You must enter a date as mm/dd/yyyy");
                    continue;
                }

                string[] splitDt = dt.Split("/");
                if(splitDt.Length < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  ==>You must enter a date as mm/dd/yyyy");
                    continue;
                }
                break;
            }//end date sighting input

            while (true)//location input
            {
                Console.Write("Enter the location of the sighting: ");

                location = Console.ReadLine();
                if (location.Trim() == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  ==>You must enter a location for the sighting");
                    continue;
                }
                break;
            }//end location input

            for(int i = 0; i < aliens.Length; i++)
            {
                if (aliens[i] == null)
                {
                    aliens[i] = new Alien(name, dt, location);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("One new sighting added...\n");
                    Console.ResetColor();
                    break;
                }
            }
        }//end EnterASighting method

        //Specification 5
        public static void DisplayAllSightings()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{"Species", -10}     {"Date",10} {"Location",-18}");
            Console.WriteLine("----------     ---------- ------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;

            int counter = 0;
            foreach (Alien alien in aliens)
            {
                if (alien != null)
                {
                    Console.WriteLine($"{alien.Name,-10}     {alien.DateTime,10} {alien.Location,-18}");
                    counter++;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"  ==>{counter} records displayed\n");
            Console.ResetColor();
        }

        public static void FilterBySpecies()
        {
            Console.Write("\nEnter the species (Cockroach, Cricket, or Octo): ");

            string name = Console.ReadLine();
            if (name.Trim() == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  ==>You must enter a species name!");
                return;
            }

            //Display and filter by name of species
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"Species",-10}     {"Date",10} {"Location",-18}");
            Console.WriteLine("----------     ---------- ------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;

            int counter = 0;
            foreach (Alien alien in aliens)
            {
                if (alien != null)
                {
                    if (alien.Name == name)
                    {
                        Console.WriteLine($"{alien.Name,-10}     {alien.DateTime,10} {alien.Location,-18}");
                        counter++;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"  ==>{counter} records displayed\n");
            Console.ResetColor();
        }

        public static void DisplayRecordCount()
        {
            int counter = 0;
            foreach (Alien alien in aliens)
            {
                if (alien != null)
                {
                    counter++;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n  ==>There are currently {counter} sightings on file\n");
            Console.ResetColor();
        }

        public static void ExitProgram()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Do you really want to exit?  Press 'Y' to confirm: ");

            if (Console.ReadLine() == "Y")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Thank you for using the MAD4UFOS recording system.  Goodbye!");
                Environment.Exit(0);
            }
        }
    }
}
