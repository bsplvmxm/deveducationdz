using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            bool check = false;
            int decade;

            while (number1 != 0)
            {
                decade = number1 % 10;
                for (int i = number2; i != 0; i /= 10)
                {
                    if (i % 10 == decade)
                    {
                        check = true;
                    }
                }
                number1 /= 10;
            }
            if (check == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
