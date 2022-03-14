using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Quarters
{
    I,
    II,
    III,
    IV,
    OnAxle
}

namespace HW4
{
    public class IfElse
    {
        public static int GetSolutionAfterComparison(int A, int B) //ex.1
        {
            int result = 0;

            if (A > B)
            {
                result = A + B;
            }
            else if (A == B)
            {
                result = A * B;
            }
            else if (A < B)
            {
                result = A - B;
            }

            return result;
        }

        public static Quarters GetNumberOfQuarter(int X, int Y) //ex.2
        {        
            Quarters result;

            if (X > 0 && Y > 0)
            {
                result = Quarters.I;
            }
            else if (X < 0 && Y > 0)
            {
                result = Quarters.II;
            }
            else if (X < 0 && Y < 0)
            {
                result = Quarters.III;
            }
            else if (X > 0 && Y < 0)
            {
                result = Quarters.IV;
            }
            else
            {
                result = Quarters.OnAxle;
            }
            return result;
        }

        public static string GetNumberInWords(int number) //ex.5
        {
            int tenth = number / 10;
            int unit = number % 10;
            string tenthNum = "";
            string unitNum = "";
            string result = "";

            if (number > 19)
            {
                if (tenth == 2)
                {
                    tenthNum = "Двадцать";
                }
                else if (tenth == 3)
                {
                    tenthNum = "Тридцать";
                }
                else if (tenth == 4)
                {
                    tenthNum = "Сорок";
                }
                else if (tenth == 5)
                {
                    tenthNum = "Пятьдесят";
                }
                else if (tenth == 6)
                {
                    tenthNum = "Шестьдесят";
                }
                else if (tenth == 7)
                {
                    tenthNum = "Семьдесят";
                }
                else if (tenth == 8)
                {
                    tenthNum = "Восемьдесят";
                }
                else
                {
                    tenthNum = "Девяносто";
                }
                if (unit == 1)
                {
                    unitNum = "Один";
                }
                else if (unit == 2)
                {
                    unitNum = "Два";
                }
                else if (unit == 3)
                {
                    unitNum = "Три";
                }
                else if (unit == 4)
                {
                    unitNum = "Четыре";
                }
                else if (unit == 5)
                {
                    unitNum = "Пять";
                }
                else if (unit == 6)
                {
                    unitNum = "Шесть";
                }
                else if (unit == 7)
                {
                    unitNum = "Семь";
                }
                else if (unit == 8)
                {
                    unitNum = "Восемь";
                }
                else
                {
                    unitNum = "Девять";
                }
                result = tenthNum +" "+ unitNum;
            }
            else
            {
                if (number == 10)
                {
                    result = "Десять";
                }
                else if (number == 11)
                {
                    result = "Одиннадцать";
                }
                else if (number == 12)
                {
                    result = "Двенадцать";
                }
                else if (number == 13)
                {
                    result = "Тринадцать";
                }
                else if (number == 14)
                {
                    result = "Четырнадцать";
                }
                else if (number == 15)
                {
                    result = "Пятнадцать";
                }
                else if (number == 16)
                {
                    result = "Шестнадцать";
                }
                else if (number == 17)
                {
                    result = "Семнадцать";
                }
                else if (number == 18)
                {
                    result = "Восемнадцать";
                }
                else if (number == 19)
                {
                    result = "Девятнадцать";
                }

            }
                return result;
        }

        public static double[] GetSolutionOfQuadraticEquation(int A, int B, int C) //ex.4
        {
            if (A==0)
            {
                throw new Exception("A mustn't be equal 0");
            }

            double discriminant = (B * B) - (4 * A * C);
            double X1;
            double X2;

            if (discriminant > 0)
            {
                X1 = ((-B) + (Math.Sqrt(discriminant))) / (2 * A);
                X2 = ((-B) - (Math.Sqrt(discriminant))) / (2 * A);
                double[] res = new double[2] { X1, X2 };
                return res;
            }
            else if (discriminant == 0)
            {
                X1 = (-B) / (2 * A);
                double[] res = new double[1] { X1 };
                return res;
            }
            else
            {
                double[] res = new double[0];
                return res;
            }
            
        }        
       
        public static int[] GetNumbersInAscending(int A, int B, int C) //ex.3
        {
            int[] newArr = new int[] { A, B, C };
            int tmp;

            for (int i = 0; i < newArr.Length; i++)
            {
                for (int j = i + 1; j < newArr.Length; j++)
                {
                    if (newArr[i] > newArr[j])
                    {
                        tmp = newArr[i];
                        newArr[i] = newArr[j];
                        newArr[j] = tmp;
                    }
                }
            }
            return newArr;
        }
    }
}
