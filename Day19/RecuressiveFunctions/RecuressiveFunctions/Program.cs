using System;

class Program
{     static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        RecurssivePrintName(number);
    }

    static void RecurssivePrintName(int number)
    {
        if (number == 0)
        {
            return;
        }
        Console.WriteLine("Hi THis is Deepa ");
        RecurssivePrintName(number - 1);
        
    }
}
 
 