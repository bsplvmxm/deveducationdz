using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int maxDivider = 0;

            for (int i=1; i<A; i++)
            {
                if (A % i == 0 && i!=A)
                {
                    if (i > maxDivider)
                    {
                        maxDivider = i;
                        i++;
                    }
                }
            }
            Console.WriteLine($"Answer: {maxDivider}");
        }
    }
}
