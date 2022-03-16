using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP
{
    public class ArrayController
    {
        public static int[] CreateRandom(int length, int min = -100, int max = 101)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(min, max);
            }

            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public static int[] Copy (int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);
            return newArray;
        }

        public static int FindMinElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("An empty array was passed, there is no minimum element");
            }

            int minElement = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                }
            }

            return minElement;
        }

        public static int FindMaxElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("An empty array was passed, there is no maximum element");
            }

            int maxElement = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }

            return maxElement;
        }

        public static int FindIndexOfMinElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("An empty array was passed, there is no minimum element");
            }

            int minElement = array[0];
            int indexOfminElement = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                    indexOfminElement = i;
                }
            }

            return indexOfminElement;
        }

        public static int FindIndexOfMaxElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("An empty array was passed, there is no maximum element");
            }

            int maxElement = array[0];
            int indexOfmaxElement = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    indexOfmaxElement = i;
                }
            }

            return indexOfmaxElement;
        }

        public static int FindSumElementsWithAnOddIndex(int[] array)
        {
            int sumOfArrayOddElements = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sumOfArrayOddElements += array[i];
            }
            
            return sumOfArrayOddElements;
        }

        public static int[] Flip(int[] array)
        {
            int[] reverseArray = Copy(array);
            int tmp;

            for (int i = 0; i < reverseArray.Length / 2; i++)
            {
                tmp = reverseArray[array.Length - i - 1];
                reverseArray[array.Length - i - 1] = reverseArray[i];
                reverseArray[i] = tmp;
            }

            return reverseArray;
        }

        public static int FindNumberOfOddElements(int[] array)
        {
            int numberOfOddElements = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    numberOfOddElements++;
                }
            }

            return numberOfOddElements;
        }

        public static int[] SwapHalf(int[] array)
        {
            int[] newArray = Copy(array);
            int tmp;
            int n = newArray.Length / 2;
            int step = n + newArray.Length % 2;

            for (int i = 0; i < n; i++)
            {
                tmp = newArray[i];
                newArray[i] = newArray[i + step];
                newArray[i + step] = tmp;
            }

            return newArray;
        }

        public static void SortSelectAscending(int[] array)
        {
            int tmp;
            int indexOfMinElement;

            for (int i = 0; i < array.Length; i++)
            {
                indexOfMinElement = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[indexOfMinElement])
                    {
                        indexOfMinElement = j;
                    }
                }

                tmp = array[i];
                array[i] = array[indexOfMinElement];
                array[indexOfMinElement] = tmp;
            }
        }

        public static void SortInsertDescending(int[] array)
        {
            int tmp;
            int j;

            for (int i = 0; i < array.Length; i++)
            {
                tmp = array[i];
                j = i;

                while (j > 0 && array[j - 1] < tmp)
                {
                    tmp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = tmp;
                    j--;
                }

                array[j] = tmp;
            }
        }
    }
}
