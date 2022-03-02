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
            int result = ((5 * A) + (B * B)) / (B - A);
            return result;
        }
        
        public static double GetSolutionOfLinearEquation(int A, double B, int C)
        {
            double result = (C - B) / A;
            return result;
        }

        public static string GetEquationOfStraightLine(int X1, int X2, int Y1, int Y2)
        {
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

            result = "Y=" + A + "X" + sign + B;
            return result;
        }
    }
}
