using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP
{
    internal class Condition
    {
        /// <summary>
        /// Returns the result of an arithmetic operation on numbers, which is selected based on the specified numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static double PerformArithmeticOperationOnNumbers(double number1, double number2)
        {
            double result;

            if (number1 > number2)
            {
                result = number1 + number2;
            }

            else if (number1 < number2)
            {
                result = number1 - number2;
            }

            else
            {
                result = number1 * number2;
            }

            return result;
        }

        /// <summary>
        /// Returns a message about the position of a point on the coordinate plane
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static string DeterminePositionOfPointOnCoordinatePlane(double x, double y)
        {
            string result;

            if (x == 0 && y == 0)
            {
                result = "The point lies at the origin of the coordinates";
            }

            else if (x == 0)
            {
                result = "The point lies on the x axis";
            }

            else if (y == 0)
            {
                result = "The point lies on the y axis";
            }

            else if (x > 0 && y > 0)
            {
                result = "The point belongs to the first quarter of the coordinate plane";
            }

            else if (x < 0 && y > 0)
            {
                result = "The point belongs to the second quarter of the coordinate plane";
            }

            else if (x < 0 && y < 0)
            {
                result = "The point belongs to the third quarter of the coordinate plane";
            }

            else
            {
                result = "The point belongs to the fourth quarter of the coordinate plane";
            }

            return result;
        }

        /// <summary>
        /// Returns a sorted array of three numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        /// <returns></returns>
        public static double[] SortNumbers(double number1, double number2, double number3)
        {
            double[] sortNumbers;

            if (number1 > number2 && number2 > number3)
            {
                sortNumbers = new double[3] {number3, number2, number1};
            }

            else if (number1 > number2 && number3 > number2 && number1 > number3)
            {
                sortNumbers = new double[3] { number2, number3, number1 };
            }

            else if (number2 > number1 && number1 > number3)
            {
                sortNumbers = new double[3] { number3, number1, number2};
            }

            else if (number2 > number1 && number3 > number1 && number2 > number3)
            {
                sortNumbers = new double[3] { number1, number3, number2 };
            }

            else if (number3 > number1 && number1 > number2)
            {
                sortNumbers = new double[3] { number2, number1, number3 };
            }

            else
            {
                sortNumbers = new double[3] { number1, number2, number3 };
            }

            return sortNumbers;
        }

        /// <summary>
        /// Returns the roots of the quadratic equation
        /// </summary>
        /// <param name="firstCoefficient">firstCoefficient != 0</param>
        /// <param name="secondCoefficient"></param>
        /// <param name="freeTerm"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string SolveQuadraticEquation(double firstCoefficient, double secondCoefficient, double freeTerm)
        {
            double discriminant = Math.Pow(secondCoefficient, 2) - 4 * firstCoefficient * freeTerm;
            string result;

            if (firstCoefficient == 0)
            {
                throw new Exception("The first coefficient cannot be equal to 0");
            }

            if (discriminant > 0)
            {
                double x1 = (-secondCoefficient + Math.Sqrt(discriminant)) / (2 * firstCoefficient);
                double x2 = (-secondCoefficient - Math.Sqrt(discriminant)) / (2 * firstCoefficient);
                result =  "x1 = " + x1 + "\nx2 = " + x2;
            }

            else if (discriminant == 0)
            {
                double x = -secondCoefficient / (2 * firstCoefficient);
                result =  "x = " + x;
            }

            else
            {
                double actualPart = -secondCoefficient / (2 * firstCoefficient);
                double imaginaryPart = (Math.Sqrt(discriminant * (-1))) / (2 * firstCoefficient);
                result =  "x1 = " + actualPart + " + " + imaginaryPart + "i" + "\nx2 = " + actualPart + " - " + imaginaryPart + "i";
            }

            return result;
        }

        #region Methods for translating numbers into written form

        /// <summary>
        /// Returns the written form of a number from 10 to 99
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string TranslatNumberIntoWrittenForm(int number)
        {
            if (number < 10 || number > 99)
            {
                throw new Exception("The number does not correspond to the range from 10 to 99");
            }

            int dozen = number / 10;
            int unit = number % 10;
            string writtenFormNumbe;

            if (number < 20)
            {
                writtenFormNumbe = FindNumberOfSecondDozen(unit);
            }

            else
            {
                writtenFormNumbe = FindDozen(dozen) + FindUnit(unit);
            }
            return writtenFormNumbe;
        }

        private static string FindNumberOfSecondDozen (int unit)
        {
            string result = "";

            switch (unit)
            {
                case 0:
                    result = "ten";
                    break;
                case 1:
                    result = "eleven";
                    break;
                case 2:
                    result = "twelve";
                    break;
                case 3:
                    result = "thirteen";
                    break;
                case 4:
                    result = "fourteen";
                    break;
                case 5:
                    result = "fifteen";
                    break;
                case 6:
                    result = "sixteen";
                    break;
                case 7:
                    result = "seventeen";
                    break;
                case 8:
                    result = "eighteen";
                    break;
                case 9:
                    result = "nineteen";
                    break;
                default:
                    break;
            }

            return result;
        }

        private static string FindDozen (int dozen)
        {
            string result = "";

            switch (dozen)
            {
                case 2:
                    result = "twenty ";
                    break;
                case 3:
                    result = "thirty ";
                    break;
                case 4:
                    result = "fourty ";
                    break;
                case 5:
                    result = "fifty ";
                    break;
                case 6:
                    result = "sixty ";
                    break;
                case 7:
                    result = "seventy ";
                    break;
                case 8:
                    result = "eighty ";
                    break;
                case 9:
                    result = "ninety ";
                    break;
                default:
                    break;
            }

            return result;
        }

        private static string FindUnit (int unit)
        {
            string result = "";

            switch (unit)
            {
                case 1:
                    result += "one";
                    break;
                case 2:
                    result += "two";
                    break;
                case 3:
                    result += "three";
                    break;
                case 4:
                    result += "four";
                    break;
                case 5:
                    result += "five";
                    break;
                case 6:
                    result += "six";
                    break;
                case 7:
                    result += "seven";
                    break;
                case 8:
                    result += "eight";
                    break;
                case 9:
                    result += "nine";
                    break;
                default:
                    break;
            }

            return result;
        }
        #endregion
    }
}
