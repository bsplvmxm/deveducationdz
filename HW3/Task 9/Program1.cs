using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int decade;
            int amount = 0;

            while (number != 0)
            {
                decade = number % 10;
                if (decade % 2 != 0)
                {
                    amount++;
                }
                number /= 10;
            }
            Console.WriteLine($"Answer: {amount}");
        }
    }
}
