using NUnit.Framework;
using System;

namespace HW4.Test
{
    public class CyclesTests
    {
        [TestCase(5,2,25)]
        [TestCase(-7,2,49)]
        [TestCase(122,1,122)]
        [TestCase(0,6,0)]
        public void RaiseNumberToDegreeTest(int A, int B, int expected)
        {
            int actual = Cycles.RaiseNumberToDegree(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5,-2)]
        [TestCase(-5,-7)]
        public void RaiseNumberToDegreeTest_WhenBLessThanZero_ShouldThrowException(int A, int B)
        {
            Assert.Throws<Exception>(() => Cycles.RaiseNumberToDegree(A, B));
        }

        [TestCase(250, new int[] { 250, 500, 750, 1000 })]
        [TestCase(500, new int[] { 500, 1000 })]
        public void GetNumbersWhichDecadeOnNumberTest(int A, int[] expected)
        {
            int[] actual = Cycles.GetNumbersWhichDecadeOnNumber(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-222)]
        public void GetNumbersWhichDecadeOnNumberTest_WhenALessThanZero_ShouldThrowException(int A)
        {
            Assert.Throws<Exception>(() => Cycles.GetNumbersWhichDecadeOnNumber(A));
        }
    }
}
