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
            MainMenu();
            Console.ReadLine();
        }
        private static void MainMenu()
        {
            Console.WriteLine("Choose an option below:");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {

            }
            else if (result == "2" || result == "3")
            {

            }
            
        }

        private static void PrintNumbers()
        {
            Console.WriteLine("Print Numbers");
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.WriteLine("Guessing game");
            Console.ReadLine();
        }
    }
}
