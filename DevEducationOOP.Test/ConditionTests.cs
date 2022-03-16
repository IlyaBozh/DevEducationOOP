using System;
using NUnit.Framework;


namespace DevEducationOOP.Test
{
    public class ConditionTests
    {
        [TestCase(4, 2, 6)]
        [TestCase(1, 6, -5)]
        [TestCase(5, 5, 25)]
        public void PerformArithmeticOperationOnNumbersTest(double number1, double number2, double expectedResult)
        {
            double actualResult = Condition.PerformArithmeticOperationOnNumbers(number1, number2);
            Assert.AreEqual(expectedResult, actualResult);
        }



        [TestCase(0, 0, "On origin of the coordinates")]
        [TestCase(0, 7, "On the y axis")]
        [TestCase(-3, 0, "On the x axis")]
        [TestCase(2, 45, "On the first quarter of the coordinate plane")]
        [TestCase(-23, 4, "On the second quarter of the coordinate plane")]
        [TestCase(-7, -12, "On the third quarter of the coordinate plane")]
        [TestCase(1, -23, "On the fourth quarter of the coordinate plane")]
        public void DeterminePositionOfPointOnCoordinatePlaneTest(double x, double y, string expectedResult)
        {
            string actualResult = Condition.DeterminePositionOfPointOnCoordinatePlane(x, y);
            Assert.AreEqual(expectedResult, actualResult);
        }



        [TestCase(2, 5, 6, new double [] { 2, 5, 6 })]
        [TestCase(1, 12, 8, new double [] { 1, 8, 12 })]
        [TestCase(23, 5, 17, new double [] { 5, 17, 23 })]
        [TestCase(55, 44, 22, new double [] { 22, 44, 55 })]
        [TestCase(11, 102, 2, new double [] { 2, 11, 102 })]
        [TestCase(32, 29, 87, new double [] { 29, 32, 87 })]
        public void SortNumbersTest(double number1, double number2, double number3, double[] expectedSortNumbers)
        {
            double[] actualSortNumbers = Condition.SortNumbers(number1, number2, number3);
            Assert.AreEqual(expectedSortNumbers, actualSortNumbers);
        }



        [TestCase(1, -4, 4, "x = 2")]
        [TestCase(1, 3, -4, "x1 = 1\nx2 = -4")]
        [TestCase(1, -6, 13, "x1 = 3 + 2i\nx2 = 3 - 2i")]
        public void SolveQuadraticEquationTest(double firstCoefficient, double secondCoefficient, double freeTerm, string expectedResult)
        {
            string actualResult = Condition.SolveQuadraticEquation(firstCoefficient, secondCoefficient, freeTerm);
            Assert.AreEqual(expectedResult, actualResult);
        }



        [TestCase(0, 4, -2)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 0, 11)]
        public void SolveQuadraticEquationTest_WhenFirstCoefficientEqualZero_ShouldThrowExeption(
            double firstCoefficient, double secondCoefficient, double freeTerm
            )
        {
            Assert.Throws<Exception>(() => Condition.SolveQuadraticEquation(firstCoefficient, secondCoefficient, freeTerm));
        }



        [TestCase(16, "sixteen")]
        [TestCase(78, "seventy eight")]
        [TestCase(40, "fourty ")]
        public void TranslatNumberIntoWrittenFormTest(int number, string expectedWrittenFormNumbe)
        {
            string actualWriteFormNumber = Condition.TranslatNumberIntoWrittenForm(number);
            Assert.AreEqual(expectedWrittenFormNumbe, actualWriteFormNumber);
        }



        [TestCase(3)]
        [TestCase(456)]
        [TestCase(-10)]
        public void TranslatNumberIntoWrittenFormTest_WhenNumberOutOfRange_ShouldThrowExeption(int number)
        {
            Assert.Throws<Exception>(() => Condition.TranslatNumberIntoWrittenForm(number));
        }
    }
}
