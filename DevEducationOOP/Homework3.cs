using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP
{
    internal class Cycles
    {
        /// <summary>
        /// Raises a number to a power
        /// </summary>
        /// <param name="number"></param>
        /// <param name="degreeNumber"></param>
        /// <returns></returns>
        public static double RaiseNumberToPower(double number, double degreeNumber)
        {
            double result = 1;

            for (int i = 0; i < Math.Abs(degreeNumber); i++)
            {
                result *= number;
            }

            if (degreeNumber < 0)
            {
                result = 1 / result;
            }

            return result;
        }

        /// <summary>
        /// Returns a list of numbers from 1 to 1000, which are divisible without remainder by the passed number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> FindDivisibleNumbers(int number)
        {
            List<int> divisibleNumbers = new List<int>();

            for (int i = number; i <= 1000; i += number)
            {
                divisibleNumbers.Add(i);
            }

            return divisibleNumbers;
        }

        /// <summary>
        /// Returns the number of numbers whose root is less than the passed number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int FindSmallerSquaresOfNumbers(int number)
        {
            int countNumbers = 0;

            while (Math.Pow(countNumbers, 2) < number)
            {
                countNumbers++;
            }

            return countNumbers;
        }

        /// <summary>
        /// Returns the largest divisor of the transmitted number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double FindLargestDivisor(double number)
        {
            number = Math.Abs(number);
            double LargestDivisor = number;

            do
            {
                LargestDivisor--;
            } while (number % Math.Abs(LargestDivisor) != 0);

            return LargestDivisor;
        }

        /// <summary>
        /// Returns the sum of the numbers in the transmitted range, which are divided without remainder by 7
        /// </summary>
        /// <param name="leftBorder"></param>
        /// <param name="rightBorder"></param>
        /// <returns></returns>
        public static int FindSumOfNumbersWithDivisorOf7(int leftBorder, int rightBorder)
        {
            int SumNumbers = 0;

            if (leftBorder > rightBorder)
            {
                int tmp = leftBorder;
                leftBorder = rightBorder;
                rightBorder = tmp;
            }

            for (int i = leftBorder; i <= rightBorder; i++)
            {
                if (i % 7 == 0)
                {
                    SumNumbers += i;
                }
            }

            return SumNumbers;
        }

        /// <summary>
        /// Returns the Fibonacci number for the transmitted position
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        public static int FindFibonacciNumber(int serialNumber)
        {
            if (serialNumber < 0)
            {
                throw new Exception("The sequence number is less than 0");
            }

            int firstNumber = 1;
            int secondNumber = 1;
            int thirdNumber = 1;

            for (int i = serialNumber; i > 2; i--)
            {
                thirdNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }

            return thirdNumber;
        }

        /// <summary>
        /// Returns the largest divisor of two transmitted numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int FindDivisorByEuclidAlgorithm(int number1, int number2)
        {

            if (number2 > number1)
            {
                int tmp = number1;
                number1 = number2;
                number2 = tmp;
            }

            int largestDivisor = number2;

            while (number1 % number2 != 0)
            {
                largestDivisor = number1 % number2;
                number1 = number2;
                number2 = largestDivisor;
            }

            return Math.Abs(largestDivisor);
        }

        /// <summary>
        /// Returns the root of the equation x = N^3
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double FindRootByMethodOfHalfDivision(double number)
        {
            if (number < 0)
            {
                throw new Exception("The transmitted number is negative");
            }

            double rightBorder = number;
            double leftBorder = 0;
            double middleInterval = (rightBorder + leftBorder) / 2;
            double errorRate = 0.02;

            while (number > Math.Pow(middleInterval, 3) + errorRate || number < Math.Pow(middleInterval, 3) - errorRate)
            {
                if (Math.Pow(middleInterval, 3) > number)
                {
                    rightBorder = middleInterval;
                    middleInterval = (rightBorder + leftBorder) / 2;
                }

                else
                {
                    leftBorder = middleInterval;
                    middleInterval = (rightBorder + leftBorder) / 2;
                }
            }

            return middleInterval;
        }

        /// <summary>
        /// Returns the number of odd units in the transmitted number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int FindQuantityOddNumbers(int number)
        {
            int countOddNumbers = 0;
            int unit;

            while (number != 0)
            {
                unit = number % 10;
                number /= 10;
                if (unit % 2 != 0)
                {
                    countOddNumbers++;
                }
            }

            return countOddNumbers;
        }

        /// <summary>
        /// Returns the mirror number of the transmitted number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int FindMirrorNumber(int number)
        {
            int mirrorNumber = 0;
            int unit;

            while (number != 0)
            {
                unit = number % 10;
                mirrorNumber = mirrorNumber * 10 + unit;
                number /= 10;
            }

            return mirrorNumber;
        }

        /// <summary>
        /// Returns a list of numbers in the range from 1 to the transmitted number in which the 
        /// sum of even units is greater than the sum of odd ones
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> FindNumbersWithLargerSumOfEven(int number)
        {
            if (number < 0)
            {
                throw new Exception("The transmitted number is negative");
            }

            List<int> numbers = new List<int>();
            int tmp;
            int sumOdd = 0;
            int sumEven = 0;
            int unit;

            for (int i = 1; i < number; i++)
            {
                tmp = i;

                while (tmp != 0)
                {
                    unit = tmp % 10;
                    tmp /= 10;
                    if (unit % 2 == 0)
                    {
                        sumEven += unit;
                    }
                    else
                    {
                        sumOdd += unit;
                    }
                }

                if (sumEven > sumOdd)
                {
                    numbers.Add(i);
                }

                sumOdd = 0;
                sumEven = 0;
            }

            return numbers;
        }

        /// <summary>
        /// Returns the result of comparing two passed numbers, if they have the same units, then returns true, otherwise false
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static bool ThereAreIdenticalUnits(int number1, int number2)
        {
            int tmp = number2;
            int unitNumber1;
            int unitNumber2;

            while (number1 != 0)
            {
                unitNumber1 = number1 % 10;
                number1 /= 10;

                while (number2 != 0)
                {
                    unitNumber2 = number2 % 10;
                    number2 /= 10;

                    if (unitNumber1 == unitNumber2)
                    {
                        return true;
                    }
                }

                number2 = tmp;
            }

            return false;
        }
    }
}
