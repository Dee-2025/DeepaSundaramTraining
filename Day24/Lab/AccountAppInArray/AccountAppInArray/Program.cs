using AccountAppInArray.Models;
using System;
using System.Net.Http.Headers;
using System.Security.Principal;

namespace AccountAppInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new object for Account class

            Account accDeepa = new Account(101, "Deepa", 100000);
            Account accMathi = new Account(102, "mathi", 5000);
            Account accPriti = new Account(103, "Priti");
            Account accShalini = new Account(104, "Shalini", 25000);
            accDeepa.Withdraw(5000); //calling withdraw method
            accPriti.Deposit(5000); //calling deposit method

            //creating a Array of Account class
            Account[] accounts = { accDeepa, accMathi, accPriti, accShalini };
            Account.Transfer(accDeepa, accMathi, 5000); //calling Transfer method to transfer amount from one account to another account with aruguments
            PrintDetails(accounts); //calling PrintDetails method to print the details of account holders

            //RichestAccountHolder(accounts);
            //LongestNameAccountHolder(accounts);
        }
        //Method to print the details of account holders
        public static void PrintDetails(Account[] accounts)
        {
            int customerCount = 1;
            foreach (Account account in accounts)
            {
                Console.WriteLine("===================================");
                Console.WriteLine($"Customer {customerCount++}");
                Console.WriteLine("===================================");
                Console.WriteLine($"Account Number: {account.AccountNumber}");
                Console.WriteLine($"Account Name: {account.AccountName}");
                Console.WriteLine($"Balance: {account.Balance}");
                Console.ForegroundColor = ConsoleColor.Green;

                
                if (account.RichestAccountHolder())
                {
                    Console.WriteLine("Richest account Holder");
                }
                if (account.LongestNameAccountHolder())
                {
                    Console.WriteLine("Longest Name Holder");
                }

                Console.ResetColor();
                Console.WriteLine();
            }
        }



       
    }
}