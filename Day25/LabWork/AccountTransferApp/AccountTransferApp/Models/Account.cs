using System;
using System.Runtime.CompilerServices;

namespace AccountTransferApp.Models
{
    class Account
    {
        private string name;
        private int age;
        private int accountNumber;
        private double balance;
        private const double MIN_BALANCE = 1000.00;

        public Account(string name, int age, int accountNumber, double balance)
        {
            this.name = name;
            this.age = age;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public Account(string name, int age, int accountNumber) : this(name, age, accountNumber, MIN_BALANCE)
        {

        }

        public string Deposit(double amount)
        {
            balance += amount;
            return $"Your Transaction Amount \"{amount}\" is Deposited to the Account {name} your balance is \"{balance}\"\n";
        }




        public string Withdraw(double amount)
        {
            if (balance - amount >= MIN_BALANCE)
            {
                balance -= amount;
                return $"Your Transaction Amount \"{amount}\" is Withdrawn from the Account {name} your Balance : {balance}\n";
            }
            return $"Your Transaction Amount \"{amount}\" is Declined Due to Maintaining the Minimum Balance! Your Balance : {amount}\n";

        }
        public int Age
        {
            get { return age; }
        }
        public string Name
        {
            get { return name; }
        }
        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public Account Transfer(Account secondPlayer, double amount)
        {
            if (balance - amount >= MIN_BALANCE)
            {
                balance -= amount;
                secondPlayer.Deposit(amount);
                Console.WriteLine($"Transaction Successful. The amount {amount} has been deposited. Check the balance.");
                return secondPlayer;
            }
            Console.WriteLine($"Transaction Amount {amount} is Declined due to Minimum Balance! Check the balance.");
            return this;
        }

    }
}