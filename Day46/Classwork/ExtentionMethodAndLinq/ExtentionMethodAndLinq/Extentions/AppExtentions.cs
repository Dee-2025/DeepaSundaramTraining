using ExtentionMethodAndLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethodAndLinq.Extentions
{
    internal static class AppExtentions
    {
        public static string  HelloRRD(this string name)
        {
            return ($"Hello {name}");
        }
        public static void Print(this Account input)
        {
            Console.WriteLine("Print Account Details ");
            Console.WriteLine("************************");
            Console.WriteLine($"Account Number : {input.AccountNumber}");
        }
    }
}
