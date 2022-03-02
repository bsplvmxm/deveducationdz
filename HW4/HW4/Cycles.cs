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

        public static int GetFibonacciNumber(int N)
        {
            int first = 1;
            int second = 1;
            int fibonacci = 0;
            int i = 2;

            while (i < N)
            {
                fibonacci = first + second;
                first = second;
                second = fibonacci;
                i++;
            }

            return fibonacci;
        }

        public static int GetLargestDivisorByEuclidean(int A, int B)
        {
            int nod;

            while (A != 0 && B != 0)
            {
                if (A > B)
                {
                    A = A % B;
                }
                else
                {
                    B = B % A;
                }
            }
            nod = A + B;

            return nod;
        }

        public static int FindNumberByHalfDivisionMethod(int N)
        {
            int a = 0;
            int b = N;
            int half = 0;

            while (half*half*half != N)
            {
                half = (a + b) / 2;
                if (half*half*half < N)
                {
                    a = half;
                }
                else
                {
                    b = half;
                }
            }

            return half;
        }

        public static int GetAmountDigitsOfNumber(int number)
        {
            int decade;
            int amount = 0;

            while (number != 0)
            {
                decade = number % 10;
                if (decade % 2 != 0)
                {
                    amount++;
                }
                number /= 10;
            }

            return amount;
        }
    }

}
