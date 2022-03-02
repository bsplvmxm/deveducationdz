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

        public static int GetAmountOfPositiveNumbers(int A)
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
    }

}
