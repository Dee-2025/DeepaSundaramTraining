using System;
using System.Net.Http.Headers;
class Program
{
    static void Main()
    {
       
        ValidateName();
    }
    static void ValidateName()
    {

        while (true)
        {
            Console.WriteLine("Enter your Name");
            string userName = Console.ReadLine();
            if (CheckInput(userName))
            {
                Console.WriteLine($"Hey {userName} Welcome Back!");
                break;
            }
            Console.WriteLine("Its not Correct Enter Correct Input");

        }
    }
    static bool CheckInput(string userName)
    {
        
        foreach (char c in userName)
        {
            if ((c == 32))
                return false;
            if ((c < 65 || c > 90) && (c < 97 || c > 122))
                return false;
        }
        return true;
    }
}