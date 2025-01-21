using RectnagleWithPropertiesApp.Models;
using System;
using System.Drawing;



namespace RectnagleWithPropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            int val = r.Next(1, 50);
            Console.WriteLine(val);

           
            Rectangles r1 = new Rectangles();
            r1.Width = 10;
            r1.Height = 20;
            r1.BorderStyle = BorderOptions.Double;
            // PrintDetails("r1 rectangel", r1);

            Rectangles r2 = new Rectangles();
            r2.Width = 10;
            r2.Height = 20;
            r2.BorderStyle = BorderOptions.Double;
            // PrintDetails("r2 rectangel", r2);


            Rectangles r3 = new Rectangles();
            r3.Width = 10;
            r3.Height = 20;
            r3.BorderStyle = BorderOptions.Double;
            //  PrintDetails("r3 rectangel", r3);




            Rectangles[] manyRectangles = new Rectangles[3];
            manyRectangles[0] = r1;
            manyRectangles[1] = r2;
            manyRectangles[2] = r3;

            PrintDetails(manyRectangles);





            Console.WriteLine("end of program!!");


        }

        private static void PrintDetails(Rectangles[] manyRectangles)
        {
            foreach (Rectangles rectangle in manyRectangles)
            {
                PrintDetails("manyRectangles", rectangle);
            }
        }

        private static void PrintDetails(string details, Rectangles rectangle)
        {


            Console.ForegroundColor = ConsoleColor.DarkGreen;


            Console.WriteLine("printing details of :" + details + " foreground colro is " + Console.ForegroundColor);
            Console.WriteLine($"wdith {rectangle.Width} , height is {rectangle.Height}, Area is {rectangle.Area} ,borer is {rectangle.BorderStyle}");
            Console.WriteLine();
            Console.ResetColor();

        }
    }
}