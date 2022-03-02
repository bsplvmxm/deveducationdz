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
    }
}
