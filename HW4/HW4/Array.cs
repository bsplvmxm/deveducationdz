using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Array
    {
        #region Generate and Write Arrays
        public static int[] GenerateArray(int lenght)
        {
            Random r = new Random();

            int[] arr = new int[lenght];

            for (int i=0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-100,100);
            }
            return arr;
        }

        public static void WriteArray(int[] array)
        {
            for (int i=0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void GetSolution() //help with program.cs
        {
            Console.Write("Enter lenght of array: ");
            int[] arr = Array.GenerateArray(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Your array: ");
            Array.WriteArray(arr);
            Console.Write($"\nAnswer: ");
        }
        #endregion
        public static int FindMinimumElementOfArray(int[] a) //ex.1
        {
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
            {

                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        public static int FindMaximumElementOfArray(int[] a) //ex.2
        {
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {

                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        public static int FindIndexMinElementOfArray(int[] a) //ex.3
        {
            int min = a[0];
            int index = 0;

            for (int i = 1; i < a.Length; i++)
            {

                if (a[i] < min)
                {
                    min = a[i];
                    index = i;
                }
            }
            return index;
        }

        public static int FindIndexMaxElementOfArray(int[] a) //ex.4
        {
            int max = a[0];
            int index = 0;

            for (int i = 1; i < a.Length; i++)
            {

                if (a[i] > max)
                {
                    max = a[i];
                    index = i;
                }
            }
            return index;
        }

        public static int FindSummNumbersOddIndex(int[] a) //ex.5
        {
            int summ = 0;

            for (int i=0; i<a.Length; i++)
            {
                if (i%2!=0)
                {
                    summ += a[i];
                }
            }
            return summ;
        }

        public static void ReverseArray(int[] a) //ex.6
        {
            int[] tmp = new int[a.Length];
            
            for (int i = 0; i < a.Length; i++)
            {
                tmp[i] += a[a.Length - 1 - i];
            }
            
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.Write(tmp[i] + " ");
            }
        }

        public static int FindCountOfOddElements(int[] a) //ex.7
        {
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
        


        
    }
}
