using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            string numberA = Console.ReadLine();
            int A = Convert.ToInt32(numberA);
            Console.WriteLine("Enter B:");
            string numberB = Console.ReadLine();
            int B = Convert.ToInt32(numberB);

            if (A>B)
            {
                int result = A + B;
                Console.WriteLine($"*A>B* Answer: {result}");
            }
            else if (A==B)
            {
                int result = A * B;
                Console.WriteLine($"*A==B* Answer: {result}");
            }
            else if (A<B)
            {
                int result = A - B;
                Console.WriteLine($"*A<B* Answer: {result}");
            }

        }
    }
}
