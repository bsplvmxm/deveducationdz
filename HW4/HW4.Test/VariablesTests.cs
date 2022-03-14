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
    }
}
