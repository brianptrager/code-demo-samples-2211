using System;

namespace RandomGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a random object
            Random random = new Random();
            const int WINNING_THRESHOLD = 15;

            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int dice3 = random.Next(1, 7);

            //This is for testing purposes only.
            //int dice1 = 1, dice2 = 1, dice3 = 2;

            int total = 0;
            int bonus = 0;
            //Console.WriteLine($"{dice1}\n{dice2}\n{dice3}");

            Console.WriteLine($"Dice #1: {dice1}\nDice #2: {dice2}\nDice #3: {dice3}\n");

            //If any two dice you roll result in the same value,
            //you get two bonus points for rolling doubles
            if(dice1 == dice2 || dice1 == dice3 || dice2 == dice3)
            {
                bonus = 2;
            }

            //If all three dice you roll result in the same
            //value, you get six bonus points for rolling triples.
            if (dice1 == dice2 && dice1 == dice3 && dice2 == dice3)
            {
                bonus = 6;
            }

            //Total of all values and bonus
            total = dice1 + dice2 + dice3 + bonus;

            Console.WriteLine($"Bonus: {bonus}\nTotal: {total}\n");

            if(total >= WINNING_THRESHOLD)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You won!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose, try again.");
            }
            Console.ResetColor();
        }
    }
}
