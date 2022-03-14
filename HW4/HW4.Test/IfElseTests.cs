using NUnit.Framework;
using System;

namespace HW4.Test
{
    public class IfElseTests
    {
        [TestCase(5,2,7)]
        [TestCase(4,4,16)]
        [TestCase(4,12,-8)]
        [TestCase(7,-3,4)]
        public void GetSolutionAfterComparisonTest(int A, int B, int expected)
        {
            int actual = IfElse.GetSolutionAfterComparison(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,3,Quarters.I)]
        [TestCase(-1,5,Quarters.II)]
        [TestCase(-7,-4,Quarters.III)]
        [TestCase(3,-9,Quarters.IV)]
        [TestCase(0,-5,Quarters.OnAxle)]
        public void GetNumberOfQuarterTest(int X, int Y, Quarters expected)
        {
            Quarters actual = IfElse.GetNumberOfQuarter(X, Y);
            Assert.AreEqual(expected, actual);

        }
    }
}
