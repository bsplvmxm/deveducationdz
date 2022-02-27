using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = N;
            int half = 0;

            while (Math.Pow(half, 3) != N)
            {
                half = (a + b) / 2;
                if (Math.Pow(half,3) < N)
                {
                    a = half;
                }
                else
                {
                    b = half;
                }
            }
            Console.WriteLine($"Answer: {half}");
        }
    }
}
