using NUnit.Framework;
using System;

namespace DevEducationOOP.Test
{
    public class CycleTests
    {
        [TestCase(2, 4, 16)]
        [TestCase(-3, 2, 9)]
        [TestCase(-4, 6, 4096)]
        [TestCase(2.5, 5, 97.65625)]
        [TestCase(5, -3, 0.008)]
        public void RaiseNumberToPowerTest(double number, double degreeNumber, double expectedResult)
        {
            double actualResult = Cycle.RaiseNumberToPower(number, degreeNumber);
            Assert.AreEqual(expectedResult, actualResult);  
        }


        
        [TestCase(150, new int[6] {150, 300, 450, 600, 750, 900})]
        [TestCase(-200, new int[5] {200, 400, 600, 800, 1000})]
        public void FindDivisibleNumbersTest(int number, int[] expectedDivisibleNumbers)
        {
            int[] actualDivisibleNumbers = Cycle.FindDivisibleNumbers(number);
            Assert.AreEqual(expectedDivisibleNumbers, actualDivisibleNumbers);
        }



        [TestCase(0)]
        public void FindDivisibleNumbersTest_WhenNumberEqualZero_ShouldThrowExeption(int number)
        {
            Assert.Throws<Exception>(() => Cycle.FindDivisibleNumbers(number));
        }



        [TestCase(6, 2)]
        [TestCase(1, 0)]
        [TestCase(-25, 0)]
        [TestCase(9, 2)]
        public void FindSmallerSquaresOfNumbersTest(int number, int expectedCountNumber)
        {
            int actualCountNumber = Cycle.FindSmallerSquaresOfNumbers(number);
            Assert.AreEqual(expectedCountNumber, actualCountNumber);
        }



        [TestCase(60, 30)]
        [TestCase(-124, 62)]
        [TestCase(23, 1)]
        [TestCase(-7, 1)]
        public void FindLargestDivisorTest(int number, int expectedLargestDivisor)
        {
            int actualLargestDivisor = Cycle.FindLargestDivisor(number);
            Assert.AreEqual(expectedLargestDivisor, actualLargestDivisor);
        }



        [TestCase(0)]
        public void FindLargestDivisorTest_WhenNumberEqualZero_ShoulReturnExeption(int number)
        {
            Assert.Throws<Exception>(() => Cycle.FindLargestDivisor(number));
        }



        [TestCase(7, 22, 42)]
        [TestCase(-15, 6, -21)]
        [TestCase(45, 27, 105)]
        [TestCase(7, 7, 7)]
        [TestCase(0, 0, 0)]
        public void FindSumOfNumbersWithDivisorOf7Test(int leftBorder, int rightBorder, int expectedSumNumbers)
        {
            int actualSumNumbers = Cycle.FindSumOfNumbersWithDivisorOf7(leftBorder, rightBorder);
            Assert.AreEqual(expectedSumNumbers, actualSumNumbers);
        }



        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(11, 89)]
        public void FindFibonacciNumberTest(int serialNumber, int expectedFibocacciNumber)
        {
            int actualFibocacciNumber = Cycle.FindFibonacciNumber(serialNumber);
            Assert.AreEqual(expectedFibocacciNumber, actualFibocacciNumber);
        }



        [TestCase(-23)]
        public void FindFibonacciNumberTest_WhenSerialNumberEqualZero_ShouldThrowExeption(int serialNumber)
        {
            Assert.Throws<Exception>(() => Cycle.FindFibonacciNumber(serialNumber));
        }



        [TestCase(20, 40, 20)]
        [TestCase(64, -48, 16)]
        [TestCase(-12, -44, 4)]
        public void FindDivisorByEuclidAlgorithmTest(int number1, int number2, int expectedLargestDivisor)
        {
            int actualLargestDivisor = Cycle.FindDivisorByEuclidAlgorithm(number1, number2);
            Assert.AreEqual(expectedLargestDivisor, actualLargestDivisor);
        }



        [TestCase(27, 0.02, 3)]
        [TestCase(-64, 0.02, -4)]
        [TestCase(145, 0.02, 5.2532)]
        public void FindRootByMethodOfHalfDivisionTest(double number, double errorRate, double expectedRoot)
        {
            double actualRoot = Cycle.FindRootByMethodOfHalfDivision(number, errorRate);
            Assert.AreEqual(expectedRoot, actualRoot, 0.2);
        }



        [TestCase(123456, 3)]
        [TestCase(222222, 0)]
        [TestCase(13579333, 8)]
        [TestCase(0, 0)]
        [TestCase(-28834928, 2)]
        public void FindQuantityOddNumbersTest(int number, int expectedCountOddNumbers)
        {
            int actualCountOddNumbers = Cycle.FindQuantityOddNumbers(number);
            Assert.AreEqual(expectedCountOddNumbers, actualCountOddNumbers);
        }



        [TestCase(1234, 4321)]
        [TestCase(1000, 1)]
        [TestCase(-8237, -7328)]
        public void FindMirrorNumberTest(int number, int expectedMirrorNumber)
        {
            int actualMirrorNumber = Cycle.FindMirrorNumber(number);
            Assert.AreEqual(expectedMirrorNumber, actualMirrorNumber);
        }



        [TestCase(40, new int[] {2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34, 36, 38})]
        [TestCase(20, new int[] {2, 4, 6, 8, 12, 14, 16, 18,})]
        public void FindNumbersWithLargerSumOfEven(int number, int[] expectedNumbers)
        {
            int[] actualNumbers = Cycle.FindNumbersWithLargerSumOfEven(number);
            Assert.AreEqual(expectedNumbers, actualNumbers);  
        }



        [TestCase(0)]
        [TestCase(-34)]
        public void FindNumbersWithLargerSumOfEven_WhenNumberLessThanZero_ShouldThrowExeption(int number)
        {
            Assert.Throws<Exception>(() => Cycle.FindNumbersWithLargerSumOfEven(number));
        }



        [TestCase(2345, 89234, true)]
        [TestCase(2345, 678696, false)]
        [TestCase(-2345, 230042, true)]
        [TestCase(-292394, -682949, true)]
        public void IsIdenticalUnitsTest(int number1, int number2, bool expectedResult)
        {
            bool actualResult = Cycle.IsIdenticalUnits(number1, number2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
