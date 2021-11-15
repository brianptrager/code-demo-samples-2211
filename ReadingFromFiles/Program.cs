using System;
using System.IO;

namespace ReadingFromFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Ultimate File System for Dummies");
            string[] menuOptions = { "Create a file", "Read a file", "Edit a file", "Delete a file", "Exit" };
            string targetDirectory = @"C:\Users\bptnbs\Documents\";
            string fileName = null;
            string fullPath = null;
            

            while (true)
            {
                int menuOptionNum = 1;

                foreach (string mo in menuOptions)
                {
                    Console.WriteLine($"{menuOptionNum}. {mo}");
                    menuOptionNum++;
                }
                Console.Write("\nEnter your menu option: ");


                switch(Console.ReadLine())
                {
                    case "1": //Create a file
                        fullPath = CreateFilePath(targetDirectory);

                        if (!File.Exists(fullPath))
                        {
                            using (StreamWriter writer = new StreamWriter(fullPath))
                            {
                                Console.Write("");
                            }
                        }
                        else
                            Console.WriteLine("File already exists, creation skipped.");
                        break;

                    case "2": //Read a file
                        fullPath = CreateFilePath(targetDirectory);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (File.Exists(fullPath))
                        {
                            using (StreamReader reader = new StreamReader(fullPath))
                            {
                                while(!reader.EndOfStream)
                                {
                                    Console.WriteLine(reader.ReadLine());
                                }
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine($"Error: File ({fileName}) does not exist in this directory ({targetDirectory}).");
                        }
                        Console.ResetColor();
                        break;

                    case "3": //Edit a file
                        fullPath = CreateFilePath(targetDirectory);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (File.Exists(fullPath))
                        {
                            using (StreamReader reader = new StreamReader(fullPath))
                            {
                                while (!reader.EndOfStream)
                                {
                                    Console.WriteLine(reader.ReadLine());
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine($"Error: File ({fileName}) does not exist in this directory ({targetDirectory}).");
                        }

                        Console.ResetColor();
                        using(StreamWriter writer = new StreamWriter(fullPath, true))
                        {
                            Console.Write("Enter the text you wish to add: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            writer.WriteLine($"\n{Console.ReadLine()}");
                        }
                        Console.ResetColor();
                        break;

                    case "4": //Delete a file
                        fullPath = CreateFilePath(targetDirectory);
                        if (File.Exists(fullPath))
                        {
                            File.Delete(fullPath);
                            Console.WriteLine($"File deleted: {fullPath}");
                        }
                        else
                        {
                            Console.WriteLine($"File not found or has already been deleted.");
                        }
                        break;
                    
                    default:
                        Environment.Exit(0);
                        break;

                }

            } //end while(true)
        }//end Main

        public static string CreateFilePath(string targetDirectory)
        {
            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();
            string fullPath = targetDirectory + fileName;

            return fullPath;
        }
    }
}
