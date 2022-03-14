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

        [TestCase(5,1,3,new int[] { 1, 3, 5 })]
        [TestCase(4,7,1,new int[] { 1, 4, 7 })]
        [TestCase(1,2,3,new int[] { 1, 2, 3 })]
        [TestCase(9,-6,-5,new int[] { -6, -5, 9 })]
        [TestCase(7,7,7,new int[] { 7, 7, 7 })]
        public void GetNumbersInAscendingTest(int A, int B, int C, int[] expected)
        {
            int[] actual = IfElse.GetNumbersInAscending(A, B, C);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,-2,-3,new double[] { 3, -1 })]
        [TestCase(-1,-2,15,new double[] { -5, 3 })]
        [TestCase(1,12,36,new double[] { -6 })]
        [TestCase(5,3,7,new double[] { })]
        public void GetSolutionOfQuadraticEquationTest(int A, int B, int C, double[] expected)
        {
            double[] actual = IfElse.GetSolutionOfQuadraticEquation(A, B, C);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,2,6)]
        [TestCase(0,-5,14)]
        public void GetSolutionOfQuadraticEquationTest_WhenAEqualZero_ShouldThrowException(int A, int B, int C)
        {
            Assert.Throws<Exception>(() => IfElse.GetSolutionOfQuadraticEquation(A, B, C));
        }

        [TestCase(25, "Двадцать Пять")]
        [TestCase(19, "Девятнадцать")]
        [TestCase(72, "Семьдесят Два")]
        [TestCase(99, "Девяносто Девять")]
        public void GetNumberInWordsTest(int number, string expected)
        {
            string actual = IfElse.GetNumberInWords(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6)]
        [TestCase(-2)]
        [TestCase(111)]
        public void GetNumberInWordsTest_WhenNumberLessThan10AndHigherThan99_ShouldThrowException(int number)
        {
            Assert.Throws<Exception>(() => IfElse.GetNumberInWords(number));
        }
    }
}
