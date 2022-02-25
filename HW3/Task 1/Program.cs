using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int number = 1;
            for (int i=0; i<B; i++)
            {
                number *= A;
            }

            Console.WriteLine($"Answer: {A} ^ {B} = {number}");
        }
    }
}
