using System;

namespace StringMagic
{
    class Program
    {
        static void Main(string[] args)
        {
            //string username = "admin";
            //string password = "ICS2355";

            string[] users = { "admin", "student", "professor", "ceo" };
            string[] passwords = { "ics2355", "ritIsAwesome", "teachingisfun", "getfilthyrich" };
            int sessionPostFix = 100;
            string sessionId;

            #region FirstExample
            //while (true)
            //{
            //    Console.Write("Enter your username: ");
            //    string userInput = Console.ReadLine();

            //    Console.Write("Enter your password: ");
            //    string pwInput = Console.ReadLine();
            //    //pwInput = pwInput.ToLower();
            //    pwInput = pwInput.ToUpper();

            //    if(userInput == username && pwInput == password)
            //    {
            //        Console.WriteLine("Information authenticated");
            //        Console.WriteLine("Welcome to Area 51");
            //        sessionId = username[0].ToString() + username[username.Length - 1].ToString() + sessionPostFix.ToString();
            //        Console.WriteLine($"Initializing session: {sessionId}");
            //        sessionPostFix++;
            //        break;
            //    }

            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Incorrect authorization, you will be arrested or shot on sight");
            //    Console.ResetColor();
            //    Console.WriteLine("Just kidding, no really, you have five seconds to correct this.");

            //}
            #endregion

            #region SecondExample
            while (true)
            {
                Console.Write("Enter your username: ");
                string userInput = Console.ReadLine();

                Console.Write("Enter your password: ");
                string pwInput = Console.ReadLine();
                //pwInput = pwInput.ToLower();
                //pwInput = pwInput.ToUpper();

                for(int i = 0; i < users.Length; i++)
                {
                    if (users[i] == userInput)
                    {
                        if (passwords[i] == pwInput)
                        {
                            Console.WriteLine("Information authenticated");
                            Console.WriteLine("Welcome to Area 51");
                            string tmpUser = users[i];
                            sessionId = tmpUser[0] + tmpUser[tmpUser.Length - 1] + sessionPostFix.ToString();
                            Console.WriteLine($"Initializing session: {sessionId}");
                            sessionPostFix++;
                            break;
                        }//end if password match
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                           // Console.WriteLine($"Your password: {pwInput}, Test password: {passwords[i]}");
                            Console.WriteLine("Incorrect password");
                            Console.ResetColor();
                            continue;
                        }
                    }//end if username match
                    else if(i == users.Length - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect authorization, you will be arrested or shot on sight");
                        Console.ResetColor();
                        Console.WriteLine("Just kidding, no really, you have five seconds to correct this.");
                        continue;
                    }
                    
                    
                }//end for loop
                break;
            }//end while(true)
            #endregion
        }
    }
}
