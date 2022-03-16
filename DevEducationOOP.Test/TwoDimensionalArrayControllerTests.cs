using NUnit.Framework;
using System;

namespace DevEducationOOP.Test
{
    public class TwoDimensionalArrayControllerTests
    {
        [TestCase(TwoDimensionalArrayMockType.FirstArray, -828)]
        [TestCase(TwoDimensionalArrayMockType.SecondArray, 0)]
        [TestCase(TwoDimensionalArrayMockType.ThirdArray, -834)]
        [TestCase(TwoDimensionalArrayMockType.FourthArray, -389)]
        [TestCase(TwoDimensionalArrayMockType.FiveArray, 1)]
        public void FindMinElementTest (TwoDimensionalArrayMockType type, int expectedMinElement)
        {
            int[,] array = TwoDimensionalArrayMock.GetMock(type);
            int actualMinElement = TwoDimensionalArrayController.FindMinElement(array);
            Assert.AreEqual(expectedMinElement, actualMinElement);
        }



        [TestCase(TwoDimensionalArrayMockType.EmptyArray)]
        public void FindMinElementTest_WhenArrayIsEmpty_ShouldReturnExeption(TwoDimensionalArrayMockType type)
        {
            int[,] array = TwoDimensionalArrayMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArrayController.FindMinElement(array));
        }



        [TestCase(TwoDimensionalArrayMockType.FirstArray, 378)]
        [TestCase(TwoDimensionalArrayMockType.SecondArray, 84)]
        [TestCase(TwoDimensionalArrayMockType.ThirdArray, -2)]
        [TestCase(TwoDimensionalArrayMockType.FourthArray, 849)]
        [TestCase(TwoDimensionalArrayMockType.FiveArray, 6)]
        public void FindMaxElementTest(TwoDimensionalArrayMockType type, int expectedMaxElement)
        {
            int[,] array = TwoDimensionalArrayMock.GetMock(type);
            int actualMaxElement = TwoDimensionalArrayController.FindMaxElement(array);
            Assert.AreEqual(expectedMaxElement, actualMaxElement);
        }



        [TestCase(TwoDimensionalArrayMockType.EmptyArray)]
        public void FindMaxElementTest_WhenArrayIsEmpty_ShouldReturnExeption(TwoDimensionalArrayMockType type)
        {
            int[,] array = TwoDimensionalArrayMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArrayController.FindMaxElement(array));
        }



        [TestCase(TwoDimensionalArrayMockType.FirstArray, 2, 3)]
        [TestCase(TwoDimensionalArrayMockType.SecondArray, 2, 0)]
        [TestCase(TwoDimensionalArrayMockType.ThirdArray, 1, 1)]
        [TestCase(TwoDimensionalArrayMockType.FourthArray, 2, 0)]
        [TestCase(TwoDimensionalArrayMockType.FiveArray, 0, 0)]
        public void FindIndexOfMinElementTest(TwoDimensionalArrayMockType type, int expectedIndexOfMinElementRow, int expectedIndexOfMinElementColumn)
        {
            int[,] array = TwoDimensionalArrayMock.GetMock(type);
            (int, int) expectedIndexOfMinElement = (expectedIndexOfMinElementRow, expectedIndexOfMinElementColumn);
            (int, int) actualIndexOfMinElement = TwoDimensionalArrayController.FindIndexOfMinElement(array);
            Assert.AreEqual(expectedIndexOfMinElement, actualIndexOfMinElement);
        }



        [TestCase(TwoDimensionalArrayMockType.EmptyArray)]
        public void FindIndexOfMinElementTest_WhenArrayIsEmpty_ShouldReturnExeption(TwoDimensionalArrayMockType type)
        {
            int[,] array = TwoDimensionalArrayMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArrayController.FindIndexOfMinElement(array));
        }



        [TestCase(TwoDimensionalArrayMockType.FirstArray, 1, 4)]
        [TestCase(TwoDimensionalArrayMockType.SecondArray, 0, 2)]
        [TestCase(TwoDimensionalArrayMockType.ThirdArray, 0, 0)]
        [TestCase(TwoDimensionalArrayMockType.FourthArray, 4, 1)]
        [TestCase(TwoDimensionalArrayMockType.FiveArray, 5, 0)]
        public void FindIndexOfMaxElementTest(TwoDimensionalArrayMockType type, int expectedIndexOfMaxElementRow, int expectedIndexOfMaxElementColumn)
        {
            int[,] array = TwoDimensionalArrayMock.GetMock(type);
            (int, int) expectedIndexOfMaxElement = (expectedIndexOfMaxElementRow, expectedIndexOfMaxElementColumn);
            (int, int) actualIndexOfMaxElement = TwoDimensionalArrayController.FindIndexOfMaxElement(array);
            Assert.AreEqual(expectedIndexOfMaxElement, actualIndexOfMaxElement);
        }



        [TestCase(TwoDimensionalArrayMockType.EmptyArray)]
        public void FindIndexOfMaxElementTest_WhenArrayIsEmpty_ShouldReturnExeption(TwoDimensionalArrayMockType type)
        {
            int[,] array = TwoDimensionalArrayMock.GetMock(type);
            Assert.Throws<Exception>(() => TwoDimensionalArrayController.FindIndexOfMaxElement(array));
        }



        [TestCase(TwoDimensionalArrayMockType.FirstArray, 4)]
        [TestCase(TwoDimensionalArrayMockType.SecondArray, 2)]
        [TestCase(TwoDimensionalArrayMockType.ThirdArray, 2)]
        [TestCase(TwoDimensionalArrayMockType.FourthArray, 6)]
        [TestCase(TwoDimensionalArrayMockType.FiveArray, 1)]
        [TestCase(TwoDimensionalArrayMockType.EmptyArray, 0)]
        public void CountElementsHigherThanNeighborTest(TwoDimensionalArrayMockType type, int expectedNumberOfLargeElements)
        {
            int[,] array = TwoDimensionalArrayMock.GetMock(type);
            int actualNumberOfLargeElements = TwoDimensionalArrayController.CountElementsHigherThanNeighbor(array);
            Assert.AreEqual(expectedNumberOfLargeElements, actualNumberOfLargeElements);
        }



        [TestCase(TwoDimensionalArrayMockType.SecondArray, TwoDimensionalArrayMockType.TransposedSecondArray)]
        [TestCase(TwoDimensionalArrayMockType.ThirdArray, TwoDimensionalArrayMockType.TransposedThirdArray)]
        [TestCase(TwoDimensionalArrayMockType.EmptyArray, TwoDimensionalArrayMockType.EmptyArray)]
        public void SwapPartsRelativeToMainDiagonalTest(TwoDimensionalArrayMockType type, TwoDimensionalArrayMockType expectedType)
        {
            int[,] expectedNewArray = TwoDimensionalArrayMock.GetMock(expectedType);
            int[,] array = TwoDimensionalArrayMock.GetMock(type);
            int[,] actualNewArray = TwoDimensionalArrayController.SwapPartsRelativeToMainDiagonal(array);
            Assert.AreEqual(expectedNewArray, actualNewArray);
        }
    }
}
