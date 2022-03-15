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

        [TestCase(new int[] { })]
        public void FindMinimumElementOfArrayTest_WhenLengthLess1_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => MyArray.FindMinimumElementOfArray(a));
        }

        [TestCase(new int[] { 6, 1, 63, 22 }, 63)]
        [TestCase(new int[] { -9, -5, -29 }, -5)]
        [TestCase(new int[] { -11, 99, 4 }, 99)]
        public void FindMaximumElementOfArrayTest(int[] a, int expected)
        {
            int actual = MyArray.FindMaximumElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindMaximumElementOfArrayTest_WhenLengthLess1_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => MyArray.FindMaximumElementOfArray(a));
        }

        [TestCase(new int[] { 6, 1, 63, 22 }, 1)]
        [TestCase(new int[] { -9, 5, -29 }, 2)]
        [TestCase(new int[] { -11, 99, 4 }, 0)]
        public void FindIndexMinElementOfArrayTest(int[] a, int expected)
        {
            int actual = MyArray.FindIndexMinElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindIndexMinElementOfArrayTest_WhenLengthLess1_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => MyArray.FindIndexMinElementOfArray(a));
        }

        [TestCase(new int[] { 6, 1, 63, 22 }, 2)]
        [TestCase(new int[] { -9, -5, -29 }, 1)]
        [TestCase(new int[] { -11, 69, 4, -2, 89 }, 4)]
        public void FindIndexMaxElementOfArrayTest(int[] a, int expected)
        {
            int actual = MyArray.FindIndexMaxElementOfArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindIndexMaxElementOfArrayTest_WhenLengthLess1_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => MyArray.FindIndexMaxElementOfArray(a));
        }

        [TestCase(new int[] { 6, 1, 63, 22 }, 23)]
        [TestCase(new int[] { -9, -5, -29 }, -5)]
        [TestCase(new int[] { -11, 69, 4, -2, 89 }, 67)]
        public void FindSummNumbersOddIndexTest(int[] a, int expected)
        {
            int actual = MyArray.FindSummNumbersOddIndex(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindSummNumbersOddIndexTest_WhenLengthLess1_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => MyArray.FindSummNumbersOddIndex(a));
        }

        [TestCase(new int[] { 6, 1, 63, 22 }, new int[] { 22, 63, 1, 6 })]
        [TestCase(new int[] { -9, -5, -29 }, new int[] { -29, -5, -9 })]
        [TestCase(new int[] { -11, 69, 4, -2, 89 }, new int[] { 89, -2, 4, 69, -11 })]
        public void ReverseArrayTest(int[] a, int[] expected)
        {
            int[] actual = MyArray.ReverseArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void ReverseArrayTest_WhenLengthLess1_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => MyArray.ReverseArray(a));
        }

        [TestCase(new int[] { 6, 1, 63, 22 }, 2)]
        [TestCase(new int[] { -9, -5, -29 }, 3)]
        [TestCase(new int[] { -11, 69, 4, -2, 89 }, 3)]
        public void FindCountOfOddElementsTest(int[] a, int expected)
        {
            int actual = MyArray.FindCountOfOddElements(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindCountOfOddElementsTest_WhenLengthLess1_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => MyArray.FindCountOfOddElements(a));
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
        [TestCase(new int[] { -11, 69, 4, -2, 89 }, new int[] { -2, 89, 4, -11, 69 })]
        public void SwapHalfsOfArrayTest(int[] a, int[] expected)
        {
            int[] actual = MyArray.SwapHalfsOfArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void SwapHalfsOfArrayTest_WhenLengthLess1_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => MyArray.SwapHalfsOfArray(a));
        }

        [TestCase(new int[] { 5, -2, 9, 4 }, new int[] { -2, 4, 5, 9 })]
        [TestCase(new int[] { 5, 2, 3, 4, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { -11, 69, 4, -2, 89 }, new int[] { -11, -2, 4, 69, 89 })]
        public void SortByBubbleInAscendingTest(int[] a, int[] expected)
        {
            int[] actual = MyArray.SortByBubbleInAscending(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void SortByBubbleInAscendingTest_WhenLengthLess1_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => MyArray.SortByBubbleInAscending(a));
        }

        [TestCase(new int[] { 5, -2, 9, 4 }, new int[] { 9, 5, 4, -2 })]
        [TestCase(new int[] { 5, 2, 3, 4, 1 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { -11, 69, 4, -2, 89 }, new int[] { 89, 69, 4, -2, -11 })]
        public void SortBySelectInDescendingTest(int[] a, int[] expected)
        {
            int[] actual = MyArray.SortBySelectInDescending(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void SortBySelectInDescendingTest_WhenLengthLess1_ShouldThrowException(int[] a)
        {
            Assert.Throws<Exception>(() => MyArray.SortBySelectInDescending(a));
        }
    }
}
