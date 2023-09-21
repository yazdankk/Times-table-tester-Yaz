using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times_Table_Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userScore = 0;
            Console.BackgroundColor = ConsoleColor.Blue; Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("T I M E S  T A B L E  T E S T E R\n\nEnter what times table you want to be tested on (2-12): ");
            string userChoice = Console.ReadLine();

            while (Convert.ToInt32(userChoice) > 12 || Convert.ToInt32(userChoice) < 2)
            {
                Console.WriteLine("\nTry Again: ");
                userChoice = Console.ReadLine();
            }

            for (int i = 1; i < 11; i++)
            {
                Random rng = new Random();
                int randNum = rng.Next(1, 13);

                int answer = Convert.ToInt32(userChoice) * randNum;

                Console.WriteLine("Question: " + i + ": " + userChoice + " x " + randNum);
                string userAnswer = Console.ReadLine();

                if (answer == Convert.ToInt32(userAnswer))
                {
                    Console.WriteLine("Correct!\n");
                    ++userScore;
                }
                else if (answer != Convert.ToInt32(userAnswer))
                {
                    Console.WriteLine("Incorrect! The answer was " + answer + "\n");
                }
            }
            Console.WriteLine("You got a total score of " + userScore + ", Nice Work!");

            Console.WriteLine("Want to play again? (y/n)");
            string playAgain = Console.ReadLine();

        }
    }
}
