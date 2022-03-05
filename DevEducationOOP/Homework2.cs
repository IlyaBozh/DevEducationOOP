using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP
{
    internal class Conditions
    {
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

        public static double[] SortNumbers(double number1, double number2, double number3)
        {
            double[] sortNumbers = new double[3];

            if (number1 > number2 && number2 > number3)
            {
                sortNumbers[0] = number3;
                sortNumbers[1] = number2;
                sortNumbers[2] = number1;
            }

            else if (number1 > number2 && number3 > number2 && number1 > number3)
            {
                sortNumbers[0] = number2;
                sortNumbers[1] = number3;
                sortNumbers[2] = number1;
            }

            else if (number2 > number1 && number1 > number3)
            {
                sortNumbers[0] = number3;
                sortNumbers[1] = number1;
                sortNumbers[2] = number2;
            }

            else if (number2 > number1 && number3 > number1 && number2 > number3)
            {
                sortNumbers[0] = number1;
                sortNumbers[1] = number3;
                sortNumbers[2] = number2;
            }

            else if (number3 > number1 && number1 > number2)
            {
                sortNumbers[0] = number2;
                sortNumbers[1] = number1;
                sortNumbers[2] = number3;
            }

            else
            {
                sortNumbers[0] = number1;
                sortNumbers[1] = number2;
                sortNumbers[2] = number3;
            }

            return sortNumbers;
        }

        #region Methods for solving the quadratic equation
        public static string SolveQuadraticEquation(double firstCoefficient, double secondCoefficient, double freeTerm)
        {
            double discriminant = FindDiscriminant(firstCoefficient, secondCoefficient, freeTerm);

            if (firstCoefficient == 0)
            {
                throw new Exception("The first coefficient cannot be equal to 0");
            }

            if (discriminant > 0)
            {
                return FindRootsOfQuadraticEquation(firstCoefficient, secondCoefficient, discriminant);
            }

            else if (discriminant == 0)
            {
                return FindRootOfQuadraticEquation(firstCoefficient, secondCoefficient);
            }

            else
            {
                return FindComplexRootsOfQuadraticEquation(firstCoefficient, secondCoefficient, discriminant);
            }
        }

        private static double FindDiscriminant(double firstCoefficient, double secondCoefficient, double freeTerm)
        {
            return Math.Pow(secondCoefficient, 2) - 4 * firstCoefficient * freeTerm;
        }

        private static string FindRootsOfQuadraticEquation(double firstCoefficient, double secondCoefficient, double discriminant)
        {
            double x1 = (-secondCoefficient + Math.Sqrt(discriminant)) / (2 * firstCoefficient);
            double x2 = (-secondCoefficient - Math.Sqrt(discriminant)) / (2 * firstCoefficient);
            return "x1 = " + x1 + "\nx2 = " + x2;
        }

        private static string FindRootOfQuadraticEquation(double firstCoefficient, double secondCoefficient)
        {
            double x = -secondCoefficient / (2 * firstCoefficient);
            return "x = " + x;
        }

        private static string FindComplexRootsOfQuadraticEquation(double firstCoefficient, double secondCoefficient, double discriminant)
        {
            double actualPart = -secondCoefficient / (2 * firstCoefficient);
            double imaginaryPart = (Math.Sqrt(discriminant * (-1))) / (2 * firstCoefficient);
            return "x1 = " + actualPart + " + " + imaginaryPart + "i" + "\nx2 = " + actualPart + " - " + imaginaryPart + "i";
        }

        #endregion

        #region Methods for translating numbers into written form
        public static string TranslatNumberIntoWrittenForm(int number)
        {
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
