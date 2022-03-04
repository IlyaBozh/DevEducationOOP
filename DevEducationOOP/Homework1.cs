﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP
{
    internal class Variables
    {
        public static void DivideNumbersWithRemainder(double divisible, double divisor, out double divisionResult, out double remainder)
        {

            if (divisor == 0)
            {
                throw new Exception("The user entered a divisor equal to 0");
            }

            divisionResult = divisible / divisor;
            remainder = divisible % divisor;
        }

        public static double SolveExpression(double number1, double number2)
        {
            if (number1 == number2)
            {
                throw new Exception("Division by 0. The user entered two identical numbers, the difference of which gives 0");
            }

            return (5 * number1 + Math.Pow(number2, 2)) / (number2 - number1);
        }

        public static void SwapLines(ref string str1, ref string str2)
        {
            string tmp = str1;
            str1 = str2;
            str2 = tmp;
        }

        public static double SolveLinearEquation(double firstTerm, double secondTerm, double thirdTerm)
        {
            return (thirdTerm - secondTerm) / firstTerm;
        }

        public static string FindEquationOfStraightLine(double x1, double x2, double y1, double y2)
        {
            string equationOfStraightLine;
            double tmp1 = (y2 - y1) / (x2 - x1);
            double tmp2 = -x1 * (y2 - y1) / (x2 - x1);

            if (-x1* (y2 - y1) / (x2 - x1) + y1 > 0)
            {
                equationOfStraightLine = "y = " + tmp1 + "x + " + -x1 * (y2 - y1) / (x2 - x1) + " + " + y1;
            }

            else if (-x1* (y2 - y1) / (x2 - x1) + y1< 0)
            {
                equationOfStraightLine = "y = " + tmp1 + "x - " + -x1 * (y2 - y1) / (x2 - x1) + " + " + y1;
            }

            else
            {
                equationOfStraightLine = "y = " + tmp1 + "x";
            }

            return equationOfStraightLine;
        }
    }
}
