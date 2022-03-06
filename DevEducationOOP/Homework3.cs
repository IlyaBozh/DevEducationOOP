using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP
{
    internal class Cycles
    {
        public static double RaiseNumberToPower(double number, double degreeNumber)
        {
            double result = 1;

            for (int i = 0; i < Math.Abs(degreeNumber); i++)
            {
                result = result * number;
            }

            if (degreeNumber < 0)
            {
                result = 1 / result;
            }

            return result;
        }

        public static List<int> FindDivisibleNumbers(int number)
        {
            List<int> divisibleNumbers = new List<int>();

            for (int i = number; i <= 1000; i += number)
            {
                divisibleNumbers.Add(i);
            }

            return divisibleNumbers;
        }

        // Task 3
        static void FindSmallerSquaresOfNumbers()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int countNumbers = 0;

            while (Math.Pow(countNumbers, 2) < number)
            {
                countNumbers++;
            }

            Console.WriteLine($"The number of numbers whose square is not more than {number} = {countNumbers - 1}");
        }

        // Task 4
        static void FindLargestDivisor()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int divisor = number;

            do
            {
                divisor--;
            } while (number % divisor != 0);

            Console.WriteLine($"The largest divisor of a number {number} = {divisor}");
        }

        // Task 5
        static void FindSumOfNumbersWithDivisorOf7()
        {
            Console.Write("Enter the left border: ");
            int leftBorder = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the right border: ");
            int rightBorder = Convert.ToInt32(Console.ReadLine());
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

            Console.WriteLine($"The sum of the numbers that are divisible by 7 = {SumNumbers}");
        }

        // Task 6
        static void FindFibonacciNumber()
        {
            Console.Write("Enter the number of the Fibonacci number: ");
            int serialNumber = Convert.ToInt32(Console.ReadLine());

            int firstNumber = 1;
            int secondNumber = 1;
            int thirdNumber = 1;

            for (int i = serialNumber; i > 2; i--)
            {
                thirdNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }

            Console.WriteLine($"The number of the Fibonacci series under the number {serialNumber} = {thirdNumber}");
        }

        // Task 7
        static void FindDivisorByEuclidAlgorithm()
        {
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

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

            Console.WriteLine($"The largest divisor of numbers = {largestDivisor}");
        }

        // Task 8
        static void FindNumberByMethodOfHalfDivision()
        {
            Console.Write("Enter the number: ");
            double number = Convert.ToDouble(Console.ReadLine());
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

            Console.WriteLine($"curt({number}) = {middleInterval}");
        }

        // Task 9
        static void FindQuantityOddNumbers()
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
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

            Console.WriteLine($"The number of odd numbers = {countOddNumbers}");
        }

        // Task 10
        static void FindMirrorNumber()
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int mirrorNumber = 0;
            int unit;

            while (number != 0)
            {
                unit = number % 10;
                mirrorNumber = mirrorNumber * 10 + unit;
                number /= 10;
            }

            Console.WriteLine($"Mirror number = {mirrorNumber}");
        }

        // Task 11
        static void FindNumbersWithLargerSumOfEven()
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int tmp;
            int sumOdd = 0;
            int sumEven = 0;
            int unit;
            Console.WriteLine($"Numbers in the range from 1 to {number}: ");

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
                    Console.WriteLine(i);
                }

                sumOdd = 0;
                sumEven = 0;
            }
        }

        // Task 12
        static void ThereAreIdenticalUnits()
        {
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int tmp = number2;
            int unitNumber1;
            int unitNumber2;

            Console.WriteLine("Let's check if these numbers have the same digits.");

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
                        Console.WriteLine("Yes");
                        return;
                    }
                }

                number2 = tmp;
            }

            Console.WriteLine("No");
        }
    }
}
