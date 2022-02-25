using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");

            int A = Convert.ToInt32(Console.ReadLine());
            
            for (int i=A; i<=1000; i++)
            {
                if (i % A == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
