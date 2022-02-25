using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int amount = 0;

            for (int i = 0; i < n; i++)
            {
                int sqr = i * i;
                if (i > 0 && i % 2 == 0 && sqr < A)
                {
                    amount++;
                }
            }
            Console.WriteLine($"Answer: {amount}");
        }
    }
}
