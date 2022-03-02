using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Cycles
    {
        public static int RaiseNumberToDegree(int A, int B)
        {
            int number = 1;

            for (int i = 0; i < B; i++)
            {
                number *= A;
            }
            return number;
        }

        public static int GetAmountOfPositiveNumbers(int A)
        {
            int amount = 0;
            
            for (int i = 1; i < A; i++)
            {
                int sqr = i * i;
                if (sqr < A)
                {
                    amount++;
                }
            }

            return amount;
        }

        public static int PrintTheLargestDivisor(int A)
        {
            int maxDivider = 0;

            for (int i = 1; i < A; i++)
            {
                if (A % i == 0 && i != A)
                {
                    if (i > maxDivider)
                    {
                        maxDivider = i;
                        i++;
                    }
                }
            }

            return maxDivider;
        }

        public static int GetSummOfNumbersFromRange(int A, int B)
        {
            int summ = 0;
            int tmp;

            if (A>B)
            {
                tmp = A;
                A = B;
                B = tmp;
            }
            for (int i = A; i < B; i++)
            {
                if (i % 7 == 0)
                {
                    summ += i;
                }
            }
            return summ;
        }
    }

}
