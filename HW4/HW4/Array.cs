using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Array
    {
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
        public static void GetSolutionOfMinimumElement() //ex.1
        {
            Console.Write("Enter lenght of array: ");
            int[] arr = GenerateArray(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Your array: ");
            WriteArray(arr);
            Console.Write($"Min element: {FindMinimumElementOfArray(arr)}");
        }
        public static int FindMinimumElementOfArray(int[] a)
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

        public static void GetSolutionOfMaximumElement() //ex.2
        {
            Console.Write("Enter lenght of array: ");
            int[] arr = GenerateArray(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Your array: ");
            WriteArray(arr);
            Console.Write($"Max element: {FindMaximumElementOfArray(arr)}");
        }

        public static int FindMaximumElementOfArray(int[] a)
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

        public static void GetSolutionOfIndexMinElement() //ex.3
        {
            Console.Write("Enter lenght of array: ");
            int[] arr = GenerateArray(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Your array: ");
            WriteArray(arr);
            Console.Write($"Index of min element: {FindIndexMinElementOfArray(arr)}");
        }
        public static int FindIndexMinElementOfArray(int[] a)
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

        public static void GetSolutionOfIndexMaxElement() //ex.4
        {
            Console.Write("Enter lenght of array: ");
            int[] arr = GenerateArray(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Your array: ");
            WriteArray(arr);
            Console.Write($"Index of min element: {FindIndexMaxElementOfArray(arr)}");
        }
        public static int FindIndexMaxElementOfArray(int[] a)
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

        public static void GetSolutionOfSummNumbersOddIndex() //ex.5
        {
            Console.Write("Enter lenght of array: ");
            int[] arr = GenerateArray(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Your array: ");
            WriteArray(arr);
            Console.Write($"Summ of numbers(odd index): {FindSummNumbersOddIndex(arr)}");
        }

        public static int FindSummNumbersOddIndex(int[] a)
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

        public static void GetSolutionOfCountOddElements() //ex.7
        {
            Console.Write("Enter lenght of array: ");
            int[] arr = GenerateArray(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Your array: ");
            WriteArray(arr);
            Console.Write($"\nCount of odd elements: {FindCountOfOddElements(arr)}");
        }

        public static int FindCountOfOddElements(int[] a)
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
