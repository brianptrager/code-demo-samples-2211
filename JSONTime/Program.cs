using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JSONTime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            //students.Add(new Student("Dylan", "Sandberg", "ACT"));
            //students.Add(new Student("Ashley", "Locatelli", "MAD", "Rochester, NY"));
            //students.Add(new Student("Irving", "Rodriguez", "ACT"));

            //string studentsStr = JsonConvert.SerializeObject(students);

            //using (StreamWriter writer = new StreamWriter("students.json"))
            //{
            //    writer.WriteLine(studentsStr);
            //}

            using (StreamReader reader = new StreamReader("students.json"))
            {
                string jsonData = reader.ReadToEnd();
                students = JsonConvert.DeserializeObject<List<Student>>(jsonData);
            }

            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }
        }
    }

    class Student
    {
        [JsonProperty ("First Name")]
        public string FirstName { get; set; }
        [JsonProperty("Last Name")]
        public string LastName { get; set; }
        public string Program { get; set; }
        public string Hometown { get; set; }

        public Student(string firstName, string lastName, string program, string homeTown = "N/A")
        {
            FirstName = firstName;
            LastName = lastName;
            Program = program;
            Hometown = homeTown;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nProgram: {Program}\nHometown: {Hometown}\n";
        }
    }
}
