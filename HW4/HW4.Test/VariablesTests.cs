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
    }
}
