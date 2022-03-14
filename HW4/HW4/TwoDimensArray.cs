using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class TwoDimensArray
    {
        #region HelpPrograms2
        public static int[,] GenerateTwoDimensArray(int a, int b)
        {
            if (a<0 || b<0)
            {
                throw new Exception("lenght must be > 0");
            }
            Random r = new Random();

            int[,] arr = new int[a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] = r.Next(-100, 100);
                }
            }
            return arr;
        }

        public static void WriteTwoDimensArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }

        public static void GetSolutionTDA() //help with program.cs
        {
            Console.WriteLine("Enter lenght of array: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] arr = TwoDimensArray.GenerateTwoDimensArray(a,b);
            Console.WriteLine("Your array: ");
            TwoDimensArray.WriteTwoDimensArray(arr);
            Console.WriteLine($"\nAnswer: ");
        }
        #endregion
        public static int FindMinElementOfTDArray(int[,] a) //ex.1
        {
            int min = a[0,0];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] < min)
                    {
                        min = a[i,j];
                    }
                }
            }
            return min;
        }

        public static int FindMaxElementOfTDArray(int[,] a) //ex.2
        {
            int max= a[0, 0];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            return max;
        }

        public static string FindIndexMinElementOfTDArray(int[,] a) //ex.3
        {
            int min = a[0,0];
            string index = "";

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        index = $"({i},{j})";
                    }
                }
            }
            return index;
        }

        public static string FindIndexMaxElementOfTDArray(int[,] a) //ex.4
        {
            int max = a[0, 0];
            string index = "";

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        index = $"({i},{j})";
                    }
                }
            }
            return index;
        }

        public static int FindCountBiggerElementsOfNeighbours(int[,] a) //ex.5
        {
            int count = 0;
            

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ((i==0 || a[i,j] > a[i-1, j])
                        && (i==a.GetLength(0)-1 || a[i, j] > a[i + 1, j])
                        && (j == 0 || a[i, j] > a[i, j-1])
                        && (j == a.GetLength(1) - 1 || a[i, j] > a[i, j+1]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int[,] ReflectMirroredDiagonally(int[,] a) //ex.6
        {
            int tmp;
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = i + 1; j < a.GetLength(1); j++)
                {
                    tmp = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = tmp;
                }
            }
            return a;
        }
    }
}
