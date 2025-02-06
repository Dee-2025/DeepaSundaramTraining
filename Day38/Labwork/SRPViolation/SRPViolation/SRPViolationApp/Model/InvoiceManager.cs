using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolationApp.Model
{
    public class InvoiceManager
    {
       

        public double CalculateTax(double cost,double tax)
        {
            return cost * tax;
        }

        public double CalculateDiscount(double cost, double discountPercent)
        {
            return cost * discountPercent;
        }

        public double FinalCost(double cost, double discountPercent,double tax)
        {
            return cost + CalculateTax(cost,tax) - CalculateDiscount(cost,discountPercent);
        }
    }
}
