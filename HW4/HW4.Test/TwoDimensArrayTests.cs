using NUnit.Framework;
using System;

namespace HW4.Test
{
    class TwoDimensArrayTests
    {
        [TestCase(TDAMockType.first, -18)]
        [TestCase(TDAMockType.second, -28)]
        [TestCase(TDAMockType.third, -87)]
        public void FindMinElementOfTDArrayTest(TDAMockType type, int expected)
        {
            int[,] arr = TDMock.GetMock(type);
            int actual = TwoDimensArray.FindMinElementOfTDArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TDAMockType.empty)]
        public void FindMinElementOfTDArrayTest_WhenLenghtsLess1_ShouldThrowException(TDAMockType type)
        {
            int[,] arr = TDMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensArray.FindMinElementOfTDArray(arr));
        }

        [TestCase(TDAMockType.first, 33)]
        [TestCase(TDAMockType.second, 11)]
        [TestCase(TDAMockType.third, 13)]
        public void FindMaxElementOfTDArrayTest(TDAMockType type, int expected)
        {
            int[,] arr = TDMock.GetMock(type);
            int actual = TwoDimensArray.FindMaxElementOfTDArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TDAMockType.empty)]
        public void FindMaxElementOfTDArrayTest_WhenLenghtsLess1_ShouldThrowException(TDAMockType type)
        {
            int[,] arr = TDMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensArray.FindMaxElementOfTDArray(arr));
        }
    }
}
