using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int summ = 0;

            if (A < B)
            {
                for (int i = A; i < B; i++)
                {
                    if (i % 7 == 0)
                    {
                        summ += i;
                        i++;
                    }
                }
            }
            else
            {
                for (int i = B; i < A; i++)
                {
                    if (i % 7 == 0)
                    {
                        summ += i;
                        i++;
                    }
                }
            }
            Console.WriteLine($"Answer: {summ}");
        }
    }
}
