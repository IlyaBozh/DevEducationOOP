using NUnit.Framework;
using System;

namespace DevEducationOOP.Test
{
    public class ArrayControllerTests
    {
        [TestCase(new int[] {2,5,12,-14,23,68}, -14)]
        [TestCase(new int[] {1, 94, 2, 5}, 1)]
        [TestCase(new int[] {0, 2, 0, 23}, 0)]
        [TestCase(new int[] {2, 2, 2, 2, 3}, 2)]
        public void FindMinElementTest(int[] array, int expectedMinElement)
        {
            int actualMinElement = ArrayController.FindMinElement(array);
            Assert.AreEqual(expectedMinElement, actualMinElement);
        }



        [TestCase(new int[] { })]
        public void FindMinElementTest_WhenArrayIsEmpty_ShouldReturnExeption(int[] array)
        {
            Assert.Throws<Exception>(() => ArrayController.FindMinElement(array));
        }



        [TestCase(new int[] { 2, 5, 12, -14, 23, 68 }, 68)]
        [TestCase(new int[] { 1, 94, 2, 5 }, 94)]
        [TestCase(new int[] { 0, 2, 0, 23 }, 23)]
        [TestCase(new int[] { 2, 2, 2, 2, 3 }, 3)]
        [TestCase(new int[] { -23, -4, -34, -3}, -3)]
        public void FindMaxElementTest(int[] array, int expectedMaxElement)
        {
            int actualMaxElement = ArrayController.FindMaxElement(array);
            Assert.AreEqual(expectedMaxElement, actualMaxElement);
        }



        [TestCase(new int[] { })]
        public void FindMaxElementTest_WhenArrayIsEmpty_ShouldReturnExeption(int[] array)
        {
            Assert.Throws<Exception>(() => ArrayController.FindMaxElement(array));
        }



        [TestCase(new int[] { 2, 5, 12, -14, 23, 68 }, 3)]
        [TestCase(new int[] { 1, 94, 2, 5 }, 0)]
        [TestCase(new int[] { 0, 2, 8, -2, 0, -11, 98 }, 5)]
        [TestCase(new int[] { 2, 2, 2, 2, 3 }, 0)]
        public void FindIndexOfMinElementTest(int[] array, int expectedIndexOfMinElement)
        {
            int actualIndexOfMinElement = ArrayController.FindIndexOfMinElement(array);
            Assert.AreEqual(expectedIndexOfMinElement, actualIndexOfMinElement);
        }



        [TestCase(new int[] { })]
        public void FindIndexOfMinElementTest_WhenArrayIsEmpty_ShouldReturnExeption(int[] array)
        {
            Assert.Throws<Exception>(() => ArrayController.FindIndexOfMinElement(array));
        }



        [TestCase(new int[] { 2, 5, 12, -14, 23, 68 }, 5)]
        [TestCase(new int[] { 1, 94, 2, 5 }, 1)]
        [TestCase(new int[] { 0, 2, 0, 23 }, 3)]
        [TestCase(new int[] { 2, 2, 2, 2, 3 }, 4)]
        [TestCase(new int[] { -23, -4, -34, -32 }, 1)]
        public void FindIndexOfMaxElementTest(int[] array, int expectedIndexOfMaxElement)
        {
            int actualIndexOfMaxElement = ArrayController.FindIndexOfMaxElement(array);
            Assert.AreEqual(expectedIndexOfMaxElement, actualIndexOfMaxElement);
        }



        [TestCase(new int[] { })]
        public void FindIndexOfMaxElementTest_WhenArrayIsEmpty_ShouldReturnExeption(int[] array)
        {
            Assert.Throws<Exception>(() => ArrayController.FindIndexOfMaxElement(array));
        }



        [TestCase(new int[] { 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { 23, -6, -2, 8 }, 2)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 2, 4, 8, 23, 5, 93 }, 120)]
        [TestCase(new int[] { -4, -38, -1, -3, -12 }, -41)]
        public void FindSumElementsWithAnOddIndexTest(int[] array, int expectedSumOfArrayOddElements)
        {
            int actualSumOfArrayOddElements = ArrayController.FindSumElementsWithAnOddIndex(array);
            Assert.AreEqual(expectedSumOfArrayOddElements, actualSumOfArrayOddElements);
        }



        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 2, 2, 2, 6, 6, 6}, new int[] { 6, 6, 6, 2, 2, 2 })]
        [TestCase(new int[] {}, new int[] {})]
        [TestCase(new int[] { -3, -23, 1, -5, -34, -1 }, new int[] { -1, -34, -5, 1, -23, -3 })]
        [TestCase(new int[] { 23 }, new int[] { 23 })]
        public void FlipTest(int[] array, int[] expectedReverseArray)
        {
            int[] actualReverseArray = ArrayController.Flip(array);
            Assert.AreEqual(expectedReverseArray, actualReverseArray);
        }



        [TestCase(new int[] { 2, 4, 6, 8 }, 0)]
        [TestCase(new int[] { 23, 7, 4, 23, 8, 8 }, 3)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { -3, -4, -56, -27 }, 2)]
        [TestCase(new int[] { 7, 7, 7, 7, 7 }, 5)]
        [TestCase(new int[] { 2, -2, -2 }, 0)]
        public void FindNumberOfOddElementsTest(int[] array, int expectedNumberOfOddElements)
        {
            int actualNumberOfOddElements = ArrayController.FindNumberOfOddElements(array);
            Assert.AreEqual(expectedNumberOfOddElements, actualNumberOfOddElements);
        }



        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3 })]
        [TestCase(new int[] { -23, -4, -3, -1 }, new int[] { -3, -1, -23, -4 })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SwapHalfTest(int[] array, int[]expectedNewArray)
        {
            int[] actualNewArray = ArrayController.SwapHalf(array);
            Assert.AreEqual(expectedNewArray, actualNewArray);
        }



        [TestCase(new int[] { 8, 2, 12, -4, 0 }, new int[] { -4, 0, 2, 8, 12 })]
        [TestCase(new int[] { -4, -76, 6, 99, -4, 6 }, new int[] { -76, -4, -4, 6, 6, 99 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 })]
        public void SortSelectAscendingTest(int[] array, int[] expectedSortArray)
        {
            ArrayController.SortSelectAscending(array);
            Assert.AreEqual(expectedSortArray, array);
        }



        [TestCase(new int[] { 8, 2, 12, -4, 0 }, new int[] { 12, 8, 2, 0, -4 })]
        [TestCase(new int[] { -4, -76, 6, 99, -4, 6 }, new int[] { 99, 6, 6, -4, -4, -76 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 })]
        public void SortInsertDescendingTest(int[] array, int[] expectedSortArray)
        {
            ArrayController.SortInsertDescending(array);
            Assert.AreEqual(expectedSortArray, array);
        }
    }
}
