using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string A:");
            string A = Console.ReadLine();
            Console.WriteLine("Enter string B:");
            string B = Console.ReadLine();
            string copy = A;

            A = B;
            B = copy;
           

            Console.WriteLine($"String A: {A} / String B: {B}");

        }
    }
}
