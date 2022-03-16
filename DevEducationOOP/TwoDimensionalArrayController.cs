using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP
{
    public class TwoDimensionalArrayController
    {
        public static int[ , ] CreateRandom(int numberOfRow, int numberOfcolumn, int min = -100, int max = 101)
        {
            Random random = new Random();
            int[ , ] array = new int[numberOfRow, numberOfcolumn];

            for (int i = 0; i < numberOfRow; i++)
            {
                for (int j = 0; j < numberOfcolumn; j++)
                {
                    array[i, j] = random.Next(min, max);
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
            if (array.Length == 0)
            {
                throw new Exception("An empty array was passed, there is no minimum element");
            }

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
            if (array.Length == 0)
            {
                throw new Exception("An empty array was passed, there is no maximum element");
            }

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
            if (array.Length == 0)
            {
                throw new Exception("An empty array was passed, there is no minimum element");
            }

            int minElement = array[0, 0];
            (int, int) indexOfMinElement = (0, 0);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                        indexOfMinElement.Item1 = i;
                        indexOfMinElement.Item2 = j;
                    }
                }
            }

            return indexOfMinElement;
        }

        public static (int, int) FindIndexOfMaxElement(int[ , ] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("An empty array was passed, there is no maximum element");
            }

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

        public static int CountElementsHigherThanNeighbor(int [ , ] array)
        {
            int numberOfLargeElements = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength (1); j++)
                {
                    if (
                        (i == 0 || array[i, j] > array[i - 1, j]) 
                        && (i == array.GetLength(0) - 1 || array[i, j] > array[i + 1, j])
                        && (j == 0 || array[i, j] > array[i, j - 1])
                        && (j == array.GetLength(1) - 1 || array[i, j] > array[i, j + 1])
                        )
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
