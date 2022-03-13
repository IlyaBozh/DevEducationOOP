using NUnit.Framework;
using System;

namespace DevEducationOOP.Test
{
    public class VariableTests
    {
        [TestCase(10, 3, 3, 1)]
        [TestCase(14, 2, 7, 0)]
        [TestCase(8, 1, 8, 0)]
        [TestCase(-11, 4, -2, -3)]
        [TestCase(-13, -5, 2, -3)]
        [TestCase(0, 6, 0, 0)]
        public void DivisionWithRemainderTest(int divisible, int divisor, int expectedDivisionResult, int expectedRemainder)
        {
            Variable.DivisionWithRemainder(divisible, divisor, out int actualDivisionResult, out int actualRemainder);

            Assert.AreEqual(expectedDivisionResult, actualDivisionResult);
            Assert.AreEqual(expectedRemainder, actualRemainder);
        }

        [TestCase(5, 0)]
        [TestCase(-3, 0)]
        [TestCase(0, 0)]
        public void DivisionWithRemainderTest_WhenDivisorEqualZero_ShouldThrowExeption(int divisible, int divisorint)
        {
            Assert.Throws<Exception>(() => Variable.DivisionWithRemainder(divisible, divisorint, out int divisionResult, out int remainder)); 
        }

        [TestCase(3, 7, 16)]
        [TestCase(-5, 2, -3)]
        [TestCase(-3, -4, -1)]
        [TestCase(8, -2, -4.4)]
        [TestCase(0, 5, 5)]
        [TestCase(5, 0, -5)]
        public void SolveExpressionTest(double number1, double number2, double expectedResultOfExpression)
        {
            double actualResultOfExpression = Variable.SolveExpression(number1, number2);
            Assert.AreEqual(expectedResultOfExpression, actualResultOfExpression);
        }


        [TestCase(4, 4)]
        [TestCase(-12, -12)]
        [TestCase(0, 0)]
        public void SolveExpressionTest_WhenNumber1EqualNumber2_ShouldReturnThrowExeption(double number1, double number2)
        {
            Assert.Throws<Exception>(() => Variable.SolveExpression(number1, number2));
        }

        [TestCase("1234", "5678", "5678", "1234")]
        [TestCase("", "Goodbye", "Goodbye", "")]
        [TestCase("Hello", "", "", "Hello")]
        [TestCase("", "", "", "")]
        [TestCase("  ", " ", " ", "  ")]
        [TestCase("Hi, I'm Piter", "Hi, I'm Quagmir", "Hi, I'm Quagmir", "Hi, I'm Piter")]
        public void SwapLinesTest(string actualStr1, string actuaStr2, string expectedStr1, string expectedStr2)
        {
            Variable.SwapLines(ref actualStr1, ref actuaStr2);
            Assert.AreEqual(expectedStr1, actualStr1);
            Assert.AreEqual(expectedStr2, actuaStr2);
        }

        [TestCase(4, 1, 2, 0.25)]
        [TestCase(6, -4, 8, 2)]
        [TestCase(2, 5, -7, -6)]
        [TestCase(-5, 5, 8, -0.6)]
        [TestCase(-3, -10, 5, -5)]
        [TestCase(4, -13, -7, 1.5)]
        [TestCase(-10, 18, -34, 5.2)]
        [TestCase(-15, -17, -8, -0.6)]
        public void SolveLinearEquationTest(double firstTerm, double secondTerm, double thirdTerm, double expectedRoot)
        {
            double actualRoot = Variable.SolveLinearEquation(firstTerm, secondTerm, thirdTerm);
            Assert.AreEqual(expectedRoot, actualRoot);
        }

        [TestCase(0, 2, 6)]
        [TestCase(0, 0, 0)]
        [TestCase(0, -23, -37)]
        public void SolveLinearEquationTest_WhenFirstTermEqualZero_ShouldReturnThrowExeption(double firstTerm, double secondTerm, double thirdTerm)
        {
            Assert.Throws<Exception>(() => Variable.SolveLinearEquation(firstTerm, secondTerm, thirdTerm));
        }


        [TestCase(2, 7, 4, 7, "y = 7")]
        [TestCase(5, 4, 9, 6, "y = 0,5x + 1,5")]
        [TestCase(6, 8, 2, 2, "y = 1,5x - 1")]
        [TestCase(0, 0, 5, 8, "y = 1,6x")]
        [TestCase(5, 6, 9, 4, "y = -0,5x + 8,5")]
        [TestCase(5, -5, -6, 6, "y = -1x")]
        [TestCase(4, -5, -6, 4, "y = -0,9x - 1,4")]
        public void FindEquationOfStraightLine(double x1, double y1, double x2, double y2, string expectedEquationOfStraightLine)
        {
            string actualEquationOfStraightLine = Variable.FindEquationOfStraightLine(x1, y1, x2, y2);
            Assert.AreEqual(expectedEquationOfStraightLine, actualEquationOfStraightLine);
        }

        [TestCase(4, -6, 4, -12)]
        [TestCase(-12, 65, -12, 1)]
        [TestCase(0, 0, 0, 0)]
        public void FindEquationOfStraightLine_WhenX1EqualX2_ShouldReturnThrowExeption(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<Exception>(() => Variable.FindEquationOfStraightLine(x1, y2, x2, y2));
        }
    }
}