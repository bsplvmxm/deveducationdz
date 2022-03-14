using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class Cycles
    {
        public static int RaiseNumberToDegree(int A, int B) //ex.1
        {
            int number = 1;

            for (int i = 0; i < B; i++)
            {
                number *= A;
            }
            return number;
        }

        public static int GetAmountOfPositiveNumbers(int A) //ex.3
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

        public static int PrintTheLargestDivisor(int A) //ex.4
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

        public static int GetSummOfNumbersFromRange(int A, int B) //ex.5
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

        public static int GetFibonacciNumber(int N) //ex.6
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

        public static int GetLargestDivisorByEuclidean(int A, int B) //ex.7
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

        public static int FindNumberByHalfDivisionMethod(int N) //ex.8
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

        public static int GetAmountOddDigitsOfNumber(int number) //ex.9
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

        public static int FindMirroredNumber(int number) //ex.10
        {
            int decade;
            int tmp = 0;

            while (number != 0)
            {
                decade = number % 10;
                tmp *= 10;
                tmp += decade;
                number /= 10;
            }

            return tmp;
        }

        public static bool FindIfThereSameDigits(int number1, int number2) //ex.12
        {
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
            return check;
        }

        public static int[] GetNumbersWhichDecadeOnNumber(int A) //ex.2
        {
            if (A == 0)
            {
                throw new Exception("A mustn't be equal 0");
            }

            if (A < 0)
            {
                A = A * (-1);
            }

            int count = 0;
            
            for (int i = A; i <= 1000; i+=A)
            {                
                count++;               
            }

            int[] arr = new int[count];
            int tmp = 0;

            for (int i = A; i <= 1000; i+=A)
            {
                if (i % A == 0)
                {
                    arr[tmp] = i;
                    tmp++;
                }
            }
            return arr;
        }

        public static int[] GetSummEvenNumWhichHigherOddNum(int N) //ex.11
        {
            if (N < 0)
            {
                throw new Exception("N must be >0");
            }

            int decade;
            int countEven = 0;    
            
            for (int i = 0; i < N; i++)
            {
                
                int tmp = i;
                int summEven = 0;
                int summOdd = 0;
                while (tmp != 0)
                {
                    decade = tmp % 10;
                    if (tmp % 2 == 0)
                    {
                        summEven += decade;
                    }
                    else
                    {
                        summOdd += decade;
                    }
                    tmp /= 10;
                }
                if (summEven>summOdd)
                {
                    countEven++;
                }
            }

            int[] arr = new int[countEven];
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                int tmp = i;
                int summEven = 0;
                int summOdd = 0;
                while (tmp != 0)
                {
                    decade = tmp % 10;
                    if (tmp % 2 == 0)
                    {
                        summEven += decade;
                    }
                    else
                    {
                        summOdd += decade;
                    }
                    tmp /= 10;
                }
                if (summEven > summOdd)
                {
                    arr[count] = i;
                    count++;
                }
            }

            return arr;
        }
    }

}
