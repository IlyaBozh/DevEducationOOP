using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP
{
    internal class Homework2
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

            else if (number1 > number2 && number3 > number2)
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

            else if (number2 > number1 && number3 > number1)
            {
                sortNumbers[0] = number1;
                sortNumbers[1] = number3;
                sortNumbers[2] = number2;
            }

            else if (number3 > number1 && number2 > number1)
            {
                sortNumbers[0] = number1;
                sortNumbers[1] = number2;
                sortNumbers[2] = number3;
            }

            else
            {
                sortNumbers[0] = number2;
                sortNumbers[1] = number1;
                sortNumbers[2] = number3;
            }

            return sortNumbers;
        }

/*        static void SolveQuadraticEquation()
        {
            Console.Write("Enter the first coefficient of the quadratic equation: ");
            double firstCoefficient = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second coefficient of the quadratic equation: ");
            double secondCoefficient = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the free term of the quadratic equation: ");
            double freeTerm = Convert.ToDouble(Console.ReadLine());
            double discriminant = Math.Pow(secondCoefficient, 2) - 4 * firstCoefficient * freeTerm;
            Console.WriteLine($"Let 's solve a quadratic equation of the form Ax^2 + Bx + C = 0");
            Console.WriteLine($"Discriminant = {discriminant}");

            if (discriminant > 0)
            {
                Console.WriteLine("The equation has two roots:");
                Console.WriteLine($"x1 = {(-secondCoefficient + Math.Sqrt(discriminant)) / (2 * firstCoefficient)}");
                Console.WriteLine($"x2 = {(-secondCoefficient - Math.Sqrt(discriminant)) / (2 * firstCoefficient)}");
            }

            else if (discriminant == 0)
            {
                Console.WriteLine("The equation has one root:");
                Console.WriteLine($"x = {-secondCoefficient / (2 * firstCoefficient)}");
            }

            else
            {
                Console.WriteLine("The equation has two roots in the form of complex numbers:");
                Console.Write($"x1 = {-secondCoefficient / (2 * firstCoefficient)} + ");
                Console.WriteLine($"{(Math.Sqrt(discriminant * (-1))) / (2 * firstCoefficient)}i");
                Console.Write($"x2 = {-secondCoefficient / (2 * firstCoefficient)} - ");
                Console.WriteLine($"{(Math.Sqrt(discriminant * (-1))) / (2 * firstCoefficient)}i");
            }
        }*/

        public static string TranslatNumberIntoWrittenForm(int number)
        {
            int dozen = number / 10;
            int unit = number % 10;
            string writtenFormNumbe = "";

            if (number < 20)
            {
                switch (unit)
                {
                    case 0:
                        writtenFormNumbe = "ten";
                        break;
                    case 1:
                        writtenFormNumbe = "eleven";
                        break;
                    case 2:
                        writtenFormNumbe = "twelve";
                        break;
                    case 3:
                        writtenFormNumbe = "thirteen";
                        break;
                    case 4:
                        writtenFormNumbe = "fourteen";
                        break;
                    case 5:
                        writtenFormNumbe = "fifteen";
                        break;
                    case 6:
                        writtenFormNumbe = "sixteen";
                        break;
                    case 7:
                        writtenFormNumbe = "seventeen";
                        break;
                    case 8:
                        writtenFormNumbe = "eighteen";
                        break;
                    case 9:
                        writtenFormNumbe = "nineteen";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (dozen)
                {
                    case 2:
                        writtenFormNumbe = "twenty ";
                        break;
                    case 3:
                        writtenFormNumbe = "thirty ";
                        break;
                    case 4:
                        writtenFormNumbe = "fourty ";
                        break;
                    case 5:
                        writtenFormNumbe = "fifty ";
                        break;
                    case 6:
                        writtenFormNumbe = "sixty ";
                        break;
                    case 7:
                        writtenFormNumbe = "seventy ";
                        break;
                    case 8:
                        writtenFormNumbe = "eighty ";
                        break;
                    case 9:
                        writtenFormNumbe = "ninety ";
                        break;
                    default:
                        break;
                }

                switch (unit)
                {
                    case 1:
                        writtenFormNumbe += "one";
                        break;
                    case 2:
                        writtenFormNumbe += "two";
                        break;
                    case 3:
                        writtenFormNumbe += "three";
                        break;
                    case 4:
                        writtenFormNumbe += "four";
                        break;
                    case 5:
                        writtenFormNumbe += "five";
                        break;
                    case 6:
                        writtenFormNumbe += "six";
                        break;
                    case 7:
                        writtenFormNumbe += "seven";
                        break;
                    case 8:
                        writtenFormNumbe += "eight";
                        break;
                    case 9:
                        writtenFormNumbe += "nine";
                        break;
                    default:
                        break;
                }
            }
            return writtenFormNumbe;
        }
    }
}
