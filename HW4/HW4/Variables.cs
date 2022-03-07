using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    static class Variables
    {
        public static int GetSolutionOfFormula(int A, int B)
        {
            if (B==A)
            {
                throw new Exception("B mustn't be equal A");
            }

            int result = ((5 * A) + (B * B)) / (B - A);
            return result;
        }
        
        public static double GetSolutionOfLinearEquation(int A, double B, int C)
        {
            if (A==0)
            {
                throw new Exception("A mustn't be 0");
            }

            double result = (C - B) / A;
            return result;
        }

        public static string GetEquationOfStraightLine(int X1, int X2, int Y1, int Y2)
        {
            if (X1==X2)
            {
                throw new Exception("X1 mustn't be equal X2");
            }

            int A = (Y2 - Y1) / (X2 - X1);
            int B = Y2 - (A * X2);
            string sign;
            string result;

            if (B >= 0)
            {
                sign = "+";
            }
            else
            {
                sign = "";
            }

            result = $"Y={A}X{sign}{B}";
            return result;
        }

        public static void OutputDivisionAndDivisionRemainder(int A, int B, out int res1, out int res2)
        {
            if (B==0)
            {
                throw new Exception("B mustn't be 0");
            }

            res1 = A / B;
            res2 = A % B;
        }

        public static void SwapContent(string A, string B, out string copyA, out string copyB)
        {
            copyA = B;
            copyB = A;
        }
    }
}
