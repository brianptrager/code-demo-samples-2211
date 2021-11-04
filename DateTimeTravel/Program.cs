using System;

namespace DateTimeTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;

            var date1 = new DateTime(1974, 9, 19, 11, 14, 38);

            Console.WriteLine(now.ToString());
            Console.WriteLine(now.DayOfWeek);
            DateTime future = now.AddDays(3);
            Console.WriteLine(future.DayOfWeek);

            Console.WriteLine($"ToLongDateString: {future.ToLongDateString()}");
            Console.WriteLine($"ToShortDateString: {future.ToShortDateString()}");

            Console.WriteLine($"ToLongTimeString: {future.ToLongTimeString()}");
            Console.WriteLine($"ToShortTimeString: {future.ToShortTimeString()}");

            CustomDateTimeString(future);

            Console.WriteLine();

            Console.WriteLine(date1.ToString());
            Console.WriteLine(date1.DayOfWeek);

            switch(date1.DayOfWeek.ToString())
            {
                case "Monday":
                case "Wednesday":
                case "Friday":
                    Console.WriteLine("Time to get to your NMAD.180 class");
                    break;

                case "Tuesday":
                case "Thursday":
                    Console.WriteLine("Time to get to your NMAD.180 class");
                    break;
            }

            Console.WriteLine($"MaxValue: {DateTime.MaxValue}");
            Console.WriteLine($"MinValue: {DateTime.MinValue}");
            Console.WriteLine($"UnixEpoch: {DateTime.UnixEpoch}");
        }

        public static void CustomDateTimeString(DateTime dt)
        {
            Console.WriteLine($"{dt.Month}/{dt.Day}/{dt.Year}, which is on {dt.DayOfWeek}");
        }
    }

    
}
