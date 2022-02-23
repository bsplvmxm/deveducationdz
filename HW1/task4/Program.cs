using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A, B, C:");
            string numberA = Console.ReadLine();
            int A = Convert.ToInt32(numberA);
            string numberB = Console.ReadLine();
            double B = Convert.ToDouble(numberB);
            string numberC = Console.ReadLine();
            int C = Convert.ToInt32(numberC);

            double X = (C - B) / A;

            Console.WriteLine($"Answer: {X}");
        }
    }
}
