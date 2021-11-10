using System;
using System.IO;

namespace WritingToFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            bool append = false;

            Console.WriteLine("Welcome to PF Word Editor");
            Console.Write("Do you wish to append data to an existing file? (y/n): ");

            if (Console.ReadLine().ToLower().Trim() == "y")
                append = true;
            
            StreamWriter writer = new StreamWriter("PF1.txt", append);

            Console.WriteLine("Start typing your document: ");
            while (true)
            {
                writer.WriteLine(Console.ReadLine());
                Console.Write("Type 'done' to stop writing or press any key to continue writing to the document: ");
                if (Console.ReadLine() == "done")
                    break;
            }

            writer.Close();
            Console.WriteLine("File saved, exiting program...");


            StreamReader reader = new StreamReader("PF1.txt");
            string line;
            while((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            reader.Close();
        }
    }
}
