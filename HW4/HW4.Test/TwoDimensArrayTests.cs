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

        [TestCase(TDAMockType.first, "(2,1)")]
        [TestCase(TDAMockType.second, "(2,1)")]
        [TestCase(TDAMockType.third, "(0,2)")]
        public void FindIndexMinElementOfTDArrayTest(TDAMockType type, string expected)
        {
            int[,] arr = TDMock.GetMock(type);
            string actual = TwoDimensArray.FindIndexMinElementOfTDArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TDAMockType.empty)]
        public void FindIndexMinElementOfTDArrayTest_WhenLenghtsLess1_ShouldThrowException(TDAMockType type)
        {
            int[,] arr = TDMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensArray.FindIndexMinElementOfTDArray(arr));
        }

        [TestCase(TDAMockType.first, "(2,2)")]
        [TestCase(TDAMockType.second, "(1,2)")]
        [TestCase(TDAMockType.third, "(2,2)")]
        public void FindIndexMaxElementOfTDArray(TDAMockType type, string expected)
        {
            int[,] arr = TDMock.GetMock(type);
            string actual = TwoDimensArray.FindIndexMaxElementOfTDArray(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TDAMockType.empty)]
        public void FindIndexMaxElementOfTDArrayTest_WhenLenghtsLess1_ShouldThrowException(TDAMockType type)
        {
            int[,] arr = TDMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensArray.FindIndexMaxElementOfTDArray(arr));
        }

        [TestCase(TDAMockType.first, 3)]
        [TestCase(TDAMockType.second, 2)]
        [TestCase(TDAMockType.third, 3)]
        public void FindCountBiggerElementsOfNeighboursTest(TDAMockType type, int expected)
        {
            int[,] arr = TDMock.GetMock(type);
            int actual = TwoDimensArray.FindCountBiggerElementsOfNeighbours(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TDAMockType.empty)]
        public void FindCountBiggerElementsOfNeighboursTest_WhenLenghtsLess1_ShouldThrowException(TDAMockType type)
        {
            int[,] arr = TDMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensArray.FindCountBiggerElementsOfNeighbours(arr));
        }

        [TestCase(TDAMockType.first, TDAMockType.reflectFirst)]
        [TestCase(TDAMockType.second, TDAMockType.reflectSecond)]
        [TestCase(TDAMockType.third, TDAMockType.reflectThird)]
        public void ReflectMirroredDiagonallyTest(TDAMockType type, TDAMockType type1)
        {
            int[,] arr = TDMock.GetMock(type);
            int[,] expected = TwoDimensArray.ReflectMirroredDiagonally(arr);
            int[,] actual = TwoDimensArray.ReflectMirroredDiagonally(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TDAMockType.empty)]
        public void ReflectMirroredDiagonallyTest_WhenLenghtsLess1_ShouldThrowException(TDAMockType type)
        {
            int[,] arr = TDMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensArray.ReflectMirroredDiagonally(arr));
        }
    }
}

