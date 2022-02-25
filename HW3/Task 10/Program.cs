using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int decade;
            int tmp = 0;

            while (number != 0)
            {
                decade = number % 10;
                if (number > 0)
                {
                    tmp *= 10;
                    tmp += decade;
                }
                number /= 10;
            }
            Console.WriteLine($"Answer: {tmp}");
        }
    }
}
