using NUnit.Framework;
using System;

namespace HW4.Test
{
    public class VariablesTests
    {
        [TestCase(1,2,9)]
        [TestCase(4,6,28)]
        [TestCase(-3,-6,-7)]
        public void GetSolutionOfFormulaTest(int A, int B, int expected)
        {
            int actual = Variables.GetSolutionOfFormula(A, B);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(0,0)]
        [TestCase(5,5)]
        [TestCase(-7,-7)]
        public void GetSolutionOfFormulaTest_WhenAEqualB_ShouldThrowException(int A, int B)
        {
            Assert.Throws<Exception>(() => Variables.GetSolutionOfFormula(A, B));
        }

        [TestCase(2,3,7,2)]
        [TestCase(4,5,17,3)]
        [TestCase(5,33,-8,-8.2)]
        public void GetSolutionOfLinearEquationTest(int A, double B, int C, double expected)
        {
            double actual = Variables.GetSolutionOfLinearEquation(A, B, C);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,3,5)]
        [TestCase(0,-24,11)]
        public void GetSolutionOfLinearEquationTest_WhenAEqualZero_ShouldThrowException(int A, int B, int C)
        {
            Assert.Throws<Exception>(() => Variables.GetSolutionOfLinearEquation(A, B, C));
        }

        [TestCase(0,1,12,9,"Y=-3X+12")]
        [TestCase(3,5,5,9,"Y=2X-1")]
        [TestCase(4,1,-1,5,"Y=-2X+7")]
        public void GetEquationOfStraightLineTest(int X1, int X2, int Y1, int Y2, string expected)
        {
            string actual = Variables.GetEquationOfStraightLine(X1, X2, Y1, Y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,2,5,1)]
        [TestCase(-7,-7,3,12)]
        [TestCase(0,0,1,9)]
        public void GetEquationOfStraightLineTest_WhenX1EqualX2_ShouldThrowException(int X1, int X2, int Y1, int Y2)
        {
            Assert.Throws<Exception>(() => Variables.GetEquationOfStraightLine(X1, X2, Y1, Y2));
        }
    }
}
