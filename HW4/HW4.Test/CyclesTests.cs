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
        [TestCase(0)]
        public void GetNumbersWhichDecadeOnNumberTest_WhenALessThanZero_ShouldThrowException(int A)
        {
            Assert.Throws<Exception>(() => Cycles.GetNumbersWhichDecadeOnNumber(A));
        }

        [TestCase(6,2)]
        [TestCase(12,3)]
        [TestCase(25,4)]
        public void GetAmountOfPositiveNumbersTest(int A, int expected)
        {
            int actual = Cycles.GetAmountOfPositiveNumbers(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-5)]
        [TestCase(0)]
        public void GetAmountOfPositiveNumbersTest_WhenALessThanZero_ShouldThrowException(int A)
        {
            Assert.Throws<Exception>(() => Cycles.GetAmountOfPositiveNumbers(A));
        }

        [TestCase(624,312)]
        [TestCase(220,110)]
        public void PrintTheLargestDivisorTest(int A, int expected)
        {
            int actual = Cycles.PrintTheLargestDivisor(A);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-228)]
        [TestCase(0)]
        public void PrintTheLargestDivisorTest_WhenALessThanZero_ShouldThrowException(int A)
        {
            Assert.Throws<Exception>(() => Cycles.PrintTheLargestDivisor(A));
        }

        [TestCase(2,19,21)]
        [TestCase(16,30,49)]
        [TestCase(-15,25,21)]
        public void GetSummOfNumbersFromRangeTest(int A, int B, int expected)
        {
            int actual = Cycles.GetSummOfNumbersFromRange(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5,5)]
        [TestCase(12,144)]
        public void GetFibonacciNumberTest(int N, int expected)
        {
            int actual = Cycles.GetFibonacciNumber(N);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-22)]
        [TestCase(0)]
        public void GetFibonacciNumberTest_WhenNLessThanZero_ShouldThrowException(int N)
        {
            Assert.Throws<Exception>(() => Cycles.GetFibonacciNumber(N));
        }

        [TestCase(144,72,72)]
        [TestCase(280,210,70)]
        [TestCase(180,72,36)]
        public void GetLargestDivisorByEuclideanTest(int A, int B, int expected)
        {
            int actual = Cycles.GetLargestDivisorByEuclidean(A, B);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,1)]
        [TestCase(-2,2)]
        [TestCase(0,0)]
        public void GetLargestDivisorByEuclideanTest_WhenAOrBLessThanZero_ShouldThrowException(int A, int B)
        {
            Assert.Throws<Exception>(() => Cycles.GetLargestDivisorByEuclidean(A, B));
        }

        [TestCase(8,2)]
        [TestCase(125,5)]
        public void FindNumberByHalfDivisionTest(int N, int expected)
        {
            int actual = Cycles.FindNumberByHalfDivision(N);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-4)]
        [TestCase(0)]
        public void FindNumberByHalfDivisionTest_WhenNLessThanZero_ShouldThrowException(int N)
        {
            Assert.Throws<Exception>(() => Cycles.FindNumberByHalfDivision(N));
        }
    }
}
