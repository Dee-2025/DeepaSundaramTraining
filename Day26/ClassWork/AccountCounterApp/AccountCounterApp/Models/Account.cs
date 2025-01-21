using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AccountCounterApp.Models
{
    class Account
    {
        private readonly int _accountNumber;
        private readonly string _name;
        private double _balance;
        private const double MIN_BALANCE = 500;
        private int _counter = 101;
        private static int _instanceCounter;//Static means its global variable, its not an instance variable, its shared across all instances of the class

      
        static Account()//static constructor block of code, called only once in entire project
        {
            Console.WriteLine("static constructor");
            Console.WriteLine("called only once in entired project");
            _instanceCounter = 100;
        }
        public Account(int accountNumber, string name, double balance)
        {
            Console.WriteLine("inside constrcutor");
            _accountNumber = accountNumber;
            _name = name;
            _balance = balance;
            _instanceCounter++;
        }

       
        public void Deposit(double amount)
        {

            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {

            if (_balance - amount > MIN_BALANCE)
                _balance = _balance - amount;

            

        }

        public int InstanceCounter
        {

            get { return _instanceCounter; }
        }

        public double Balance
        {

            get { return _balance; }
        }

        public string Name
        {

            get { return _name; }
        }

        public int AccountNumber
        {


            get
            {


                return _accountNumber;

            }
        }


        public static int HeadCount//static method,affinity ,uses only static variables
        {
            get
            {

                return _instanceCounter;
            }

        }

    }
}