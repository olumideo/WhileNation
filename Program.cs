using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileNation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            // while (displayMenu == true)  //Redundant to have "== true" because the while code block
            // executes whenever the condition inside the bracket is true.
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
                                }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option below:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1) // We use "+ 1" because without it the programme stops one number before the target
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game");

            Random myRandomNum = new Random();
            int randomNumber = myRandomNum.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++; //Tracking the number of guesses
                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} guesses.", guesses);

            Console.ReadLine();
            
        }
    }
}
