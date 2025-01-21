using System;

namespace AccountAppInArray.Models
{
    class Account
    {
        private readonly int _accountNumber;
        private readonly string _accountName;
        private double _balance;
        private const double MIN_BALANCE = 500;
        private const double HIGH_BALANCE = 20000;
        private const int LONG_NAME_LENGTH = 6;


        public Account(int accountNumber, string accountName, double balance) //constructor
        {
            _accountNumber = accountNumber;
            _accountName = accountName;
            _balance = balance;
        }

        public Account(int accountNumber, string accountName)//constructor overloading
        {
            _accountNumber = accountNumber;
            _accountName = accountName;
            _balance = MIN_BALANCE;
        }

        public static void Transfer(Account fromAccount, Account toAccount, double amount)//method to transfer amount from one account to another account
        {
            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);
        }
        public double Balance
        {
            get { return _balance; }

        }

        public int AccountNumber
        {
            get { return _accountNumber; }
        }

        public string AccountName
        {
            get { return _accountName; }
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (_balance - amount > MIN_BALANCE)
            {
                _balance -= amount;
            }
        }

        public bool RichestAccountHolder()//method to check the balance of account holder  is greater than 20000 to set the Richest account holder
        {
            if (_balance > HIGH_BALANCE)
            {
                return true;
            }
            return false;
        }

        public bool LongestNameAccountHolder() //method to check the length of account holder name is greater than 6 to set the Longest name holder
        {
            if (_accountName.Length > LONG_NAME_LENGTH)
            {
                return true;
            }
            return false;
        }

    }
}