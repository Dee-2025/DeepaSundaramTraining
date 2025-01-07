using System;

class Program
{


    static void Main()
    {

        //PrintInfo("Akhilesh");
        //PrintInfo('@');
        //PrintInfo(10);
        //PrintInfo(10.5f);
        //PrintInfo(10.5d);
        //PrintInfo(10.5M);



        PrintInfo(10);
        PrintInfo(10.55f);
        PrintInfo(10.55d);
        PrintInfo(10.55M);
        PrintInfo('a');
        PrintInfo('A');
        PrintInfo("Deepa");

    }

    static void PrintInfo(int input)
    {
        Console.WriteLine("Overload int  #1");
        Console.WriteLine(sizeof(int));
        Console.WriteLine("input value  is " + input + " and size is " + sizeof(int));
        Console.WriteLine("input value  is : {0} and size is {1}", input, sizeof(int));
        Console.WriteLine($"intput is value is {input} and int size is {sizeof(int)}");
    }

    static void PrintInfo(float input)
    {
        Console.WriteLine("Overload float #2");
        Console.WriteLine($"intput is value is {input} and float size is {sizeof(float)}");
    }

    static void PrintInfo(double input)
    {
        Console.WriteLine("Overload double #3");
        Console.WriteLine($"intput is value is {input} and double size is {sizeof(double)}");
    }

    static void PrintInfo(decimal input)
    {
        Console.WriteLine("Overload decimal #4");
        Console.WriteLine($"intput is value is {input} and decimal size is {sizeof(decimal)}");
    }

    static void PrintInfo(char input)
    {
        //ascii value of char

        Console.WriteLine("Overload char #5");
        Console.WriteLine($"intput is value is {input} and char size is {sizeof(char)} ");
        Console.WriteLine($"ascii value is {(int)input} ");
    }
    static void PrintInfo(string input)
    {
        //ascii value of char

        Console.WriteLine("Overload string #5");
        Console.WriteLine($"intput is value is {input} ");
        
    }




}