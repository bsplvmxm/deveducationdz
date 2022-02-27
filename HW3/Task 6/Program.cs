using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter positive N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int first = 1;
            int second = 1;
            int fibonacci = 0;
            int i = 2;

                while (i < N)
                {
                    fibonacci = first + second;
                    first = second;
                    second = fibonacci;
                    i++;
                }
                Console.WriteLine($"Answer: {fibonacci}");
        }
    }
}
