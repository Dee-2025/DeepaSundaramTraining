using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCommonLib.Models
{
    public class InsufficientFundsException : Exception
    {
        

        private string _holdername;
        private double _balance;
        public InsufficientFundsException(string holdername, double balance)

        {
            _holdername = holdername;
            _balance = balance;
        }

        public override string Message
        {
            get
            {

                return $"account holder:{_holdername} , doesnot have sufficends for withraw of balacne is only :{_balance}";
            }
        }


    }


}