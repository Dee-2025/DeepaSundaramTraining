using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolationApp.Model
{
    public class Invoice
    {
        public readonly int id;
        public readonly string description;
        public readonly double discountPercent;
        public readonly double cost;
        public double tax = .10;
        public Invoice(int id, string description, double cost, double disocunt)
        {
            this.id = id;
            this.description = description;
            this.cost = cost;
            this.discountPercent = disocunt;

        }

    }
   
}
