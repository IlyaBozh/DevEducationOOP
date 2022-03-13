
﻿using DevEducationOOP;
/*int a = Cycle.FindSmallerSquaresOfNumbers(63);
Console.WriteLine(a);*/

int[ , ] a = TwoDimensionalArrayController.CreateRandom(2, 4);
TwoDimensionalArrayController.PrintArray(a);

int b = TwoDimensionalArrayController.CountElementsHigherThanNeighbor(a);
Console.WriteLine(b);
//TwoDimensionalArrayController.PrintArray(b);


/*int[] b = ArrayController.SwapHalves(a);

ArrayController.PrintArray(b);*/



