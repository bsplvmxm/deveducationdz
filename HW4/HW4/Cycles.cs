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
    }
}
