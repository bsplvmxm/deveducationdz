using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int decade;

            for (int i = 1; i < N; i++)
            {
                int tmp = i;
                int summPositive = 0;
                int summNegative = 0;
                while (tmp != 0)
                {
                    decade = tmp % 10;
                    if (tmp % 2 == 0)
                    {
                        summPositive += decade;
                    }
                    else
                    {
                        summNegative += decade;
                    }
                    tmp /= 10;
                }
                if (summPositive > summNegative)
                {
                    Console.WriteLine($"{i}");
                }
            }

        }
    }
}
