using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberA = Console.ReadLine();
            int A = Convert.ToInt32(numberA);
            string numberB = Console.ReadLine();
            int B = Convert.ToInt32(numberB);

            int result1 = A / B;
            Console.WriteLine($"Answer 1 = {result1}");
            int result2 = A % B;
            Console.WriteLine($"Answer 2 = {result2}");
        }
    }
}
