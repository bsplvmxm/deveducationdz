using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool res = Cycles.FindIfThereSameDigits(1234, 7619);
            if (res == true)
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
