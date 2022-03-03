using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP
{
    internal class Homework1
    {
/*        public static int[] DivideNumbersWithRemainder(int divisible, int divisor)
        {
            int[] result = new int[2];

            if (divisor == 0)
            {
                Console.WriteLine("Warning!!! Division by 0");
            }

            else
            {
                Console.WriteLine($"Division result: {divisible / divisor}");
                Console.WriteLine($"The remainder of the division: {divisible % divisor}");
            }
        }*/

/*        public static double SolveExpression(double number1, double number2)
        {
            if (number1 == number2)
            {
                Console.WriteLine("Warning!!! Division by 0");
            }
            else
            {
                int result = (int)(5 * number1 + Math.Pow(number2, 2)) / (number2 - number1);
                Console.Write("Calculation result:");
                Console.WriteLine($"(5 * {number1} + {number2}^2) / ({number2} - {number1}) = {result}");
            }
        }*/

        public static string[] SwapLines(string str1, string str2)
        {
            string[] result = new string[2];
            string tmp = str1;
            str1 = str2;
            str2 = tmp;
            result[0] = str1;
            result[1] = str2;
            return result;
        }

        public static double SolveLinearEquation(double firstTerm, double secondTerm, double thirdTerm)
        {
            return (thirdTerm - secondTerm) / firstTerm;
        }

        public static string FindEquationOfStraightLine(double x1, double x2, double y1, double y2)
        {
            string equationOfStraightLine;

            if (-x1* (y2 - y1) / (x2 - x1) + y1 > 0)
            {
                equationOfStraightLine = "y = " + (y2 - y1) / (x2 - x1) + "x + " + -x1 * (y2 - y1) / (x2 - x1) + " + " + y1;
            }

            else if (-x1* (y2 - y1) / (x2 - x1) + y1< 0)
            {
                equationOfStraightLine = "y = " + (y2 - y1) / (x2 - x1) + "x - " + -x1 * (y2 - y1) / (x2 - x1) + " + " + y1;
            }

            else
            {
                equationOfStraightLine = "y = " + (y2 - y1) / (x2 - x1) + "x";
            }

            return equationOfStraightLine;
        }
    }
}
