using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP
{
    internal class TwoDimensionalArrayController
    {
        public static int[ , ] CreateRandom(int length)
        {
            Random random = new Random();
            int[ , ] array = new int[length, length];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = random.Next(-100, 100);
                }
            }

            return array;
        }

        public static void PrintArray(int[ , ] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int[ , ] Copy(int[ , ] array)
        {
            int[ , ] newArray = new int[array.GetLength(0), array.GetLength(1)];
            Array.Copy(array, newArray, array.Length);
            return newArray;
        }

        public static int FindMinElement(int[ , ] array)
        {
            int minElement = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                    }
                }
            }

            return minElement;
        }

        public static int FindMaxElement(int[ , ] array)
        {
            int maxElement = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                    }
                }
            }

            return maxElement;
        }

        public static (int, int) FindIndexOfMinElement(int[ , ] array)
        {
            int minElement = array[0, 0];
            int indexOfMinElementRow = 0;
            int indexOfMinElementColumn = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                        indexOfMinElementRow = i;
                        indexOfMinElementColumn = j;
                    }
                }
            }

            return (indexOfMinElementRow, indexOfMinElementColumn);
        }

        public static (int, int) FindIndexOfMaxElement(int[ , ] array)
        {
            int maxElement = array[0, 0];
            int indexOfMaxElementRow = 0;
            int indexOfMaxElementColumn = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                        indexOfMaxElementRow = i;
                        indexOfMaxElementColumn = j;
                    }
                }
            }

            return (indexOfMaxElementRow, indexOfMaxElementColumn);
        }

        public static int FindNumberOfElementsThatLargerThanNeighboring(int [ , ] array)
        {
            int numberOfLargeElements = 0;
            int leftNeighbor;
            int rightNeighbor;
            int upperNeighbor;
            int lowerNeighbor;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    if (i == 0)
                    {
                        upperNeighbor = array[i, j] - 1;
                    }

                    else
                    {
                        upperNeighbor = array[i - 1, j];
                    }

                    if (i == array.GetLength(0) - 1)
                    {
                        lowerNeighbor = array[i, j] - 1;
                    }

                    else
                    {
                        lowerNeighbor = array[i + 1, j];
                    }

                    if (j == 0)
                    {
                        leftNeighbor = array[i, j] - 1;
                    }

                    else
                    {
                        leftNeighbor = array[i, j - 1];
                    }

                    if (j == array.GetLength(1) - 1)
                    {
                        rightNeighbor = array[i, j] - 1;
                    }

                    else
                    {
                        rightNeighbor = array[i, j + 1];
                    }

                    if (array[i, j] > rightNeighbor && array[i, j] > leftNeighbor && array[i, j] > upperNeighbor && array[i, j] > lowerNeighbor)
                    {
                        numberOfLargeElements++;
                    }
                }
            }

            return numberOfLargeElements;
        }

        public static int[ , ] SwapPartsRelativeToMainDiagonal(int[ , ] array)
        {
            int[,] newArray = Copy(array);
            int tmp;

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = i + 1; j < newArray.GetLength(1); j++)
                {
                    tmp = newArray[i, j];
                    newArray[i, j] = newArray[j, i];
                    newArray[j, i] = tmp;
                }
            }

            return newArray;
        }

    }
}
