using System;

namespace ConsoleApp2
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
            Console.WriteLine("Enter C:");
            string numberC = Console.ReadLine();
            int C = Convert.ToInt32(numberC);

            Console.WriteLine($"Entered data: {A},{B},{C}");

            if (A>B && B>C)
            {
                Console.WriteLine($"Answer: {C},{B},{A}");
            }
            else if (A>C && B<C)
            {
                Console.WriteLine($"Answer: {B},{C},{A}");
            }
            else if (A<B && A>C)
            {
                Console.WriteLine($"Answer: {C},{A},{B}");
            }
            else if (B>C && C>A)
            {
                Console.WriteLine($"Answer: {A},{C},{B}");
            }
            else if (B<C && B<A)
            {
                Console.WriteLine($"Answer: {B},{A},{C}");
            }
            else if (A<B && B<C)
            {
                Console.WriteLine($"Answer: {A},{B},{C}");
            }
        }
    }
}
