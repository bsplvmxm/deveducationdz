using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class IfElse
    {
        public static int GetSolutionAfterComparison(int A, int B)
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

        public static string GetNumberOfQuarter(int X, int Y)
        {
            string result = "";

            if (X > 0 && Y > 0)
            {
                result = "The First Quarter";
            }
            else if (X < 0 && Y > 0)
            {
                result = "The Second Quarter";
            }
            else if (X < 0 && Y < 0)
            {
                result = "The Third Quarter";
            }
            else if (X > 0 && Y < 0)
            {
                result = "The Fourth Quarter";
            }

            return result;
        }
    }
}
