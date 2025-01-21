using System;

class Program
{
    static void Main(string[] args)
    {
        string[] name = new string[] { "Deepa", "Mathi", "Jaya", "Sachin", "Prem" };
        
        CaseStudy3(name);
    }

    static void CaseStudy1(string[] names)
    {
        Console.Write("\n****");
        foreach (var name in names)
        {
            Console.Write($",*{name}*");
        }
        Console.Write("****");
    }

    static void CaseStudy2(string[] names)
    {
        Console.Write("\n**** ");
        Console.Write(string.Join("*,*", names));
        Console.Write(" ****");

    }
    static void CaseStudy3(string[] names)
    {
        for (int i = 1; i < names.Length; i++)
        {
            if (names[i - 1] == names[0])
            {
                Console.Write($"**** **{names[0]}**");
            }
            Console.Write($",**{names[i]}**");
            if (names[i] == names[names.Length - 1])
            {
                Console.Write(" ****");
            }
        }

    }
}