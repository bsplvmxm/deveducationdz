using NUnit.Framework;
using System;

namespace HW4.Test
{
    public class ArrayTests
    {
        [TestCase(new int[] { 6, 1, 63, 22 }, 1)]
        [TestCase(new int[] { -9, 5, -29 }, -29)]
        [TestCase(new int[] { -11, 99, 4 }, -11)]
        public void FindMinimumElementOfArrayTest(int[] a, int expected)
        {
            int actual = MyArray.FindMinimumElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 1, 63, 22 }, 63)]
        [TestCase(new int[] { -9, -5, -29 }, -5)]
        [TestCase(new int[] { -11, 99, 4 }, 99)]
        public void FindMaximumElementOfArrayTest(int[] a, int expected)
        {
            int actual = MyArray.FindMaximumElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 1, 63, 22 }, 1)]
        [TestCase(new int[] { -9, 5, -29 }, 2)]
        [TestCase(new int[] { -11, 99, 4 }, 0)]
        public void FindIndexMinElementOfArrayTest(int[] a, int expected)
        {
            int actual = MyArray.FindIndexMinElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 1, 63, 22 }, 2)]
        [TestCase(new int[] { -9, -5, -29 }, 1)]
        [TestCase(new int[] { -11, 69, 4, -2, 89 }, 4)]
        public void FindIndexMaxElementOfArrayTest(int[] a, int expected)
        {
            int actual = MyArray.FindIndexMaxElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
