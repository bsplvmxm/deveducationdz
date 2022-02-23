using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X:");
            string coordX = Console.ReadLine();
            int X = Convert.ToInt32(coordX);
            Console.WriteLine("Enter Y:");
            string coordY = Console.ReadLine();
            int Y = Convert.ToInt32(coordY);

            Console.WriteLine($"Coords: ({X};{Y})");

            if (X>0 && Y>0)
            {
                Console.WriteLine($"Answer: The First Quarter");
            }
            else if (X<0 && Y>0)
            {
                Console.WriteLine($"Answer: The Second Quarter");
            }
            else if (X<0 && Y<0)
            {
                Console.WriteLine($"Answer: The Third Quarter");
            }
            else if (X>0 && Y<0)
            {
                Console.WriteLine($"Answer: The Fourth Quarter");
            }
        }
    }
}
