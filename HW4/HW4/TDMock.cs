using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public static class TDMock
    {
        public static int[,] GetMock(TDAMockType type)
        {
            switch(type)
            {
                case TDAMockType.first:
                    return new int[,]
                    {
                        { 5, 8, 1 },
                        { -2, 3, 16 },
                        { 9, -18, 33 },
                    };
                case TDAMockType.second:
                    return new int[,]
                    {
                        { 1, 3, 2 },
                        { 7, 5, 11 },
                        { -9, -28, 6 },
                    };
                case TDAMockType.third:
                    return new int[,]
                    {
                        { -25, 4, -87 },
                        { 1, 2, 3 },
                        { 8, -6, 13 },
                    };
                case TDAMockType.empty:
                    return new int[,] { };
                default:
                    throw new Exception("a.GetLength(0) and a.GetLength(1) must be >0");

            }
        }
    }
}
