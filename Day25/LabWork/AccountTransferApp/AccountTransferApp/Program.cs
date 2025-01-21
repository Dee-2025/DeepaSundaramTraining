using System;
using System.Numerics;
using AccountTransferApp.Models;


namespace AccountTransferApp
{
    class Program
    {
        static void Main()
        {
            var deepa = new Account("Deepa", 25, 10571, 100000);
            PrintDetails(deepa);
            Console.WriteLine(deepa.Deposit(5000));
            Console.WriteLine(deepa.Withdraw(110000));

            var mathi = new Account("Mathi", 30, 10572);
            PrintDetails(mathi);
            Console.WriteLine(mathi.Deposit(2000));
            Console.WriteLine(mathi.Withdraw(1000));

            Account transferAmount = mathi.Transfer(deepa, 5000);
            PrintDetails(transferAmount);
           
        }

        public static void PrintDetails(Account player)
        {
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Age: {player.Age}");
            Console.WriteLine($"Account Number: {player.AccountNumber}");
            Console.WriteLine($"Balance: {player.Balance}");
            Console.WriteLine();
        }
    }
}