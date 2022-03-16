using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationOOP.Test
{
    public class TwoDimensionalArrayMock
    {
        public static int[,] GetMock(TwoDimensionalArrayMockType type)
        {
            switch (type)
            {
                case TwoDimensionalArrayMockType.FirstArray:
                    return new int[,] {
                        { 2, 40, 94, 38, -22 },
                        { 93, -2, -56, -4, 378 },
                        { 0, 39, -78, -828, 5 }
                    };

                case TwoDimensionalArrayMockType.SecondArray:
                    return new int[,] {
                        { 3, 83, 84 },
                        { 9, 74, 29 },
                        { 0, 11, 44 }
                    };

                case TwoDimensionalArrayMockType.TransposedSecondArray:
                    return new[,] {
                        { 3, 9, 0 },
                        { 83, 74, 11 },
                        { 84, 29, 44 }
                    };
                
                case TwoDimensionalArrayMockType.ThirdArray:
                    return new int[,] {
                        { -2, -74, -472 },
                        { -3, -834, -349},
                        { -18, -8, -99 }
                    };

                case TwoDimensionalArrayMockType.TransposedThirdArray:
                    return new int[,] {
                        { -2, -3, -18 },
                        { -74, -834, -8 },
                        { -472, -349, -99 }
                    };
                
                case TwoDimensionalArrayMockType.FourthArray:
                    return new int[,] {
                        { -4, 15 },
                        { 66, -1 },
                        { -389, 763 },
                        { 9, -28 },
                        { -93, 849 },
                        { 1, -2 },
                    };

                case TwoDimensionalArrayMockType.FiveArray:
                    return new int[,] {
                        { 1 },
                        { 2 },
                        { 3 },
                        { 4 },
                        { 5 },
                        { 6 }
                    };

                case TwoDimensionalArrayMockType.EmptyArray:
                    return new int[,] { };

                default:
                    throw new Exception();
            }
        }
    }
}
