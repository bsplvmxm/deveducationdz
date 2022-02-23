using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coord X1, X2, Y1, Y2:");

            string coordX1 = Console.ReadLine();
            int X1 = Convert.ToInt32(coordX1);
            string coordX2 = Console.ReadLine();
            int X2 = Convert.ToInt32(coordX2);
            string coordY1 = Console.ReadLine();
            int Y1 = Convert.ToInt32(coordY1);
            string coordY2 = Console.ReadLine();
            int Y2 = Convert.ToInt32(coordY2);

            Console.WriteLine($"Coords: ({X1};{Y1}),({X2};{Y2})");

            int A = (Y2 - Y1) / (X2 - X1);
            int B = Y2 - (A * X2);
            string sign;

            if (B >= 0)
            {
                sign = "+";
            }
            else
            {
                sign = "";
            }

            Console.WriteLine($"Answer: Y={A}X{sign}{B}");
        }
    }
}
