using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP 
{
    public class Variable
    {
        /// <summary>
        /// Divides two numbers
        /// </summary>
        /// <param name="divisible"></param>
        /// <param name="divisor">The divisor cannot be equal to 0</param>
        /// <param name="divisionResult"></param>
        /// <param name="remainder"></param>
        /// <exception cref="Exception"></exception>
        public static void DivisionWithRemainder(int divisible, int divisor, out int divisionResult, out int remainder)
        {

            if (divisor == 0)
            {
                throw new Exception("The user entered a divisor equal to 0");
            }

            divisionResult = divisible / divisor;
            remainder = divisible % divisor;
        }

        /// <summary>
        /// Returns the result of the expression (5*A + B^2) / (B - A)
        /// </summary>
        /// <param name="number1">number1 != number2</param>
        /// <param name="number2">number2 != number1</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static double SolveExpression(double number1, double number2)
        {
            if (number1 == number2)
            {
                throw new Exception("Division by 0. The user entered two identical numbers, the difference of which gives 0");
            }

            return (5 * number1 + Math.Pow(number2, 2)) / (number2 - number1);
        }

        /// <summary>
        /// Swaps the values of variable strings
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        public static void SwapLines(ref string str1, ref string str2)
        {
            string tmp = str1;
            str1 = str2;
            str2 = tmp;
        }

        /// <summary>
        /// Returns the root of a linear equation
        /// </summary>
        /// <param name="firstTerm">firstTerm != 0</param>
        /// <param name="secondTerm"></param>
        /// <param name="thirdTerm"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static double SolveLinearEquation(double firstTerm, double secondTerm, double thirdTerm)
        {
            if (firstTerm == 0)
            {
                throw new Exception("The first term must not be equal to 0");
            }

            return (thirdTerm - secondTerm) / firstTerm;
        }

        /// <summary>
        /// Returns the equation of a straight line that passes through two given points
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static string FindEquationOfStraightLine(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new Exception("The x-coordinates of the points should not be equal");
            }

            string equationOfStraightLine;
            double tmp1 = (y2 - y1) / (x2 - x1);
            double tmp2 = -x1 * (y2 - y1) / (x2 - x1) + y1;

            if (tmp1 == 0)
            {
                equationOfStraightLine = "y = " + tmp2;
            }

            else if (tmp2 > 0)
            {
                equationOfStraightLine = "y = " + tmp1 + "x + " + tmp2;
            }

            else if (tmp2 < 0)
            {
                equationOfStraightLine = "y = " + tmp1 + "x - " + tmp2 * (-1);
            }

            else
            {
                equationOfStraightLine = "y = " + tmp1 + "x";
            }

            return equationOfStraightLine;
        }
    }
}
