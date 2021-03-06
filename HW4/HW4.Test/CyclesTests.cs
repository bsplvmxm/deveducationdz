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

        [TestCase(125,2)]
        [TestCase(2951,3)]
        [TestCase(552147,4)]
        public void GetAmountOddDigitsOfNumberTest(int number, int expected)
        {
            int actual = Cycles.GetAmountOddDigitsOfNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-19)]
        [TestCase(0)]
        public void GetAmountOddDigitsOfNumberTest_WhenNumberLessThanZero_ShouldThrowException(int number)
        {
            Assert.Throws<Exception>(() => Cycles.GetAmountOddDigitsOfNumber(number));
        }

        [TestCase(100,1)]
        [TestCase(1234,4321)]
        [TestCase(51426,62415)]
        public void FindMirroredNumberTest(int number, int expected)
        {
            int actual = Cycles.FindMirroredNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-11)]
        [TestCase(0)]
        public void FindMirroredNumberTest_WhenNumberLessThanZero_ShouldThrowException(int number)
        {
            Assert.Throws<Exception>(() => Cycles.FindMirroredNumber(number));
        }

        [TestCase(10,new int[] { 2, 4, 6, 8 })]
        [TestCase(25,new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24 })]
        public void GetSummEvenNumWhichHigherOddNumTest(int N, int[] expected)
        {
            int[] actual = Cycles.GetSummEvenNumWhichHigherOddNum(N);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-55)]
        [TestCase(0)]
        public void GetSummEvenNumWhichHigherOddNumTest_WhenNLessThanZero_ShouldThrowException(int N)
        {
            Assert.Throws<Exception>(() => Cycles.GetSummEvenNumWhichHigherOddNum(N));
        }

        [TestCase(123,3456789,true)]
        [TestCase(500,99,false)]
        public void FindIfThereSameDigitsTest(int number1, int number2, bool expected)
        {
            bool actual = Cycles.FindIfThereSameDigits(number1, number2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-21,123)]
        [TestCase(0,7582)]
        public void FindIfThereSameDigitsTest_WhenN1OrN2LessThanZero_ShouldThrowException(int number1, int number2)
        {
            Assert.Throws<Exception>(() => Cycles.FindIfThereSameDigits(number1,number2));
        }
    }
}
