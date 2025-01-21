using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGameApp.Models
{
    public class NumberGuessGame
    {
        public void StartGame()
        {
            Console.WriteLine("You have three attempts to guess the random number !");
            Console.WriteLine("Enter a number between 1-20");
            Random random = new Random();
            int randomNumber = random.Next(1, 21);
            int attempts = 3;
            bool hasWon = false;
            while (attempts > 0)
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if(userNumber > randomNumber)
                {
                    Console.WriteLine("Number is too high! Enter a Smaller No");
                }
                else if(userNumber < randomNumber)
                {
                    Console.WriteLine("Number is too low! Enter a Bigger No");
                }
                else
                {
                    hasWon = true;
                    Console.WriteLine("Congrats!You won the game!");
                    break;
                }
                attempts--;


            }
            

        }
        
    }
}
