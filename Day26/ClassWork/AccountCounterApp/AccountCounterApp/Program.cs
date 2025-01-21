using System;
using AccountCounterApp.Models;

namespace AccountCounterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //static prorperty
            Console.ForegroundColor = ConsoleColor.Red;

            var venkat = new Account(101, "Deepa", 2000);
            Console.WriteLine(venkat.InstanceCounter);
            Console.WriteLine(Account.HeadCount);

            Console.ResetColor();//staic method


            var minu = new Account(102, "Minu", 1000);
            Console.WriteLine(venkat.InstanceCounter);
            Console.WriteLine(Account.HeadCount);

            new Account(103, "Prem", 3000);
            Console.WriteLine(venkat.InstanceCounter);
            Console.WriteLine(Account.HeadCount);


            Console.WriteLine(Account.HeadCount);
            Console.WriteLine(minu.InstanceCounter);
        }
    }
}