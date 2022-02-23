using System;

namespace ConsoleApp3
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

            double discriminant = ((double)(B * B) - (4 * A * C));

            if (discriminant > 0)
            {
                double X1 = ((double)(-B) + (Math.Sqrt(discriminant)) / (2 * A));
                double X2 = ((double)(-B) - (Math.Sqrt(discriminant)) / (2 * A));
                Console.WriteLine($"Answer: X1={X1}; X2={X2}");
            }
            else if (discriminant < 0)
            {
                Console.WriteLine($"Answer: No roots. No solutions.");
            }
            else if (discriminant == 0)
            {
                double X = ((double)(-B) / (2 * A));
                Console.WriteLine($"Answer: We've one root: {X}");
            }
        }
    }
}
