using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int amount = 0;

            for (int i = 1; i < A; i++)
            {
                int sqr = i * i;
                if (sqr < A)
                {
                    amount++;
                }
            }
            Console.WriteLine($"Answer: {amount}");
        }
    }
}
