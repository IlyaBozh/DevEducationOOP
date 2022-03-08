using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP
{
    internal class MyArray
    {
        public static int[] CreateRandomArray(int length)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(-100, 100);
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

        public static int FindMinElementOfArray(int[] numbers)
        {
            int minElement = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minElement)
                {
                    minElement = numbers[i];
                }
            }

            return minElement;
        }

        public static int FindMaxElementOfArray(int[] numbers)
        {
            int maxElement = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxElement)
                {
                    maxElement = numbers[i];
                }
            }

            return maxElement;
        }

        public static int FindIndexOfMinElementOfArray(int[] numbers)
        {
            int minElement = numbers[0];
            int indexOfminElement = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minElement)
                {
                    minElement = numbers[i];
                    indexOfminElement = i;
                }
            }

            return indexOfminElement;
        }

        public static int FindIndexOfMaxElementOfArray(int[] numbers)
        {
            int maxElement = numbers[0];
            int indexOfmaxElement = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxElement)
                {
                    maxElement = numbers[i];
                    indexOfmaxElement = i;
                }
            }

            return indexOfmaxElement;
        }

        public static int FindSumOfArrayElementsWithAnOddIndex(int[] numbers)
        {
            int sumOfArrayOddElements = 0;

            for (int i = 1; i < numbers.Length; i += 2)
            {
                sumOfArrayOddElements += numbers[i];
            }
            
            return sumOfArrayOddElements;
        }

        public static int[] FlipArray(int[] numbers)
        {
            int[] reverseArray = new int[numbers.Length];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                reverseArray[numbers.Length - i - 1] = numbers[i];
            }

            return reverseArray;
        }

        public static int FindNumberOfOddArrayElements(int[] number)
        {
            int numberOfOddElements = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 != 0)
                {
                    numberOfOddElements++;
                }
            }

            return numberOfOddElements;
        }

        public static void SwapHalvesOfArray(ref int[] numbers)
        {
            int tmp;
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                tmp = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = tmp;
            }
        }
    }
}
