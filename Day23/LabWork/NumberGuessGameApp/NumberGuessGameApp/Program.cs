
using System;
using NumberGuessGameApp.Models;

namespace NumberGuessGameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Guess Game!");
            Console.WriteLine("Press 1 to Continue, 0 to Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                NumberGuessGame game = new NumberGuessGame();
                game.StartGame();
            }
            else
            {
                Console.WriteLine("Exiting Game!");
            }
        }
    }
}
