using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectReflectionApp.Model
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

       
        public Account(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        
        public void Deposit(decimal amount) { }
        public void Withdraw(decimal amount) { }
        public void Transfer(decimal amount, Account toAccount) { }
    }

}
